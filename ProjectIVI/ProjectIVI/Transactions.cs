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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            timer1.Start();
            UC_newTransaction nt = new UC_newTransaction();
            AddControlsToPanel(nt);
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
            UC_newTransaction nt = new UC_newTransaction();
            AddControlsToPanel(nt);
        }

        private void menubutton2_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton2);
            UC_revenue rev = new UC_revenue();
            AddControlsToPanel(rev);
        }

        private void menubutton3_Click(object sender, EventArgs e)
        {
            moveSidePanel(menubutton3);
            UC_transacDetail td = new UC_transacDetail();
            AddControlsToPanel(td);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
