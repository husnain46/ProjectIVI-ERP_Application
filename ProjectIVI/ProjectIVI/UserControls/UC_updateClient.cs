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
    public partial class UC_updateClient : UserControl
    {
        public UC_updateClient()
        {
            InitializeComponent();
            fillClientId();
            clientGrid.Hide();

        }

        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void UC_updateClient_Load(object sender, EventArgs e)
        {

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

        public void Displayclientname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where C_Id=@CID", con);
            cmd.Parameters.AddWithValue("@CID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cnamebox.Text = dr["C_name"].ToString();
            }
            con.Close();
        }
        public void Displaycompanyname()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where C_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                namebox.Text = dr["C_company"].ToString();
            }
            con.Close();
        }

        public void Displayclientcity()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where C_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                citybox.Text = dr["C_city"].ToString();
            }
            con.Close();
        }
        public void Displayclientcontact()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where C_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                contactbox.Text = dr["C_contact"].ToString();
            }
            con.Close();
        }
        private void reset()
        {
            cnamebox.Text = "";
            namebox.Text = "";
            citybox.Text = "";
            contactbox.Text = "";
            mailbox.Text = "";
            cidcombo.SelectedIndex = -1;
        }
        public void Displayclientmail()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Client where C_Id=@SID", con);
            cmd.Parameters.AddWithValue("@SID", cidcombo.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                mailbox.Text = dr["C_mail"].ToString();
            }
            con.Close();
        }


        private void cidcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Displayclient()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_clients where [Client ID]=@CID", con);
            cmd.Parameters.AddWithValue("@CID", cidcombo.SelectedValue.ToString());
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            clientGrid.DataSource = ds.Tables[0];

            con.Close();

        }
       
        private void updatebtn_Click(object sender, EventArgs e)
        {
            
            if (cidcombo.SelectedIndex == -1 || contactbox.Text == "" || mailbox.Text == "" )
            {
                MessageBox.Show("Missing Input!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Client set C_name=@name, C_company = @Company, C_city = @city,C_mail= @mail, C_contact = @contact where C_Id= @SID", con);
                    cmd.Parameters.AddWithValue("@name", cnamebox.Text);
                    cmd.Parameters.AddWithValue("@Company", namebox.Text);
                    cmd.Parameters.AddWithValue("@city", citybox.Text);
                    cmd.Parameters.AddWithValue("@mail", mailbox.Text);
                    cmd.Parameters.AddWithValue("@contact", contactbox.Text);
                    
                    cmd.Parameters.AddWithValue("@SID", cidcombo.SelectedValue.ToString());
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    MessageBox.Show("Client Updated!");
                    con.Close();
                    Displayclient();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void cidcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Displayclientcontact();
            Displayclientmail();
            Displayclientcity();
            Displayclientname();    
            Displaycompanyname();
            Displayclient();
            clientGrid.Show();
        }

        private void contactbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}





