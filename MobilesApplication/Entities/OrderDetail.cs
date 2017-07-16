using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Entities
{
    [TableName("OrderDetails")]
    public class OrderDetail
    {
        [Identity]
        public int SerryNumber { get; set; }
        public int OrderID { get; set; }
        public int ProID { get; set; }

        [Association(ThisKey="OrderID", OtherKey="ID", CanBeNull=false)]
        public Order OrderInfo { get; set; }

        [Association(ThisKey = "ProID", OtherKey = "ID", CanBeNull = false)]
        public Product ProductInfo { get; set; }
    }
}
