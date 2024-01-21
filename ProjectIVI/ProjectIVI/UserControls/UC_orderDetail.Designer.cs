namespace ProjectIVI.UserControls
{
    partial class UC_orderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.oidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBtn.Animated = true;
            this.viewBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.viewBtn.BorderRadius = 10;
            this.viewBtn.BorderThickness = 3;
            this.viewBtn.CheckedState.Parent = this.viewBtn;
            this.viewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBtn.CustomImages.Parent = this.viewBtn;
            this.viewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewBtn.DisabledState.Parent = this.viewBtn;
            this.viewBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.viewBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.viewBtn.ForeColor = System.Drawing.Color.White;
            this.viewBtn.HoverState.Parent = this.viewBtn;
            this.viewBtn.Location = new System.Drawing.Point(525, 77);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.ShadowDecoration.Parent = this.viewBtn;
            this.viewBtn.Size = new System.Drawing.Size(120, 36);
            this.viewBtn.TabIndex = 76;
            this.viewBtn.Text = "View Order";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(265, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Order ID:";
            // 
            // orderGrid
            // 
            this.orderGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.orderGrid.BackgroundColor = System.Drawing.Color.White;
            this.orderGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderGrid.GridColor = System.Drawing.Color.White;
            this.orderGrid.Location = new System.Drawing.Point(35, 206);
            this.orderGrid.Name = "orderGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.orderGrid.Size = new System.Drawing.Size(933, 123);
            this.orderGrid.TabIndex = 78;
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
            this.oidcombo.Location = new System.Drawing.Point(352, 77);
            this.oidcombo.Name = "oidcombo";
            this.oidcombo.ShadowDecoration.Parent = this.oidcombo;
            this.oidcombo.Size = new System.Drawing.Size(137, 36);
            this.oidcombo.TabIndex = 79;
            this.oidcombo.Tag = "select";
            this.oidcombo.SelectionChangeCommitted += new System.EventHandler(this.oidcombo_SelectionChangeCommitted_1);
            // 
            // UC_orderDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.oidcombo);
            this.Controls.Add(this.orderGrid);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label1);
            this.Name = "UC_orderDetail";
            this.Size = new System.Drawing.Size(997, 517);
            this.Load += new System.EventHandler(this.UC_orderDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderGrid;
        private Guna.UI2.WinForms.Guna2ComboBox oidcombo;
    }
}
