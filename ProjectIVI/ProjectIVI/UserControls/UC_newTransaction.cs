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
    public partial class UC_newTransaction : UserControl
    {
        public UC_newTransaction()
        {
            InitializeComponent();
            transGrid.Hide();
            fillClientId();
            fillEmployeeId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");


        private void displayOrderDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_order where [Order ID] = @OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            transGrid.DataSource = ds.Tables[0];

            con.Close();
        }


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


        public void Displayclientorder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders where C_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", cidcombo.SelectedValue.ToString());
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("O_Id", typeof(string));
            dt.Load(rdr);
            oidcombo.ValueMember = "O_Id";
            oidcombo.DataSource = dt;
            con.Close();
        }

        private void Displaytransaction()
        {
            con.Open();
            string query = "exec new_transaction";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            transGrid.DataSource = ds.Tables[0];
            con.Close();

        }

        private void fillEmployeeId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("exec emp_designation", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("E_id", typeof(string));
            dt.Load(rdr);
            eidcombo.ValueMember = "E_id";
            eidcombo.DataSource = dt;

            con.Close();
        }
       

        private void fillEmployeeName()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employees where E_id=@EID", con);
            cmd.Parameters.AddWithValue("@EID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            
            foreach (DataRow dr in dt.Rows)
            {
                empname.Text = dr["E_name"].ToString();
            }
            con.Close();
            
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from transactions where C_id = '" + cidcombo.Text.ToString() + "' and E_ID= '" + eidcombo.Text.ToString() + "' and O_id= '" + oidcombo.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable d1 = new DataTable();
            adapter.Fill(d1);


            if (eidcombo.Text == "" || cidcombo.Text == "" || eidcombo.Text == "" || paymentbox.Text == "")
            {
                MessageBox.Show("Missing Credentials");
            }
            else if (d1.Rows.Count == 1)
            {
                MessageBox.Show("Transaction already exist");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Insertpayment @C_Id, @O_Id, @E_Id, @Payment", con);
                    cmd.Parameters.AddWithValue("@C_Id", cidcombo.Text);
                    cmd.Parameters.AddWithValue("@O_ID", oidcombo.Text);
                    cmd.Parameters.AddWithValue("@E_ID", eidcombo.Text);
                    cmd.Parameters.AddWithValue("@Payment", paymentbox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Transaction Done!");
                    con.Close();
                    Displaytransaction();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

     

        private void UC_newTransaction_Load(object sender, EventArgs e)
        {

        }

        private void cidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cidcombo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Displayclientorder();
        }

        private void oidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {;
            transGrid.Show();
            displayOrderDetails();
        }

        private void eidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillEmployeeName();
        }

        private void oidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paymentbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
