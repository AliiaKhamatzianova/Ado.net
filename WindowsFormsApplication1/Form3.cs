using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                //DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = Properties.Settings.Default.myDBConnectionString;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Tovary";

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);
                /*while (rdr.Read())
                {
                    int k = rdr.GetInt32(0);//.ge["Name"].;
                }*/

                //BindingSource bs = new BindingSource();
                //bs.DataSource = dt;

                con.Close();
                dataGridView1.DataSource = dt;//bs;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
