namespace ProjectIVI.UserControls
{
    partial class UC_revenue
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.monthBtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.monthpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.mpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.monthRev = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.yearpicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ypanel = new Guna.UI2.WinForms.Guna2Panel();
            this.yearRev = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.yearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.mpanel.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.ypanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(66, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 65;
            this.label5.Text = "Month:";
            // 
            // monthBtn
            // 
            this.monthBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthBtn.Animated = true;
            this.monthBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.monthBtn.BorderRadius = 10;
            this.monthBtn.BorderThickness = 3;
            this.monthBtn.CheckedState.Parent = this.monthBtn;
            this.monthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthBtn.CustomImages.Parent = this.monthBtn;
            this.monthBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.monthBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.monthBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.monthBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.monthBtn.DisabledState.Parent = this.monthBtn;
            this.monthBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.monthBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.monthBtn.ForeColor = System.Drawing.Color.White;
            this.monthBtn.HoverState.Parent = this.monthBtn;
            this.monthBtn.Location = new System.Drawing.Point(133, 124);
            this.monthBtn.Name = "monthBtn";
            this.monthBtn.ShadowDecoration.Parent = this.monthBtn;
            this.monthBtn.Size = new System.Drawing.Size(92, 40);
            this.monthBtn.TabIndex = 70;
            this.monthBtn.Text = "Check";
            this.monthBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.Black;
            this.panel2.BorderRadius = 15;
            this.panel2.BorderThickness = 4;
            this.panel2.Controls.Add(this.monthpicker);
            this.panel2.Controls.Add(this.mpanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.monthBtn);
            this.panel2.Location = new System.Drawing.Point(123, 95);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(369, 393);
            this.panel2.TabIndex = 74;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // monthpicker
            // 
            this.monthpicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthpicker.Animated = true;
            this.monthpicker.BorderColor = System.Drawing.Color.DimGray;
            this.monthpicker.BorderRadius = 5;
            this.monthpicker.BorderThickness = 3;
            this.monthpicker.Checked = true;
            this.monthpicker.CheckedState.Parent = this.monthpicker;
            this.monthpicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthpicker.FillColor = System.Drawing.Color.White;
            this.monthpicker.Font = new System.Drawing.Font("Arial", 10F);
            this.monthpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.monthpicker.HoverState.Parent = this.monthpicker;
            this.monthpicker.Location = new System.Drawing.Point(134, 55);
            this.monthpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.monthpicker.MinDate = new System.DateTime(2021, 12, 28, 12, 15, 32, 0);
            this.monthpicker.Name = "monthpicker";
            this.monthpicker.ShadowDecoration.Parent = this.monthpicker;
            this.monthpicker.Size = new System.Drawing.Size(145, 39);
            this.monthpicker.TabIndex = 75;
            this.monthpicker.Value = new System.DateTime(2021, 12, 28, 12, 25, 56, 0);
            this.monthpicker.ValueChanged += new System.EventHandler(this.datepicker2_ValueChanged);
            // 
            // mpanel
            // 
            this.mpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.mpanel.BorderRadius = 15;
            this.mpanel.BorderThickness = 4;
            this.mpanel.Controls.Add(this.monthRev);
            this.mpanel.FillColor = System.Drawing.Color.White;
            this.mpanel.Location = new System.Drawing.Point(106, 288);
            this.mpanel.Name = "mpanel";
            this.mpanel.ShadowDecoration.Parent = this.mpanel;
            this.mpanel.Size = new System.Drawing.Size(173, 50);
            this.mpanel.TabIndex = 71;
            // 
            // monthRev
            // 
            this.monthRev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.monthRev.AutoSize = true;
            this.monthRev.Font = new System.Drawing.Font("Arial", 12F);
            this.monthRev.ForeColor = System.Drawing.Color.Black;
            this.monthRev.Location = new System.Drawing.Point(33, 16);
            this.monthRev.Name = "monthRev";
            this.monthRev.Size = new System.Drawing.Size(107, 18);
            this.monthRev.TabIndex = 0;
            this.monthRev.Text = "___________";
            this.monthRev.Click += new System.EventHandler(this.monthRev_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(34, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 65;
            this.label2.Text = "Total Revenue:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(225, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Monthly Revenue";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(705, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 71;
            this.label4.Text = "Yearly Revenue";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 4;
            this.guna2Panel2.Controls.Add(this.yearpicker);
            this.guna2Panel2.Controls.Add(this.ypanel);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.yearBtn);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Location = new System.Drawing.Point(592, 95);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(359, 393);
            this.guna2Panel2.TabIndex = 74;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // yearpicker
            // 
            this.yearpicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearpicker.Animated = true;
            this.yearpicker.BorderColor = System.Drawing.Color.DimGray;
            this.yearpicker.BorderRadius = 5;
            this.yearpicker.BorderThickness = 3;
            this.yearpicker.Checked = true;
            this.yearpicker.CheckedState.Parent = this.yearpicker;
            this.yearpicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearpicker.FillColor = System.Drawing.Color.White;
            this.yearpicker.Font = new System.Drawing.Font("Arial", 10F);
            this.yearpicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearpicker.HoverState.Parent = this.yearpicker;
            this.yearpicker.Location = new System.Drawing.Point(134, 55);
            this.yearpicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.yearpicker.MinDate = new System.DateTime(2021, 12, 28, 12, 15, 32, 0);
            this.yearpicker.Name = "yearpicker";
            this.yearpicker.ShadowDecoration.Parent = this.yearpicker;
            this.yearpicker.Size = new System.Drawing.Size(145, 39);
            this.yearpicker.TabIndex = 76;
            this.yearpicker.Value = new System.DateTime(2021, 12, 28, 12, 25, 56, 0);
            // 
            // ypanel
            // 
            this.ypanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.ypanel.BorderRadius = 15;
            this.ypanel.BorderThickness = 4;
            this.ypanel.Controls.Add(this.yearRev);
            this.ypanel.FillColor = System.Drawing.Color.White;
            this.ypanel.Location = new System.Drawing.Point(105, 288);
            this.ypanel.Name = "ypanel";
            this.ypanel.ShadowDecoration.Parent = this.ypanel;
            this.ypanel.Size = new System.Drawing.Size(173, 50);
            this.ypanel.TabIndex = 71;
            // 
            // yearRev
            // 
            this.yearRev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yearRev.AutoSize = true;
            this.yearRev.Font = new System.Drawing.Font("Arial", 12F);
            this.yearRev.ForeColor = System.Drawing.Color.Black;
            this.yearRev.Location = new System.Drawing.Point(33, 16);
            this.yearRev.Name = "yearRev";
            this.yearRev.Size = new System.Drawing.Size(107, 18);
            this.yearRev.TabIndex = 0;
            this.yearRev.Text = "___________";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label7.Location = new System.Drawing.Point(33, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Total Revenue:";
            // 
            // yearBtn
            // 
            this.yearBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearBtn.Animated = true;
            this.yearBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.yearBtn.BorderRadius = 10;
            this.yearBtn.BorderThickness = 3;
            this.yearBtn.CheckedState.Parent = this.yearBtn;
            this.yearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearBtn.CustomImages.Parent = this.yearBtn;
            this.yearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.yearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.yearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.yearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.yearBtn.DisabledState.Parent = this.yearBtn;
            this.yearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.yearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.yearBtn.ForeColor = System.Drawing.Color.White;
            this.yearBtn.HoverState.Parent = this.yearBtn;
            this.yearBtn.Location = new System.Drawing.Point(134, 124);
            this.yearBtn.Name = "yearBtn";
            this.yearBtn.ShadowDecoration.Parent = this.yearBtn;
            this.yearBtn.Size = new System.Drawing.Size(95, 40);
            this.yearBtn.TabIndex = 70;
            this.yearBtn.Text = "Check";
            this.yearBtn.Click += new System.EventHandler(this.viewYearlyBtn_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(70, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Year:";
            // 
            // UC_revenue
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "UC_revenue";
            this.Size = new System.Drawing.Size(1050, 549);
            this.Load += new System.EventHandler(this.UC_revenue_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mpanel.ResumeLayout(false);
            this.mpanel.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ypanel.ResumeLayout(false);
            this.ypanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button monthBtn;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel mpanel;
        private System.Windows.Forms.Label monthRev;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel ypanel;
        private System.Windows.Forms.Label yearRev;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button yearBtn;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DateTimePicker monthpicker;
        private Guna.UI2.WinForms.Guna2DateTimePicker yearpicker;
    }
}
