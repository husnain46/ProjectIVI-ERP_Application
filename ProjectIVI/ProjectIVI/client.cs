using System;
using ProjectIVI.UserControls;
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
    public partial class client : Form
    {
        public client()
        {
            InitializeComponent();
            timer3.Start();
            UC_newClient nc = new UC_newClient();
            AddControlsToPanel(nc);
        }

        
        private void client_Load(object sender, EventArgs e)
        {

        }
        
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mf = new MenuForm();
            mf.ShowDialog();
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("dd-MM-yyyy");
        }

       
        private void panelSide_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            moveSidePanel(button1);
            UC_newClient nc = new UC_newClient();
            AddControlsToPanel(nc);
        }

        private void menubutton2_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton2);
            UC_updateClient uc = new UC_updateClient();
            AddControlsToPanel(uc);
        }


        private void menubutton4_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton4);
            UC_clientDetail cd = new UC_clientDetail();
            AddControlsToPanel(cd);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
