using System;
using System.Collections.Generic;
using System.Linq;
using BLToolkit.Mapping;
using BLToolkit.Data;

namespace Entities
{
    public class StockReceived:Card
    {
        [MapIgnore]
        private readonly DbManager _dataContext = new DbManager();

        public string AdminID { get; set; }
        public DateTime DateEstablish { get; set; }

        [MapIgnore]
        public string AdminName {
            get { return AdminInfo == null?"Null": AdminInfo.FullName; }
        }

        [Association(ThisKey = "AdminID", OtherKey = "UseName", CanBeNull = false)]
        public Member AdminInfo { get; set; }
        //{

        //    get {
        //        return _dataContext.GetTable<Member>().Where(mb => String.Compare(mb.UseName, AdminID, false) == 0).FirstOrDefault(); 
        //    }

        //    set
        //    {
        //        if (String.Compare(value.UseName, AdminID, false) == 0)
        //            return;
        //        AdminID = value.UseName;
        //    }
        //}

        [Association(ThisKey = "ID", OtherKey = "StockRecievedID", CanBeNull = true)]
        public List<StockReceivedDetail> DetailsInfo { get; set; }
    }
}
