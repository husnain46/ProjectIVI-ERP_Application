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
using System.Data.SqlClient;

namespace ProjectIVI
{
    public partial class FabricForm : Form
    {
        public FabricForm()
        {
            InitializeComponent();
            timer1.Start();
            UC_newFabric nf = new UC_newFabric();
            AddControlsToPanel(nf);
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label3.Text = dt.ToString("dd-MM-yyyy");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm mf = new MenuForm();
            mf.ShowDialog();
        }

        private void menubutton1_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton1);
            UC_newFabric nf = new UC_newFabric();
            AddControlsToPanel(nf);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menubutton2_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton2);
            UC_updateFabric uf = new UC_updateFabric();
            AddControlsToPanel(uf);
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void menubutton3_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton3);
            UC_fabricDetail fd = new UC_fabricDetail();
            AddControlsToPanel(fd);
        }

        private void menubutton4_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton4);
            UC_rateHistory rh = new UC_rateHistory();
            AddControlsToPanel(rh);
        }
    }
}
