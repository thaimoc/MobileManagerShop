using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Entities;
using System.Collections.Generic;

namespace MobilesApplication.Salers
{
    public partial class XtraReportBill : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportBill(Bill bill, List<Order> orders)
        {
            InitializeComponent();

            Member cusPay = bill.CusInfo;
            Member seller = bill.SelerInfo;

            lbRequireDate.Text += bill.RequireDate.ToShortDateString();

            lbCusUse.Text += cusPay.UseName;
            lbCusName.Text += cusPay.FullName;
            lbCusGender.Text += cusPay.Gender ? "Female" : "Male";
            lbCusBirthDate.Text += cusPay.BirthDate.ToShortDateString();
            lbCusAddress.Text += cusPay.Address;

            lbSelUse.Text += seller.UseName;
            lbSelName.Text += seller.FullName;
            lbSelGender.Text += seller.Gender ? "Female" : "Male";
            lbSelBirthDate.Text += seller.BirthDate.ToShortDateString();
            lbSelAddress.Text += seller.Address;

            decimal total = 0;
            List<XOrder> li = new List<XOrder>();
            orders.ForEach(i => {
                XOrder temp =
                        new XOrder
                        {
                            CusUse = i.CusID,
                            CusName = i.CustomerInfo.FullName,
                            DateRequire = i.DateRequire,
                            Products = string.Empty, TotalMoney = 0
                        };
                i.DetailsInfo.ForEach(j=>{
                    temp.Products += string.Format("{0}({1}), ", j.ProductInfo.Name, j.ProductInfo.Price);
                    temp.TotalMoney += j.ProductInfo.Price;
                });
                li.Add(temp);
            });

            li.ForEach(i => { total += i.TotalMoney; });
            lbTotalMustPay.Text += string.Format("${0}", total);
            bindingSource1.DataSource = li;
        }


    }

    public class XOrder
    {
        public string CusUse { get; set; }
        public string CusName { get; set; }
        public DateTime DateRequire { get; set; }

        public string Products { get; set; }
        public Decimal TotalMoney { get; set; }
    }
}
