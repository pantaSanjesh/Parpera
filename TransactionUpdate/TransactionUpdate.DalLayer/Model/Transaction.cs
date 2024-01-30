using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionUpdate.DalLayer.Model
{
    public class TransactionModel 
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public string DateTime { get; set; }
        public string Status { get; set; }
    
    }
}
