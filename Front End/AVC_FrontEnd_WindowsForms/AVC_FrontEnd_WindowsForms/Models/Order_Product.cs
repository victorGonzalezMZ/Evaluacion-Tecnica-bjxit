using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC_FrontEnd_WindowsForms.Models
{
    public class Order_Product
    {
        public int     ID       { get; set; }
        public Product Product  { get; set; }
        public Order   Order    { get; set; }
        public int     Quantity { get; set; }
    }
}
