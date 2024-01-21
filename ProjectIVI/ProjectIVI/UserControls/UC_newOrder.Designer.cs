namespace ProjectIVI.UserControls
{
    partial class UC_newOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colorbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.metersbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.selectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oidBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.fidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // colorbox
            // 
            this.colorbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.colorbox.BorderColor = System.Drawing.Color.Gray;
            this.colorbox.BorderRadius = 5;
            this.colorbox.BorderThickness = 3;
            this.colorbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.colorbox.DefaultText = "";
            this.colorbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.colorbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.colorbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colorbox.DisabledState.Parent = this.colorbox;
            this.colorbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.colorbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorbox.FocusedState.Parent = this.colorbox;
            this.colorbox.Font = new System.Drawing.Font("Arial", 11F);
            this.colorbox.ForeColor = System.Drawing.Color.Black;
            this.colorbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorbox.HoverState.Parent = this.colorbox;
            this.colorbox.Location = new System.Drawing.Point(559, 197);
            this.colorbox.Margin = new System.Windows.Forms.Padding(4);
            this.colorbox.Name = "colorbox";
            this.colorbox.PasswordChar = '\0';
            this.colorbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.colorbox.PlaceholderText = "";
            this.colorbox.SelectedText = "";
            this.colorbox.ShadowDecoration.Parent = this.colorbox;
            this.colorbox.Size = new System.Drawing.Size(186, 33);
            this.colorbox.TabIndex = 44;
            this.colorbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colorbox_KeyPress);
            // 
            // metersbox
            // 
            this.metersbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metersbox.BorderColor = System.Drawing.Color.Gray;
            this.metersbox.BorderRadius = 5;
            this.metersbox.BorderThickness = 3;
            this.metersbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.metersbox.DefaultText = "";
            this.metersbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.metersbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.metersbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.metersbox.DisabledState.Parent = this.metersbox;
            this.metersbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.metersbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.metersbox.FocusedState.Parent = this.metersbox;
            this.metersbox.Font = new System.Drawing.Font("Arial", 11F);
            this.metersbox.ForeColor = System.Drawing.Color.Black;
            this.metersbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.metersbox.HoverState.Parent = this.metersbox;
            this.metersbox.Location = new System.Drawing.Point(559, 150);
            this.metersbox.Margin = new System.Windows.Forms.Padding(4);
            this.metersbox.Name = "metersbox";
            this.metersbox.PasswordChar = '\0';
            this.metersbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.metersbox.PlaceholderText = "";
            this.metersbox.SelectedText = "";
            this.metersbox.ShadowDecoration.Parent = this.metersbox;
            this.metersbox.Size = new System.Drawing.Size(186, 33);
            this.metersbox.TabIndex = 45;
            this.metersbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metersbox_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(484, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Meters:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(496, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(119, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Client ID:";
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
            this.addBtn.Location = new System.Drawing.Point(559, 261);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(113, 44);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Add Order";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // selectBtn
            // 
            this.selectBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBtn.Animated = true;
            this.selectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.selectBtn.BorderRadius = 10;
            this.selectBtn.BorderThickness = 3;
            this.selectBtn.CheckedState.Parent = this.selectBtn;
            this.selectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBtn.CustomImages.Parent = this.selectBtn;
            this.selectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.selectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.selectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.selectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.selectBtn.DisabledState.Parent = this.selectBtn;
            this.selectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.selectBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.selectBtn.ForeColor = System.Drawing.Color.White;
            this.selectBtn.HoverState.Parent = this.selectBtn;
            this.selectBtn.Location = new System.Drawing.Point(205, 167);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.ShadowDecoration.Parent = this.selectBtn;
            this.selectBtn.Size = new System.Drawing.Size(93, 38);
            this.selectBtn.TabIndex = 36;
            this.selectBtn.Text = "Select";
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(468, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fabric ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(112, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 60;
            this.label3.Text = "Due Date:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(468, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Order ID:";
            // 
            // oidBox
            // 
            this.oidBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.oidBox.BorderColor = System.Drawing.Color.MediumBlue;
            this.oidBox.BorderRadius = 5;
            this.oidBox.BorderThickness = 3;
            this.oidBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oidBox.DefaultText = "";
            this.oidBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.oidBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.oidBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oidBox.DisabledState.Parent = this.oidBox;
            this.oidBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.oidBox.Enabled = false;
            this.oidBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oidBox.FocusedState.Parent = this.oidBox;
            this.oidBox.Font = new System.Drawing.Font("Arial", 11F);
            this.oidBox.ForeColor = System.Drawing.Color.MediumBlue;
            this.oidBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.oidBox.HoverState.Parent = this.oidBox;
            this.oidBox.Location = new System.Drawing.Point(559, 53);
            this.oidBox.Margin = new System.Windows.Forms.Padding(4);
            this.oidBox.Name = "oidBox";
            this.oidBox.PasswordChar = '\0';
            this.oidBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.oidBox.PlaceholderText = "";
            this.oidBox.SelectedText = "";
            this.oidBox.ShadowDecoration.Parent = this.oidBox;
            this.oidBox.Size = new System.Drawing.Size(138, 36);
            this.oidBox.TabIndex = 45;
            // 
            // datepicker
            // 
            this.datepicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datepicker.Animated = true;
            this.datepicker.BorderColor = System.Drawing.Color.DimGray;
            this.datepicker.BorderRadius = 5;
            this.datepicker.BorderThickness = 3;
            this.datepicker.Checked = true;
            this.datepicker.CheckedState.Parent = this.datepicker;
            this.datepicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datepicker.FillColor = System.Drawing.Color.White;
            this.datepicker.Font = new System.Drawing.Font("Arial", 10F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.HoverState.Parent = this.datepicker;
            this.datepicker.Location = new System.Drawing.Point(205, 101);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(2021, 12, 28, 12, 15, 32, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.ShadowDecoration.Parent = this.datepicker;
            this.datepicker.Size = new System.Drawing.Size(145, 39);
            this.datepicker.TabIndex = 62;
            this.datepicker.Value = new System.DateTime(2021, 12, 28, 12, 25, 56, 0);
            this.datepicker.ValueChanged += new System.EventHandler(this.datepicker_ValueChanged);
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
            this.cidcombo.Location = new System.Drawing.Point(205, 53);
            this.cidcombo.Name = "cidcombo";
            this.cidcombo.ShadowDecoration.Parent = this.cidcombo;
            this.cidcombo.Size = new System.Drawing.Size(129, 36);
            this.cidcombo.TabIndex = 63;
            this.cidcombo.Tag = "select";
            // 
            // orderGrid
            // 
            this.orderGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.orderGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.orderGrid.GridColor = System.Drawing.Color.White;
            this.orderGrid.Location = new System.Drawing.Point(74, 359);
            this.orderGrid.Name = "orderGrid";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.orderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.orderGrid.Size = new System.Drawing.Size(879, 101);
            this.orderGrid.TabIndex = 64;
            this.orderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderGrid_CellContentClick);
            // 
            // fidcombo
            // 
            this.fidcombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fidcombo.BackColor = System.Drawing.Color.Transparent;
            this.fidcombo.BorderColor = System.Drawing.Color.Gray;
            this.fidcombo.BorderRadius = 5;
            this.fidcombo.BorderThickness = 3;
            this.fidcombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fidcombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fidcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fidcombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fidcombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fidcombo.FocusedState.Parent = this.fidcombo;
            this.fidcombo.Font = new System.Drawing.Font("Arial", 11F);
            this.fidcombo.ForeColor = System.Drawing.Color.Black;
            this.fidcombo.HoverState.Parent = this.fidcombo;
            this.fidcombo.ItemHeight = 30;
            this.fidcombo.ItemsAppearance.Parent = this.fidcombo;
            this.fidcombo.Location = new System.Drawing.Point(559, 101);
            this.fidcombo.Name = "fidcombo";
            this.fidcombo.ShadowDecoration.Parent = this.fidcombo;
            this.fidcombo.Size = new System.Drawing.Size(138, 36);
            this.fidcombo.TabIndex = 65;
            this.fidcombo.Tag = "select";
            this.fidcombo.SelectedIndexChanged += new System.EventHandler(this.fidcombo_SelectedIndexChanged);
            // 
            // UC_newOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.fidcombo);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.cidcombo);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.oidBox);
            this.Controls.Add(this.metersbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "UC_newOrder";
            this.Size = new System.Drawing.Size(1026, 562);
            this.Load += new System.EventHandler(this.UC_newOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox colorbox;
        private Guna.UI2.WinForms.Guna2TextBox metersbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private Guna.UI2.WinForms.Guna2Button selectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox oidBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private Guna.UI2.WinForms.Guna2ComboBox cidcombo;
        private System.Windows.Forms.DataGridView orderGrid;
        private Guna.UI2.WinForms.Guna2ComboBox fidcombo;
    }
}
