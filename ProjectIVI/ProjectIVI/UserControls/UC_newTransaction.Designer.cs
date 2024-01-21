namespace ProjectIVI.UserControls
{
    partial class UC_newTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.empname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transGrid = new System.Windows.Forms.DataGridView();
            this.oidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.eidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.transGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(214, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Order ID:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(215, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Client ID:";
            // 
            // paymentbox
            // 
            this.paymentbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentbox.BorderColor = System.Drawing.Color.Gray;
            this.paymentbox.BorderRadius = 5;
            this.paymentbox.BorderThickness = 3;
            this.paymentbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paymentbox.DefaultText = "";
            this.paymentbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.paymentbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.paymentbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paymentbox.DisabledState.Parent = this.paymentbox;
            this.paymentbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.paymentbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentbox.FocusedState.Parent = this.paymentbox;
            this.paymentbox.Font = new System.Drawing.Font("Arial", 11F);
            this.paymentbox.ForeColor = System.Drawing.Color.Black;
            this.paymentbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentbox.HoverState.Parent = this.paymentbox;
            this.paymentbox.Location = new System.Drawing.Point(301, 136);
            this.paymentbox.Margin = new System.Windows.Forms.Padding(4);
            this.paymentbox.Name = "paymentbox";
            this.paymentbox.PasswordChar = '\0';
            this.paymentbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.paymentbox.PlaceholderText = "";
            this.paymentbox.SelectedText = "";
            this.paymentbox.ShadowDecoration.Parent = this.paymentbox;
            this.paymentbox.Size = new System.Drawing.Size(146, 35);
            this.paymentbox.TabIndex = 66;
            this.paymentbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paymentbox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label8.Location = new System.Drawing.Point(211, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Payment:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Animated = true;
            this.addBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addBtn.BorderRadius = 10;
            this.addBtn.BorderThickness = 3;
            this.addBtn.CheckedState.Parent = this.addBtn;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.CustomImages.Parent = this.addBtn;
            this.addBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addBtn.DisabledState.Parent = this.addBtn;
            this.addBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.HoverState.Parent = this.addBtn;
            this.addBtn.Location = new System.Drawing.Point(430, 205);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(205, 42);
            this.addBtn.TabIndex = 64;
            this.addBtn.Text = "Complete Transaction";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(524, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Employee ID:";
            // 
            // empname
            // 
            this.empname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empname.BorderColor = System.Drawing.Color.Gray;
            this.empname.BorderRadius = 5;
            this.empname.BorderThickness = 3;
            this.empname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empname.DefaultText = "";
            this.empname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.empname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.empname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empname.DisabledState.Parent = this.empname;
            this.empname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.empname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empname.FocusedState.Parent = this.empname;
            this.empname.Font = new System.Drawing.Font("Arial", 11F);
            this.empname.ForeColor = System.Drawing.Color.Black;
            this.empname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.empname.HoverState.Parent = this.empname;
            this.empname.Location = new System.Drawing.Point(642, 85);
            this.empname.Margin = new System.Windows.Forms.Padding(4);
            this.empname.Name = "empname";
            this.empname.PasswordChar = '\0';
            this.empname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.empname.PlaceholderText = "";
            this.empname.SelectedText = "";
            this.empname.ShadowDecoration.Parent = this.empname;
            this.empname.Size = new System.Drawing.Size(184, 35);
            this.empname.TabIndex = 72;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(494, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Employee Name:";
            // 
            // transGrid
            // 
            this.transGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.transGrid.BackgroundColor = System.Drawing.Color.White;
            this.transGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.transGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.transGrid.GridColor = System.Drawing.Color.White;
            this.transGrid.Location = new System.Drawing.Point(20, 319);
            this.transGrid.Name = "transGrid";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.transGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.transGrid.Size = new System.Drawing.Size(1050, 91);
            this.transGrid.TabIndex = 79;
            // 
            // oidcombo
            // 
            this.oidcombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oidcombo.BackColor = System.Drawing.Color.Transparent;
            this.oidcombo.BorderColor = System.Drawing.Color.Gray;
            this.oidcombo.BorderRadius = 5;
            this.oidcombo.BorderThickness = 3;
            this.oidcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oidcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.oidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.oidcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oidcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oidcombo.FocusedState.Parent = this.oidcombo;
            this.oidcombo.Font = new System.Drawing.Font("Arial", 11F);
            this.oidcombo.ForeColor = System.Drawing.Color.Black;
            this.oidcombo.HoverState.Parent = this.oidcombo;
            this.oidcombo.ItemHeight = 30;
            this.oidcombo.ItemsAppearance.Parent = this.oidcombo;
            this.oidcombo.Location = new System.Drawing.Point(301, 85);
            this.oidcombo.Name = "oidcombo";
            this.oidcombo.ShadowDecoration.Parent = this.oidcombo;
            this.oidcombo.Size = new System.Drawing.Size(137, 36);
            this.oidcombo.TabIndex = 80;
            this.oidcombo.Tag = "select";
            this.oidcombo.SelectedIndexChanged += new System.EventHandler(this.oidcombo_SelectedIndexChanged);
            this.oidcombo.SelectionChangeCommitted += new System.EventHandler(this.oidcombo_SelectionChangeCommitted);
            // 
            // cidcombo
            // 
            this.cidcombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cidcombo.BackColor = System.Drawing.Color.Transparent;
            this.cidcombo.BorderColor = System.Drawing.Color.Gray;
            this.cidcombo.BorderRadius = 5;
            this.cidcombo.BorderThickness = 3;
            this.cidcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cidcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cidcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cidcombo.FocusedState.Parent = this.cidcombo;
            this.cidcombo.Font = new System.Drawing.Font("Arial", 11F);
            this.cidcombo.ForeColor = System.Drawing.Color.Black;
            this.cidcombo.HoverState.Parent = this.cidcombo;
            this.cidcombo.ItemHeight = 30;
            this.cidcombo.ItemsAppearance.Parent = this.cidcombo;
            this.cidcombo.Location = new System.Drawing.Point(301, 34);
            this.cidcombo.Name = "cidcombo";
            this.cidcombo.ShadowDecoration.Parent = this.cidcombo;
            this.cidcombo.Size = new System.Drawing.Size(137, 36);
            this.cidcombo.TabIndex = 81;
            this.cidcombo.Tag = "select";
            this.cidcombo.SelectedIndexChanged += new System.EventHandler(this.cidcombo_SelectedIndexChanged);
            this.cidcombo.SelectionChangeCommitted += new System.EventHandler(this.cidcombo_SelectionChangeCommitted_1);
            // 
            // eidcombo
            // 
            this.eidcombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eidcombo.BackColor = System.Drawing.Color.Transparent;
            this.eidcombo.BorderColor = System.Drawing.Color.Gray;
            this.eidcombo.BorderRadius = 5;
            this.eidcombo.BorderThickness = 3;
            this.eidcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eidcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.eidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eidcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eidcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.eidcombo.FocusedState.Parent = this.eidcombo;
            this.eidcombo.Font = new System.Drawing.Font("Arial", 11F);
            this.eidcombo.ForeColor = System.Drawing.Color.Black;
            this.eidcombo.HoverState.Parent = this.eidcombo;
            this.eidcombo.ItemHeight = 30;
            this.eidcombo.ItemsAppearance.Parent = this.eidcombo;
            this.eidcombo.Location = new System.Drawing.Point(642, 34);
            this.eidcombo.Name = "eidcombo";
            this.eidcombo.ShadowDecoration.Parent = this.eidcombo;
            this.eidcombo.Size = new System.Drawing.Size(137, 36);
            this.eidcombo.TabIndex = 82;
            this.eidcombo.Tag = "select";
            this.eidcombo.SelectedIndexChanged += new System.EventHandler(this.eidcombo_SelectedIndexChanged);
            this.eidcombo.SelectionChangeCommitted += new System.EventHandler(this.eidcombo_SelectionChangeCommitted);
            // 
            // UC_newTransaction
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.eidcombo);
            this.Controls.Add(this.cidcombo);
            this.Controls.Add(this.oidcombo);
            this.Controls.Add(this.transGrid);
            this.Controls.Add(this.empname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paymentbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "UC_newTransaction";
            this.Size = new System.Drawing.Size(1089, 517);
            this.Load += new System.EventHandler(this.UC_newTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox paymentbox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox empname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView transGrid;
        private Guna.UI2.WinForms.Guna2ComboBox oidcombo;
        private Guna.UI2.WinForms.Guna2ComboBox cidcombo;
        private Guna.UI2.WinForms.Guna2ComboBox eidcombo;
    }
}
