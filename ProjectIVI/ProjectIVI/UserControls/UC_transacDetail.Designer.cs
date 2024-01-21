namespace ProjectIVI.UserControls
{
    partial class UC_transacDetail
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
            this.viewbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.transGrid = new System.Windows.Forms.DataGridView();
            this.oidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.transGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewbtn
            // 
            this.viewbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewbtn.Animated = true;
            this.viewbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.viewbtn.BorderRadius = 10;
            this.viewbtn.BorderThickness = 3;
            this.viewbtn.CheckedState.Parent = this.viewbtn;
            this.viewbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewbtn.CustomImages.Parent = this.viewbtn;
            this.viewbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewbtn.DisabledState.Parent = this.viewbtn;
            this.viewbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.viewbtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.ForeColor = System.Drawing.Color.White;
            this.viewbtn.HoverState.Parent = this.viewbtn;
            this.viewbtn.Location = new System.Drawing.Point(558, 79);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.ShadowDecoration.Parent = this.viewbtn;
            this.viewbtn.Size = new System.Drawing.Size(177, 36);
            this.viewbtn.TabIndex = 61;
            this.viewbtn.Text = "View Transactions";
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 60;
            this.label5.Text = "Order ID:";
            // 
            // transGrid
            // 
            this.transGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.transGrid.BackgroundColor = System.Drawing.Color.White;
            this.transGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.transGrid.GridColor = System.Drawing.Color.White;
            this.transGrid.Location = new System.Drawing.Point(18, 203);
            this.transGrid.Name = "transGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.transGrid.Size = new System.Drawing.Size(1050, 91);
            this.transGrid.TabIndex = 80;
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
            this.oidcombo.Location = new System.Drawing.Point(376, 79);
            this.oidcombo.Name = "oidcombo";
            this.oidcombo.ShadowDecoration.Parent = this.oidcombo;
            this.oidcombo.Size = new System.Drawing.Size(137, 36);
            this.oidcombo.TabIndex = 83;
            this.oidcombo.Tag = "select";
            // 
            // UC_transacDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.oidcombo);
            this.Controls.Add(this.transGrid);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.label5);
            this.Name = "UC_transacDetail";
            this.Size = new System.Drawing.Size(1086, 517);
            this.Load += new System.EventHandler(this.UC_transacDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button viewbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView transGrid;
        private Guna.UI2.WinForms.Guna2ComboBox oidcombo;
    }
}
