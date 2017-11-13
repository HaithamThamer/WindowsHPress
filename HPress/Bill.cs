using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPress
{
    public class Bill
    {
        public bool
            isAccount,
            isSell,
            isCash;

        public int 
            id,
            delegatePercent
            ;
        public double
            discount;
        public string
            clientName,
            note,
            isDollar,
            delegateName;
        public DateTime
            datetime;
        public System.Data.DataTable products;
        public Bill()
        {

        }

    }
}
