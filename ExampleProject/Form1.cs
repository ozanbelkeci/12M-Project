using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExampleProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-363NI45\intellity;Initial Catalog=Test;Integrated Security=True;");

        StiTable stiTable;
        //Go to page
        private void StiButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (stiTable == null)
            {
                stiTable = new StiTable();
                stiTable.MdiParent = this;
                stiTable.Show();
            }
        }
    }
}
