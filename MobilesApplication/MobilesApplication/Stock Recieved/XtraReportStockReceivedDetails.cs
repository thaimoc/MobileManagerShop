using System;
using DevExpress.XtraReports.UI;
using Entities;
using System.Collections.Generic;

namespace MobilesApplication.Stock_Recieved
{
    public partial class XtraReportStockReceivedDetails : XtraReport
    {
        public XtraReportStockReceivedDetails(StockReceived stock, List<Product> stockDetails)
        {
            InitializeComponent();
            //monthCalendarAdv1.da
            // Select the week using SelectionStart and SelectionEnd. 
            //this.monthCalendarAdv1.SelectionStart =
            //    new System.DateTime(stock.DateEstablish.Year, stock.DateEstablish.Month, stock.DateEstablish.Day - 1);
            //this.monthCalendarAdv1.SelectionEnd =
            //    new System.DateTime(stock.DateEstablish.Year, stock.DateEstablish.Month, stock.DateEstablish.Day + 6);

            XStockReceived temp = new XStockReceived() { ID = stock.ID.ToString(), AdminName = stock.AdminName, UserAdmin = stock.AdminID, 
                Deleted = stock.Deleted ? "Yes":"No", EstablishedDate = stock.DateEstablish};
            bindingSourceStockReceived.DataSource = temp;
            List<XProduct> result = new List<XProduct>();
            foreach (var i in stockDetails)
            {
                result.Add(new XProduct() { 
                    Name = i.Name, Type = i.Type?"Phone":"Other", Quantity = i.Quantity.ToString(), UnitPrice = i.UnitPrice, Description = i.Description,
                    Price = i.Price.ToString(),
                    Image = System.Drawing.Image.FromFile(@"images/" + i.Image)
                });
            }
            bindingSourceProducts.DataSource = result;
            
        }

    }
}
