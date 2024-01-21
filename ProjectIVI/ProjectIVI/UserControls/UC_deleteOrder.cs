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
    public partial class UC_deleteOrder : UserControl
    {
        public UC_deleteOrder()
        {
            InitializeComponent();
            orderGrid.Hide();
            fillorderId();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        
        private void fillorderId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select O_Id from Orders", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("O_Id", typeof(string));
            dt.Load(rdr);
            oidcombo.ValueMember = "O_Id";
            oidcombo.DataSource = dt;

            con.Close();
        }
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

        

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (oidcombo.SelectedIndex== -1)
            {
                MessageBox.Show("Error! Missing field or Order not deleted!");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Orders where O_Id= @OID", con);


                    cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Order Deleted!");
                    con.Close();
                    displayorder();
                    fillorderId();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UC_deleteOrder_Load(object sender, EventArgs e)
        {

        }

        private void oidcombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void oidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {

            orderGrid.Show();
            displayorder();
        }
    }
}
