using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACGProjectGoGlobal.Web.ViewModels
{
    public class UserViewModel
    {
        public string Name { get; set; }

        public string Profession { get; set; }

        public decimal Budget { get; set; }

        public int ContractID { get; set; }

        public DateTime DeliveryDate { get; set; }

        public string ImagePath { get; set; }
    }
}
