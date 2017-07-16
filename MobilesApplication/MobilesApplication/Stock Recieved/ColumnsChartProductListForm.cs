using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpress.XtraCharts;
using Entities;
using Entities.IRepository;
using DAL.SqlServer;

namespace MobilesApplication.Stock_Recieved
{
    public partial class ColumnsChartProductListForm : Office2007Form
    {
        private IGeneralRepository<Product> _repProduct;
        public ColumnsChartProductListForm(ViewType v)
        {
            InitializeComponent();
            _repProduct = new GeneralRepository<Product>();
            chartControl.Series.Clear();
            CreateNewSerriesName("Quantity Serries", v, chartControl, _repProduct.GetAll().ToList());
        }

        private DataTable CreateChartData(List<Product> list)
        {
            // Create an empty table.
            DataTable table = new DataTable("Table");

            // Add two columns to the table.
            table.Columns.Add("Argument", typeof(String));
            table.Columns.Add("Value", typeof(Int32));

            // Add data rows to the table.
            int rowCount = list.Count;
            Random rnd = new Random();
            DataRow row = null;
            for (int i = 0; i < rowCount; i++)
            {
                row = table.NewRow();
                row["Argument"] = list[i].Name;
                row["Value"] = list[i].Quantity;
                table.Rows.Add(row);
            }
            return table;
        }

        private void CreateNewSerriesName(string serriesName, ViewType v, ChartControl chr, List<Product> list)
        {
            Series series = new Series(serriesName, v);
            chr.Series.Add(series);
            // Generate a data table and bind the series to it.
            series.DataSource = CreateChartData(list);
            // Specify data members to bind the series.
            //series.ArgumentScaleType = ScaleType.Numerical;
            series.ArgumentDataMember = "Argument";
            series.ValueScaleType = ScaleType.Numerical;
            series.ValueDataMembers.AddRange(new string[] { "Value" });
        }
    }
}
