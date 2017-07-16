using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

namespace Entities
{
    [TableName("BillDetails")]
    public class BillDetail
    {
        public int BillID { get; set; }
        public int OrderID { get; set; }

        [MapIgnore]
        public string CustomerName { get { return (OrderInfo != null && OrderInfo.CustomerInfo != null) ? OrderInfo.CustomerInfo.FullName : "Null"; } }

        [MapIgnore]
        public string CustomerUse { get { return OrderInfo != null ? OrderInfo.CusID : "Null"; } }

        [Association(ThisKey = "BillID", OtherKey = "ID", CanBeNull = false)]
        public Bill BillInfo { get; set; }

        [Association(ThisKey = "OrderID", OtherKey = "ID", CanBeNull = false)]
        public Order OrderInfo { get; set; }

        [MapIgnore]
        public DateTime DateRequire { get { return OrderInfo != null ? OrderInfo.DateRequire : DateTime.Today; } }
    }
}
