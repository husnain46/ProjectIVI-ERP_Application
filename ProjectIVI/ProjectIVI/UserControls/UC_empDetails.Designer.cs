namespace ProjectIVI.UserControls
{
    partial class UC_empDetails
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
            this.eidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.empGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            this.SuspendLayout();
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
            this.eidcombo.Location = new System.Drawing.Point(372, 69);
            this.eidcombo.Name = "eidcombo";
            this.eidcombo.ShadowDecoration.Parent = this.eidcombo;
            this.eidcombo.Size = new System.Drawing.Size(129, 36);
            this.eidcombo.TabIndex = 81;
            this.eidcombo.SelectionChangeCommitted += new System.EventHandler(this.eidcombo_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(251, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 80;
            this.label1.Text = "Employee ID:";
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
            this.viewBtn.Location = new System.Drawing.Point(560, 69);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.ShadowDecoration.Parent = this.viewBtn;
            this.viewBtn.Size = new System.Drawing.Size(124, 36);
            this.viewBtn.TabIndex = 68;
            this.viewBtn.Text = "View Data";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // empGrid
            // 
            this.empGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.empGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.empGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.empGrid.BackgroundColor = System.Drawing.Color.White;
            this.empGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.empGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.empGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.empGrid.GridColor = System.Drawing.Color.White;
            this.empGrid.Location = new System.Drawing.Point(35, 174);
            this.empGrid.Name = "empGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.empGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.empGrid.Size = new System.Drawing.Size(982, 99);
            this.empGrid.TabIndex = 82;
            // 
            // UC_empDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.eidcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBtn);
            this.Name = "UC_empDetails";
            this.Size = new System.Drawing.Size(1042, 517);
            this.Load += new System.EventHandler(this.UC_empDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox eidcombo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private System.Windows.Forms.DataGridView empGrid;
    }
}
