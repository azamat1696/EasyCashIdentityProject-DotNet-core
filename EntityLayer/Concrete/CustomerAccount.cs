using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CustomerAccount
    {
        [Key]
        public int CustomerAccoubtID { get; set; }

        public string CustomerAccountNumber { get; set; }

        public string CusromerAccountCurrency { get; set;}

        public decimal CusromerAccountBalance { get; set; }

        public string BankBranch { get; set; }



    }
}
