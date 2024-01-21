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

namespace ProjectIVI.UserControls
{
    public partial class UC_rateHistory : UserControl
    {
        public UC_rateHistory()
        {
            InitializeComponent();
            datepicker3.Value = DateTime.Now;
            datepicker3.CustomFormat = "yyyy-MM-dd";
            datepicker3.Format = DateTimePickerFormat.Custom;
            fabricGrid.Hide();
            fillfabricId();

            
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void UC_rateHistory_Load(object sender, EventArgs e)
        {

        }

        private void fillfabricId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select F_id from Fabric_history", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("F_id", typeof(string));
            dt.Load(rdr);
            fidcombo.ValueMember = "F_id";
            fidcombo.DataSource = dt;

            con.Close();
        }

        private void displayRateHistory()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_rates where [Fabric ID]=@FID", con);
            cmd.Parameters.AddWithValue("@FID", fidcombo.SelectedValue.ToString());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            fabricGrid.DataSource = ds.Tables[0];

            con.Close();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (datepicker3.Text == "" || fidcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Inputs!");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec rate_date @fid,@up_date", con);

                    cmd.Parameters.AddWithValue("@up_date", datepicker3.Text);
                    cmd.Parameters.AddWithValue("@fid", fidcombo.SelectedValue.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    con.Close();
                    fabricGrid.Show();
                    displayRateHistory();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
    }
}
