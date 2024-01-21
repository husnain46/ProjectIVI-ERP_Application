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
    public partial class UC_newOrder : UserControl
    {
        public UC_newOrder()
        {
            InitializeComponent();
            datepicker.MinDate = DateTime.Now;
            datepicker.CustomFormat = "yyyy-MM-dd";
            datepicker.Format = DateTimePickerFormat.Custom;
            fillClientId();
            fillfabricId();
            orderGrid.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void UC_newOrder_Load(object sender, EventArgs e)
        {

        }


        private void reset()
        {
            metersbox.Text = "";
            colorbox.Text = "";
            fidcombo.SelectedIndex = -1;
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
        private void fillfabricId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select F_id from Fabrics", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("F_id", typeof(string));
            dt.Load(rdr);
            fidcombo.ValueMember = "F_id";
            fidcombo.DataSource = dt;

            con.Close();
        }

        private void fillorderid()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Orders where C_id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oidBox.Text = dr["O_id"].ToString();
            }
            con.Close();
        }

        
        private void Displayorderdetail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select *from view_order where [Order ID] = @CID", con);
            cmd.Parameters.AddWithValue("@CID", oidBox.Text.ToString());
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            orderGrid.DataSource = ds.Tables[0];

            con.Close();
        }

       

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ( metersbox.Text == "" || colorbox.Text == "" || fidcombo.SelectedIndex == -1 || oidBox.Text== "")
            {
                MessageBox.Show("Missing Credentials");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Order_details (O_id,F_id,Meters,Color) values (@id,@fid,@meter,@color) ", con);
                    cmd.Parameters.AddWithValue("@id", oidBox.Text);
                    cmd.Parameters.AddWithValue("@meter", metersbox.Text);
                    cmd.Parameters.AddWithValue("@color", colorbox.Text);

                    cmd.Parameters.AddWithValue("@fid", fidcombo.SelectedValue.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var ds = new DataSet();
                    adapter.Fill(ds);


                    MessageBox.Show("New order created!");

                    con.Close();
                    orderGrid.Show();
                    Displayorderdetail();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (datepicker.Text == "" || cidcombo.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Credentials");
            }

            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec Insertorder @cid,@due_date", con);
                    
                    cmd.Parameters.AddWithValue("@due_date", datepicker.Text);
                    cmd.Parameters.AddWithValue("@cid", cidcombo.SelectedValue.ToString());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    var ds = new DataSet();
                    adapter.Fill(ds);

                    con.Close();
                    fillorderid();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void cidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void datepicker_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void orderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metersbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void colorbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
