using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System.Linq.Expressions;

namespace Entities
{
    [TableName("Products")]
    public class Product
    {
        [MapIgnore]
        private readonly DbManager _dataContext = new DbManager();

        [PrimaryKey, Identity]
        public int ID { get; set; }
        public string Name { get; set; }

        [MapIgnore]
        public int Quantity {
            get {
                int quan = 0;
                List<StockReceivedDetail> tep = _dataContext.GetTable<StockReceivedDetail>().Where(dt=>dt.ProductID == ID).ToList();
                foreach (var i in tep)
                    quan += i.Count;
                return quan;
            }
        }
        public bool Type { get; set; }
        public decimal Price { get; set; }
        public string UnitPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        [Association(ThisKey="ID", OtherKey="ProID", CanBeNull=true)]
        public List<OrderDetail> listOrderDetails { get; set; }
    }
}
