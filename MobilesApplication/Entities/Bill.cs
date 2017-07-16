using System;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System.Linq;

namespace Entities
{
    [TableName("Bills")]
    public class Bill : Card
    {

        public string CusID { get; set; }
        public string SelID { get; set; }
        public DateTime RequireDate { get; set; }

        [MapIgnore]
        public string CusName { get; set; }

        [MapIgnore]
        public string SalerName { get; set; }

        [Association(ThisKey = "CusID", OtherKey = "UseName", CanBeNull = false)]
        public Member CusInfo { get; set; }

        [Association(ThisKey = "SelID", OtherKey = "UseName", CanBeNull = false)]
        public Member SelerInfo { get; set; }
    }
}
