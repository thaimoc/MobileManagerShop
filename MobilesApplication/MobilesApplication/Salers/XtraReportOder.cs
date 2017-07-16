using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using Entities.IRepository;
using Entities;
using System.Collections.Generic;

namespace MobilesApplication.Salers
{
    public partial class XtraReportOder : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportOder(Member cus, List<OrderDetailProduct> proList)
        {
            InitializeComponent();

            //DataSource = cus;
            //DataAdapter = cus;
            xrLCusName.Text += " " + cus.FullName;
            xrLGender.Text += " " + (cus.Gender ? "Female" : "Male");
            xrLUseName.Text += " " + cus.UseName;
            xrLAddress.Text += " " + cus.Address;
            bindingSourceProducts.DataSource = proList.Select(p => new XProductOrder() {
                Name = p.Name,
                Type = p.Type ? "Phone" : "Other",
                UnitPrice = p.UnitPrice,
                Description = p.Description,
                Image = System.Drawing.Image.FromFile(@"images/" + p.Image),
                Price = p.Price.ToString(), Unit = p.Unit.ToString()
            }).ToList();
        }

    }
}
