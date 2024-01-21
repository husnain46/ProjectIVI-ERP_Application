using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectIVI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("dd-MM-yyyy");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf =new LoginForm();
            lf.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm ordf = new OrderForm();
            ordf.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions tf = new Transactions();
            tf.ShowDialog();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeForm ef = new EmployeeForm();
            ef.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            client clt = new client();
            clt.ShowDialog();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FabricForm ff = new FabricForm();
            ff.ShowDialog();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
