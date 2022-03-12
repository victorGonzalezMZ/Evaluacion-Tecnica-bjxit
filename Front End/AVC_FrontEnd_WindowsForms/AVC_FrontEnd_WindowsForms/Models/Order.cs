using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC_FrontEnd_WindowsForms.Models
{
    public class Order
    {
        public string   ID                    { get; set; }
        public User     Seller                { get; set; }
        public User     Client                { get; set; }
        public User     Deliverer             { get; set; }
        public int      Total_Items           { get; set; }
        public double   Total_Price           { get; set; }
        public string   Delivery_Instructions { get; set; }
        public DateTime Date_Ordered          { get; set; }
        public DateTime Date_Delivered        { get; set; }
        public bool     Status_Delivery       { get; set; }
    }
}
