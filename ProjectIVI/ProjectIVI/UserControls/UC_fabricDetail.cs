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
    public partial class UC_fabricDetail : UserControl
    {
        public UC_fabricDetail()
        {
            InitializeComponent();

            Displayfabrics();
        }
        SqlConnection con = new SqlConnection(@"Data Source=ACER-P449;Initial Catalog=Textile;Integrated Security=True");

        private void Displayfabrics()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from view_fabric", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            fabricGrid.DataSource = ds.Tables[0];
            con.Close();

        }
    }
}
