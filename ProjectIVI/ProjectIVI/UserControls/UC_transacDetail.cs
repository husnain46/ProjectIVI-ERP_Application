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
    public partial class UC_transacDetail : UserControl
    {
        public UC_transacDetail()
        {
            InitializeComponent();
            transGrid.Hide();
            filltransId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void filltransId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select O_id from transactions", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("O_Id", typeof(string));
            dt.Load(rdr);
            oidcombo.ValueMember = "O_Id";
            oidcombo.DataSource = dt;

            con.Close();
        }
        public void Displaytransdetail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_transaction where [Order ID]=@OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            transGrid.DataSource = ds.Tables[0];
            con.Close();
        }

        private void oidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            transGrid.Show();
            Displaytransdetail();
        }

        private void UC_transacDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
