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
    public partial class UC_updateFabric : UserControl
    {
        public UC_updateFabric()
        {
            InitializeComponent();
            fabricGrid.Hide();
            fillfabricId();
            Displayfabric();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void reset()
        {
            fidcombo.SelectedIndex = -1;
            fnamebox.Text = "";
            ratebox.Text = "";
            ftypebox.Text = "";
        }

        private void Displayfabric()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_fabric where [Fabric ID]=@FID", con);
            cmd.Parameters.AddWithValue("@FID", fidcombo.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            fabricGrid.DataSource = ds.Tables[0];
            con.Close();


        }
        public void Displayfname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Fabrics where F_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", fidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                fnamebox.Text = dr["F_name"].ToString();
            }
            con.Close();
        }
        public void Displayftype()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Fabrics where F_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", fidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ftypebox.Text = dr["F_type"].ToString();
            }
            con.Close();
        }
        public void Displayfrate()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Fabrics where F_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", fidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                ratebox.Text = dr["F_rate"].ToString();
            }
            con.Close();
        }
        private void fillfabricId()

        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select F_Id from Fabrics", con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("F_Id", typeof(string));
            dt.Load(rdr);
            fidcombo.ValueMember = "F_Id";
            fidcombo.DataSource = dt;

            con.Close();
        }
        private void UC_updateFabric_Load(object sender, EventArgs e)
        {

        }

        private void fidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fabricGrid.Show();
            Displayfabric();
            Displayfname();
            Displayfrate();
            Displayftype();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (fnamebox.Text == "" || ftypebox.Text == "" || ratebox.Text == "")
            {
                MessageBox.Show("Missing Input!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Fabrics set F_name= @fname, F_type= @ftype, F_rate= @frate where F_Id= @SID", con);
                    cmd.Parameters.AddWithValue("@fname", fnamebox.Text);
                    cmd.Parameters.AddWithValue("@ftype", ftypebox.Text);
                    cmd.Parameters.AddWithValue("@frate", ratebox.Text);



                    cmd.Parameters.AddWithValue("@SID", fidcombo.SelectedValue.ToString());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Fabric Details Updated!");
                    con.Close();
                    Displayfabric();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void fabricGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
