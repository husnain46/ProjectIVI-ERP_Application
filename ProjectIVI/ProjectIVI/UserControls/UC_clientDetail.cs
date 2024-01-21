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
    public partial class UC_clientDetail : UserControl
    {
        public UC_clientDetail()
        {
            InitializeComponent();
            clientGrid.Hide();
            fillClientId();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void fillClientId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select C_Id from Client", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("C_Id", typeof(string));
            dt.Load(rdr);
            cidcombo.ValueMember = "C_Id";
            cidcombo.DataSource = dt;

            con.Close();
        }
        private void Displayindivclient()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_clients where [Client ID]=@CID", con);
            cmd.Parameters.AddWithValue("@CID", cidcombo.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            clientGrid.DataSource = ds.Tables[0];

            con.Close();
        }

        private void cidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void UC_clientDetail_Load(object sender, EventArgs e)
        {

        }

        private void cidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            clientGrid.Show();
            Displayindivclient();
        }

        private void cidcombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cidcombo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }
    }
}
