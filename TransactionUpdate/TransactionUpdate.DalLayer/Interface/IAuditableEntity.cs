using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionUpdate.DalLayer.Interface
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        string ModifiedBy { get; set; }
        DateTime? CreatedDate { get; set; }
        DateTime? ModiefiedDate { get; set; }
    }
}

