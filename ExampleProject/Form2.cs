using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleProject
{
    public partial class StiTable : Form
    {
        public StiTable()
        {
            InitializeComponent();
        }
        //Connection String
        SqlConnection connection = new SqlConnection(@"Server=.;Database=Test;Trusted_Connection=True;");

        private void StiTable_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        // Get List Function
        private void getListButton_Click(object sender, EventArgs e)
        {
            try
            {
                var malKodu = malKodutxt.Text;
                var baslangicTarihi = baslangicTarihInput.Text;
                var bitisTarihi =bitisTarihInput.Text;
                // Check inputs are null
                if (malKodu == "" || baslangicTarihi == "" || bitisTarihi == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                }
                else
                {
                    // Convert to date variables for stored procedured and convert true format
                    var strBaslangicT = Convert.ToDateTime(baslangicTarihi).ToString("yyyy-MM-dd");
                    var strBitisT = Convert.ToDateTime(bitisTarihi).ToString("yyyy-MM-dd");

                    // Run the query
                    SqlDataAdapter da = new SqlDataAdapter($@"EXECUTE try_proc '{malKodu}', '{strBaslangicT}' ,'{strBitisT}'", connection);
                    DataTable dt = new DataTable();
                    //Push the values in datatable
                    da.Fill(dt);
                    //Fill the gridview from datatable
                    stiGrid.DataSource = dt;
                }
                
            }
            catch (Exception exc)
            {
                throw exc;
            }
            
            

        }
        //Excel export function
        private void excelButton_Click(object sender, EventArgs e)
        {
            //Check the gridview
            if (stiGrid.DataSource == null)
            {
                MessageBox.Show("Tablonun içinde bir veri bulunamadı");
            }
            else
            {
                //Export excel
                string path = "Sti_Output.xlsx";
                stiGrid.ExportToXlsx(path);
                Process.Start(path);
            }
            
        }
        //Print function
        private void printButton_Click(object sender, EventArgs e)
        {
            //Check the gridview
            if (stiGrid.DataSource == null)
            {
                MessageBox.Show("Tablonun içinde bir veri bulunamadı");
            }
            else
            {
                //Print operation
                stiGrid.Print();
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
