using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShop_Jagdeep.BussLayer
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int EmployeeID { get; set; }
        public int FlowerID { get; set; }
        public Employee Employee { get; set; }
        public Flower Flower { get; set; }
    }
}
