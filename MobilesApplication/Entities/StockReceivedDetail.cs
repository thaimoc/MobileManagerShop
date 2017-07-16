using System;
using System.Linq;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;

namespace Entities
{
    [TableName("StockReceivedDetails")]
    public class StockReceivedDetail
    {
        [MapIgnore]
        private readonly DbManager _dataContext = new DbManager();

        [PrimaryKey(1)]
        public int StockRecievedID { get; set; }
        [PrimaryKey(2)]
        public int ProductID { get; set; }

        public decimal UnitPrice { get; set; }
        public int Count { get; set; }

        [MapIgnore]
        public string ProductName { get { return ProductInfo == null?
            "Null": 
            ProductInfo.Name; 
            } 
        }

        [MapIgnore]
        public string ProductImage
        {
            get
            {
                return ProductInfo.Image;
            }
        }

        [MapIgnore]
        public decimal ProductUnitPrice
        {
            get
            {
                return ProductInfo.Price;
            }
        }

        [Association(ThisKey = "StockRecievedID", OtherKey="ID", CanBeNull=false)]
        public StockReceived StockReceivedInfo {
            get { return _dataContext.GetTable<StockReceived>().Where(sto => sto.ID == StockRecievedID).FirstOrDefault(); }

            set {
                if (value.ID == StockRecievedID)
                    return;
                StockRecievedID = value.ID;
            }
        }

        [Association(ThisKey = "ProductID", OtherKey = "ID", CanBeNull = false)]
        public Product ProductInfo { 
            get {
                return _dataContext.GetTable<Product>().Where(pro => pro.ID == ProductID).FirstOrDefault();
            } 
            set{
                if (value.ID == ProductID) return;
                ProductID = value.ID;
            } 
        }

       
    }
}
