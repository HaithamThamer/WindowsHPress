using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
namespace HPress
{
    public class Bill
    {
        public bool isAccount;

        public bool isSell;

        public bool isCash;

        public int id;

        public int delegatePercent;

        public double discount;

        public string clientName;

        public string note;

        public string isDollar;

        public string delegateName;

        public DateTime datetime;

        public DataTable products;
    }
}
