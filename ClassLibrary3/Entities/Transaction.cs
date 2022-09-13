using NailProject.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NailProject.Data.Entities
{
    internal class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { set; get; }
        public int ExternalTransactionId {set;get;}
        public int Amount { set; get; }
        public decimal Fee { set; get; }

        public string Results { set; get; }

        public string Message { set; get; }

        public Status Status { set; get; }

        public string Provider { set; get; }
    }
}
