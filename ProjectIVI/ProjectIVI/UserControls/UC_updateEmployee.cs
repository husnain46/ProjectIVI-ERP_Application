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
    public partial class UC_updateEmployee : UserControl
    {
        public UC_updateEmployee()
        {
            InitializeComponent();
            empGrid.Hide();
            fillemployeId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void econtactbox_TextChanged(object sender, EventArgs e)
        {

        }

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
        public void Displayemployename()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where E_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                enamebox.Text = dr["E_name"].ToString();
            }
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
        public void Displayemployecontact()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where E_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                econtactbox.Text = dr["E_contact"].ToString();
            }
            con.Close();
        }
        public void Displayemployeadd()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where E_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                addressbox.Text = dr["E_address"].ToString();
            }
            con.Close();
        }
        public void Displayemployecnic()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where E_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                desbox.Text = dr["Designation"].ToString();
            }
            con.Close();
        }
        public void Displayemployesalary()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where E_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", eidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                salarybox.Text = dr["Salary"].ToString();
            }
            con.Close();
        }

        private void eidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            empGrid.Show();
            Displayemployeadd();
            Displayemployecnic();
            Displayemployecontact();
            Displayemployename();
            Displayemployesalary();
            Displayemployee();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (enamebox.Text == "" || econtactbox.Text == "" || addressbox.Text == "" || desbox.Text == ""  || salarybox.Text == "")
            {
                MessageBox.Show("Missing Credentials");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employees set E_name=@name, E_contact= @contact, E_address= @address,Designation= @desg, Salary= @salary where E_Id= @SID", con);
                    cmd.Parameters.AddWithValue("@name", enamebox.Text);
                    cmd.Parameters.AddWithValue("@contact", econtactbox.Text);
                    cmd.Parameters.AddWithValue("@address", addressbox.Text);
                    cmd.Parameters.AddWithValue("@desg", desbox.Text);
                    cmd.Parameters.AddWithValue("@salary", salarybox.Text);

                    cmd.Parameters.AddWithValue("@SID", eidcombo.SelectedValue.ToString());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Client Updated");
                    con.Close();
                    Displayemployee();
                    //reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void UC_updateEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
