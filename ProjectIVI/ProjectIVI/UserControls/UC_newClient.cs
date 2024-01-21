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
    public partial class UC_newClient : UserControl
    {
        public UC_newClient()
        {
            InitializeComponent();
            clientGrid.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void UC_newClient_Load(object sender, EventArgs e)
        {

        }

        private void DisplayClient()
        {
            con.Open();
            string query = "new_client";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            clientGrid.DataSource = ds.Tables[0];
            con.Close();

        }
        private void reset()
        {
            cnamebox.Text = "";
            companybox.Text = "";
            citybox.Text = "";
            contactbox.Text = "";
            mailbox.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from Client where C_name = '" + cnamebox.Text.ToString() + "' and C_company = '" + companybox.Text.ToString() + "' and C_contact= '" + contactbox.Text.ToString() + "' and C_city = '" + citybox.Text.ToString() + "' and C_mail = '" + mailbox.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable d1 = new DataTable();
            adapter.Fill(d1);

            
            if (cnamebox.Text == "" || companybox.Text == "" || contactbox.Text == "" || mailbox.Text == "" || citybox.Text == "")
            {
                MessageBox.Show("Missing Credentials!");
            }
            else if (d1.Rows.Count == 1)
            {
                MessageBox.Show("Client already exist!");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Insertclient @Cname,@Ccompany,@Ccontact,@Ccity,@Cmail", con);
                    cmd.Parameters.AddWithValue("@Cname", cnamebox.Text);
                    cmd.Parameters.AddWithValue("@Ccontact", contactbox.Text);
                    cmd.Parameters.AddWithValue("@Ccity", citybox.Text);
                    cmd.Parameters.AddWithValue("@Ccompany", companybox.Text);
                    cmd.Parameters.AddWithValue("@Cmail", mailbox.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Client Added!");
                    con.Close();
                    DisplayClient();
                    reset();
                    clientGrid.Show();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void clientGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contactbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contactbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            contactbox.MaxLength = 11;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mailbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void citybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void companybox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
