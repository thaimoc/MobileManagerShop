using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using Entities.IRepository;
using Entities;

namespace MobilesApplication.Stock_Recieved
{
    public partial class XtraReportProducts : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportProducts(IGeneralRepository<Product> _repository)
        {
            InitializeComponent();
            DataSource = _repository.GetAll().Select(p => new XProduct() { 
                Name = p.Name, Type = p.Type?"Phone":"Other", UnitPrice = p.UnitPrice, Description = p.Description,
                Image = System.Drawing.Image.FromFile(@"images/" + p.Image), Price = p.Price.ToString()
                //Quantity = p.Quantity.ToString(), 
            }).ToList();
            DataAdapter = DataSource;
        }

    }
}