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
    public partial class UC_orderDetail : UserControl
    {
        public UC_orderDetail()
        {
            InitializeComponent();
            orderGrid.Hide();
            fillorderId();
           
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");
        private void displayorder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_order where [Order ID]=@CID", con);
            cmd.Parameters.AddWithValue("@CID", oidcombo.SelectedValue.ToString());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            orderGrid.DataSource = ds.Tables[0];

            con.Close();
        }
        private void fillorderId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select O_Id from Order_details", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("O_Id", typeof(string));
            dt.Load(rdr);
            oidcombo.ValueMember = "O_Id";
            oidcombo.DataSource = dt;

            con.Close();
        }


        private void viewBtn_Click(object sender, EventArgs e)
        {
            orderGrid.Show();
            displayorder();
        }

        private void UC_orderDetail_Load(object sender, EventArgs e)
        {

        }

        private void oidcombo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {

        }
    }
}
