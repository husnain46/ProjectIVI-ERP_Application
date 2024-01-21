namespace ProjectIVI.UserControls
{
    partial class UC_updateOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.colorbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.metersbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.updatedate = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.oidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(183, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Order ID:";
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
            this.colorbox.Location = new System.Drawing.Point(570, 138);
            this.colorbox.Margin = new System.Windows.Forms.Padding(4);
            this.colorbox.Name = "colorbox";
            this.colorbox.PasswordChar = '\0';
            this.colorbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.colorbox.PlaceholderText = "";
            this.colorbox.SelectedText = "";
            this.colorbox.ShadowDecoration.Parent = this.colorbox;
            this.colorbox.Size = new System.Drawing.Size(137, 36);
            this.colorbox.TabIndex = 67;
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
            this.metersbox.Location = new System.Drawing.Point(570, 84);
            this.metersbox.Margin = new System.Windows.Forms.Padding(4);
            this.metersbox.Name = "metersbox";
            this.metersbox.PasswordChar = '\0';
            this.metersbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.metersbox.PlaceholderText = "";
            this.metersbox.SelectedText = "";
            this.metersbox.ShadowDecoration.Parent = this.metersbox;
            this.metersbox.Size = new System.Drawing.Size(137, 36);
            this.metersbox.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(491, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 18);
            this.label9.TabIndex = 63;
            this.label9.Text = "Meters:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(503, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Color:";
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtn.Animated = true;
            this.updateBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.BorderThickness = 3;
            this.updateBtn.CheckedState.Parent = this.updateBtn;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.CustomImages.Parent = this.updateBtn;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.DisabledState.Parent = this.updateBtn;
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.updateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.HoverState.Parent = this.updateBtn;
            this.updateBtn.Location = new System.Drawing.Point(570, 190);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.ShadowDecoration.Parent = this.updateBtn;
            this.updateBtn.Size = new System.Drawing.Size(137, 38);
            this.updateBtn.TabIndex = 70;
            this.updateBtn.Text = "Update Order";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label3.Location = new System.Drawing.Point(177, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Due Date:";
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
            this.datepicker.Location = new System.Drawing.Point(270, 84);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.ShadowDecoration.Parent = this.datepicker;
            this.datepicker.Size = new System.Drawing.Size(137, 40);
            this.datepicker.TabIndex = 72;
            this.datepicker.Value = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            // 
            // updatedate
            // 
            this.updatedate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updatedate.Animated = true;
            this.updatedate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.updatedate.BorderRadius = 10;
            this.updatedate.BorderThickness = 3;
            this.updatedate.CheckedState.Parent = this.updatedate;
            this.updatedate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatedate.CustomImages.Parent = this.updatedate;
            this.updatedate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updatedate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updatedate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updatedate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updatedate.DisabledState.Parent = this.updatedate;
            this.updatedate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.updatedate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.updatedate.ForeColor = System.Drawing.Color.White;
            this.updatedate.HoverState.Parent = this.updatedate;
            this.updatedate.Location = new System.Drawing.Point(270, 146);
            this.updatedate.Name = "updatedate";
            this.updatedate.ShadowDecoration.Parent = this.updatedate;
            this.updatedate.Size = new System.Drawing.Size(129, 38);
            this.updatedate.TabIndex = 73;
            this.updatedate.Text = "Update Date";
            this.updatedate.Click += new System.EventHandler(this.updatedate_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(474, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "Fabric ID:";
            // 
            // orderGrid
            // 
            this.orderGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.orderGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.orderGrid.GridColor = System.Drawing.Color.White;
            this.orderGrid.Location = new System.Drawing.Point(41, 304);
            this.orderGrid.Name = "orderGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.orderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.orderGrid.Size = new System.Drawing.Size(933, 110);
            this.orderGrid.TabIndex = 76;
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
            this.oidcombo.Location = new System.Drawing.Point(270, 33);
            this.oidcombo.Name = "oidcombo";
            this.oidcombo.ShadowDecoration.Parent = this.oidcombo;
            this.oidcombo.Size = new System.Drawing.Size(137, 36);
            this.oidcombo.TabIndex = 77;
            this.oidcombo.Tag = "select";
            this.oidcombo.SelectionChangeCommitted += new System.EventHandler(this.oidcombo_SelectionChangeCommitted_1);
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
            this.fidcombo.Location = new System.Drawing.Point(570, 33);
            this.fidcombo.Name = "fidcombo";
            this.fidcombo.ShadowDecoration.Parent = this.fidcombo;
            this.fidcombo.Size = new System.Drawing.Size(137, 36);
            this.fidcombo.TabIndex = 78;
            this.fidcombo.Tag = "select";
            this.fidcombo.SelectedIndexChanged += new System.EventHandler(this.fidcombo_SelectedIndexChanged);
            // 
            // UC_updateOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.fidcombo);
            this.Controls.Add(this.oidcombo);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.updatedate);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metersbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "UC_updateOrder";
            this.Size = new System.Drawing.Size(1012, 517);
            this.Load += new System.EventHandler(this.UC_updateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox colorbox;
        private Guna.UI2.WinForms.Guna2TextBox metersbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private Guna.UI2.WinForms.Guna2Button updatedate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView orderGrid;
        private Guna.UI2.WinForms.Guna2ComboBox oidcombo;
        private Guna.UI2.WinForms.Guna2ComboBox fidcombo;
    }
}
