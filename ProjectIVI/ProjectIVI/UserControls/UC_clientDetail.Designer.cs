namespace ProjectIVI.UserControls
{
    partial class UC_clientDetail
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
            this.clientGrid = new System.Windows.Forms.DataGridView();
            this.cidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).BeginInit();
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
            this.viewbtn.Location = new System.Drawing.Point(503, 78);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.ShadowDecoration.Parent = this.viewbtn;
            this.viewbtn.Size = new System.Drawing.Size(108, 36);
            this.viewbtn.TabIndex = 57;
            this.viewbtn.Text = "View Data";
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Client ID:";
            // 
            // clientGrid
            // 
            this.clientGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clientGrid.BackgroundColor = System.Drawing.Color.White;
            this.clientGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.clientGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.clientGrid.GridColor = System.Drawing.Color.White;
            this.clientGrid.Location = new System.Drawing.Point(92, 202);
            this.clientGrid.Name = "clientGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.clientGrid.Size = new System.Drawing.Size(741, 99);
            this.clientGrid.TabIndex = 59;
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
            this.cidcombo.Location = new System.Drawing.Point(326, 78);
            this.cidcombo.Name = "cidcombo";
            this.cidcombo.ShadowDecoration.Parent = this.cidcombo;
            this.cidcombo.Size = new System.Drawing.Size(129, 36);
            this.cidcombo.TabIndex = 60;
            this.cidcombo.Tag = "select";
            this.cidcombo.SelectedIndexChanged += new System.EventHandler(this.cidcombo_SelectedIndexChanged_1);
            this.cidcombo.SelectionChangeCommitted += new System.EventHandler(this.cidcombo_SelectionChangeCommitted_1);
            // 
            // UC_clientDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.cidcombo);
            this.Controls.Add(this.clientGrid);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_clientDetail";
            this.Size = new System.Drawing.Size(925, 517);
            this.Load += new System.EventHandler(this.UC_clientDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button viewbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView clientGrid;
        private Guna.UI2.WinForms.Guna2ComboBox cidcombo;
    }
}
