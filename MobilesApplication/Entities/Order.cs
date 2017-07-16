using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;

namespace Entities
{
    [TableName("Orders")]
    public class Order:Card
    {

        public string CusID { get; set; }
        public DateTime DateRequire { get; set; }

        [Association(ThisKey="CusID", OtherKey="UseName", CanBeNull=false)]
        public Member CustomerInfo { get; set; }

        [Association(ThisKey = "ID", OtherKey = "OrderID", CanBeNull=true)]
        public List<OrderDetail> DetailsInfo { get; set; }

        
    }
}
