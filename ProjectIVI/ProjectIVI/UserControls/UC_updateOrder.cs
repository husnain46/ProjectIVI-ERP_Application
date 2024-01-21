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
    public partial class UC_updateOrder : UserControl
    {
        public UC_updateOrder()
        {
            InitializeComponent();
            datepicker.MinDate = DateTime.Now;
            datepicker.CustomFormat = "yyyy-MM-dd";
            datepicker.Format = DateTimePickerFormat.Custom;
            orderGrid.Hide();
            fillorderId();
            fillfabricId();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        public void displayfabricID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_details where O_Id=@OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("F_Id", typeof(string));
            dt.Load(rdr);
            fidcombo.ValueMember = "F_Id";
            fidcombo.DataSource = dt;
            con.Close();
        }

        private void displayorder()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_order where [Order ID] = @OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
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
            SqlCommand cmd = new SqlCommand("select O_id from Orders", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("O_id", typeof(string));
            dt.Load(rdr);
            oidcombo.ValueMember = "O_id";
            oidcombo.DataSource = dt;

            con.Close();
        }

        
        public void Displayfabricmeter()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_details where O_id = @OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                metersbox.Text = dr["Meters"].ToString();
            }
            con.Close();
        }
        public void Displayfabriccolour()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Order_details where O_id = @OID", con);
            cmd.Parameters.AddWithValue("@OID", oidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                colorbox.Text = dr["Color"].ToString();
            }
            con.Close();
        }
        
        public void Displayduedate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders where O_id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", oidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                datepicker.Text = dr["Due_date"].ToString();
            }
            con.Close();
        }
        private void UC_updateOrder_Load(object sender, EventArgs e)
        {

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

        private void updatedate_Click(object sender, EventArgs e)
        {

            
           
            {
                
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Orders set Due_date=@date where O_id= @SID", con);

                    cmd.Parameters.AddWithValue("@date", datepicker.Text);
                    cmd.Parameters.AddWithValue("@SID", oidcombo.SelectedValue.ToString());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Due Date Updated");
                    con.Close();
                    displayorder();
                    //reset();
                }
               
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update Order_details set Meters=@meter,Color = @color where O_id= @SID and F_id =@CID", con);
                cmd.Parameters.AddWithValue("@meter", metersbox.Text);
                cmd.Parameters.AddWithValue("@color", colorbox.Text);
                cmd.Parameters.AddWithValue("@SID", oidcombo.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CID", fidcombo.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                MessageBox.Show("order Updated");
                con.Close();
                displayorder();
                //reset();
            }


        }

        private void oidcombo_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            Displayduedate();
            displayfabricID();
            Displayfabriccolour();
            Displayfabricmeter();
            displayorder();
            orderGrid.Show();
        }

        private void fidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
