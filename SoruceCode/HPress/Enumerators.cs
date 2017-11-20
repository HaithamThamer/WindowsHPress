using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPress
{
    public class Enumerators
    {
        public enum Settings
        {
            ServerIP,
            DatabaseUsername,
            DatabasePassword,
            DatabaseName,
            logo1,
            address,
            facebook,
            phone,
            email,
            color,
            logoPrint
        }
        public enum clientType
        {
            Client,
            Supplier,
            Delegate,
            Employer
        }
        public enum UserType
        {
            Admin,
            User,
            Guest
        }
        public enum ReportForm
        {
            none,
            ReportGeneral,
            DelegateReport,
            ReportSequance,
            BillWithReport,
            caseValue,
            EmpReport
        }
        public enum ReportsName
        {
            none,
            Daily,
            BillsProducts,
            BillReport,
            DebitsClients,
            CaseValue,
            DebitsSell,
            EmployeeDebits,
            Client,
            Employee,
            Delegates,
            Delegate,
            ReportDate,
            Bills,
            Products,
            ClientPay

        }
    }
}
