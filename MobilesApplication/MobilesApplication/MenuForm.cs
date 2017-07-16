using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MobilesApplication
{
    public partial class MenuForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void metroAppButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}