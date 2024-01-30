using Microsoft.AspNetCore.Mvc;
using Moq;
using TransactionUpdate.Controllers;
using TransactionUpdate.DalLayer.Model;
using TransactionUpdate.DalLayer.Repositories;

namespace TransactionUpdate.Tests
{
    public class TransactionControllerTests
    {
        [Fact]
        public void GetAll_ReturnsListOfTransactions()
        {
            // Arrange
            var mockRepo = new Mock<ITransactionRepository>();
            var transactions = new List<TransactionModel>
            {
                new TransactionModel { Id = 1, DateTime = "2020-09-08'T'16:34:23Z", Description = "Transaction 1", Amount = 100.00, Status = "Pending" },
                new TransactionModel { Id = 2, DateTime = "2021-09-08'T'09:02:23Z", Description = "Transaction 2", Amount = 200.00, Status = "Completed" }
            };
            mockRepo.Setup(repo => repo.GetAllTransactions()).Returns(transactions);
            var controller = new TransactionController(mockRepo.Object);

            // Act
            var result = controller.GetAll();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<TransactionModel>>(okResult.Value);
            Assert.Equal(2, model.Count());
        }
        [Fact]
        public void UpdateTransactionStatus_WithValidId_ReturnsOkResult()
        {
            // Arrange
            int id = 1;
            string newStatus = "Completed";
            var mockRepo = new Mock<ITransactionRepository>();
            mockRepo.Setup(repo => repo.GetById(id)).Returns(new TransactionModel { Id = id, Status = "Pending" });
            var controller = new TransactionController(mockRepo.Object);

            // Act
            var result = controller.UpdateTransactionStatus(id, newStatus);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Transaction status updated successfully", okResult.Value);
        }

        [Fact]
        public void UpdateTransactionStatus_WithInvalidId_ReturnsNotFoundResult()
        {
            // Arrange
            int id = 1;
            string newStatus = "Completed";
            var mockRepo = new Mock<ITransactionRepository>();
            mockRepo.Setup(repo => repo.GetById(id)).Returns((TransactionModel)null);
            var controller = new TransactionController(mockRepo.Object);

            // Act
            var result = controller.UpdateTransactionStatus(id, newStatus);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public void UpdateTransactionStatus_ThrowsException_ReturnsStatusCode500()
        {
            // Arrange
            int id = 1;
            string newStatus = "Completed";
            var mockRepo = new Mock<ITransactionRepository>();
            mockRepo.Setup(repo => repo.GetById(id)).Throws(new Exception("Sample exception"));
            var controller = new TransactionController(mockRepo.Object);

            // Act
            var result = controller.UpdateTransactionStatus(id, newStatus);

            // Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }
    }
}