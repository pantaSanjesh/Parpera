using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionUpdate.DalLayer.Interface;

namespace TransactionUpdate.DalLayer.Model
{
    public class AuditableEntity : IAuditableEntity
    {
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        [MaxLength(256)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModiefiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
