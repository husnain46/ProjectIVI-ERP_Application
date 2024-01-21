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
    public partial class UC_empDetails : UserControl
    {
        public UC_empDetails()
        {
            InitializeComponent();
            empGrid.Hide();
            fillemployeId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");
        private void fillemployeId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select E_id from Employees", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("E_Id", typeof(string));
            dt.Load(rdr);
            eidcombo.ValueMember = "E_Id";
            eidcombo.DataSource = dt;

            con.Close();
        }
        private void Displayemployee()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_employee where [Emp ID]=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            con.Close();

        }

        private void eidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            empGrid.Show();
            Displayemployee();
        }

        private void UC_empDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
