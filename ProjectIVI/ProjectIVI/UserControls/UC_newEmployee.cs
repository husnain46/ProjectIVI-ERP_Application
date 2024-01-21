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
    public partial class UC_newEmployee : UserControl
    {
        public UC_newEmployee()
        {
            InitializeComponent();
            empGrid.Hide();
            Displayemploye();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void UC_newEmployee_Load(object sender, EventArgs e)
        {

        }
        private void Displayemploye()
        {
            con.Open();
            string query = "new_employee";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            empGrid.DataSource = ds.Tables[0];
            con.Close();

        }
        private void reset()
        {
            enamebox.Text = "";
            cnicbox.Text = "";
            econtactbox.Text = "";
            addressbox.Text = "";
            salarybox.Text = "";

            desbox.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from Employees where E_name = '" + enamebox.Text.ToString() + "' and E_CNIC = '" + cnicbox.Text.ToString() + "' and E_contact= '" + econtactbox.Text.ToString() + "' and E_address = '" + addressbox.Text.ToString() + "' and Designation = '" + desbox.Text.ToString() + "' and Salary = '" + salarybox.Text.ToString() +  "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable d1 = new DataTable();
            adapter.Fill(d1);

            if (enamebox.Text == "" || econtactbox.Text == "" || addressbox.Text == "" || desbox.Text == "" || cnicbox.Text == "" || salarybox.Text == "")
            {
                MessageBox.Show("Missing Credentials");
            }
            else if (d1.Rows.Count == 1)
            {
                MessageBox.Show("Employee already exist");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Insertemployee @name,@cnic,@contact, @address, @design, @salary", con);
                    cmd.Parameters.AddWithValue("@name", enamebox.Text);
                    cmd.Parameters.AddWithValue("@cnic", cnicbox.Text);
                    cmd.Parameters.AddWithValue("@contact", econtactbox.Text);
                    cmd.Parameters.AddWithValue("@design", desbox.Text);
                    cmd.Parameters.AddWithValue("@address", addressbox.Text);
                    cmd.Parameters.AddWithValue("@salary", salarybox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    con.Close();
                    empGrid.Show();
                    Displayemploye();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void enamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void econtactbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            econtactbox.MaxLength = 11;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cnicbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            cnicbox.MaxLength = 13;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void salarybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            salarybox.MaxLength = 8;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void desbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

