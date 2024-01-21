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
    public partial class UC_revenue : UserControl
    {
        public UC_revenue()
        {
            InitializeComponent();

            monthpicker.CustomFormat = "MM-yyyy";
            monthpicker.Format = DateTimePickerFormat.Custom;

            yearpicker.CustomFormat = "yyyy";
            yearpicker.Format = DateTimePickerFormat.Custom; 

        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void monthlyRevenue()

        {
            con.Open();
            
            int day = monthpicker.Value.Day;
            int month = monthpicker.Value.Month;
            int year = monthpicker.Value.Year;

            SqlCommand cmd = new SqlCommand("select dbo.monthly_revenue(@month,@year)", con);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            monthRev.Text = dt.Rows[0][0].ToString();

            con.Close();
        }

        private void yearlyRevenue()
        {
            con.Open();
            int day = yearpicker.Value.Day;
            int month = yearpicker.Value.Month;
            int year = yearpicker.Value.Year;

            SqlCommand cmd = new SqlCommand("select dbo.yearly_revenue(@year)", con);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);

            yearRev.Text = dt.Rows[0][0].ToString();

            con.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_revenue_Load(object sender, EventArgs e)
        {

        }

        private void monthRev_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            monthlyRevenue();
        }

        private void datepicker2_ValueChanged(object sender, EventArgs e)
        {

        }


        private void viewYearlyBtn_Click(object sender, EventArgs e)
        {
            yearlyRevenue();
        }
    }
}
