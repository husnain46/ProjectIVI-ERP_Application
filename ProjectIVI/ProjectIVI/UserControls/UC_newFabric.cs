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
    public partial class UC_newFabric : UserControl
    {
        public UC_newFabric()
        {
            InitializeComponent();
            fabricGrid.Hide();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void Displayfabrics()
        {
            con.Open();
            string query = "new_fabric";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            fabricGrid.DataSource = ds.Tables[0];
            con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UC_newFabric_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void fabricGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void reset()
        {
            fnamebox.Text = "";
            ftypebox.Text = "";
            ratebox.Text = "";
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            string query = "select * from fabrics where F_name = '" + fnamebox.Text.ToString() + "' and F_rate= '" + ratebox.Text.ToString() + "' and F_type= '" + ftypebox.Text.ToString() + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable d1 = new DataTable();
            adapter.Fill(d1);

            if (fnamebox.Text == "" || ftypebox.Text == "" || ratebox.Text == "")
            {
                MessageBox.Show("Missing Credentials");
            }
            else if (d1.Rows.Count == 1)
            {
                MessageBox.Show("Fabric already exist");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Insertfabric @fname,@frate,@ftype", con);
                    cmd.Parameters.AddWithValue("@fname", fnamebox.Text);
                    cmd.Parameters.AddWithValue("@ftype", ftypebox.Text);
                    cmd.Parameters.AddWithValue("@frate", ratebox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fabric Added");
                    con.Close();
                    fabricGrid.Show();
                    Displayfabrics();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void UC_newFabric_Load_1(object sender, EventArgs e)
        {

        }

        private void ratebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fnamebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ftypebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ftypebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void fnamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
