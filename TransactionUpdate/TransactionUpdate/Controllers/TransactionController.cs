using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TransactionUpdate.DalLayer.Repositories;

namespace TransactionUpdate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionRepository _transactionRepository;
        public TransactionController(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            try
            {
                var transactionList = _transactionRepository.GetAllTransactions();
                if(transactionList != null) 
                {
                    return Ok(transactionList);
                }
                else
                {
                    return StatusCode(StatusCodes.Status200OK ,"Transaction List is empty");
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { error = ex.Message });
            }
        }
        [HttpPut("{id}/update-status")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult UpdateTransactionStatus(int id,  string newStatus)
        {
            try
            {
                var transaction = _transactionRepository.GetById(id);

                if (transaction != null)
                {
                    
                   _transactionRepository.UpdateStatus(id, newStatus);
                    return Ok( "Transaction status updated successfully" );
                }
                else
                {
                    return NotFound(new { error = "Transaction not found" });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = ex.Message });
            }
        }
    }
}
