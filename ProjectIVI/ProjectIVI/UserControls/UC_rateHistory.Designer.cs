namespace ProjectIVI.UserControls
{
    partial class UC_rateHistory
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
            this.fidcombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fabricGrid = new System.Windows.Forms.DataGridView();
            this.datepicker3 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fabricGrid)).BeginInit();
            this.SuspendLayout();
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
            this.fidcombo.Location = new System.Drawing.Point(274, 39);
            this.fidcombo.Name = "fidcombo";
            this.fidcombo.ShadowDecoration.Parent = this.fidcombo;
            this.fidcombo.Size = new System.Drawing.Size(129, 36);
            this.fidcombo.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label1.Location = new System.Drawing.Point(183, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fabric ID:";
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewBtn.Animated = true;
            this.viewBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.viewBtn.BorderRadius = 10;
            this.viewBtn.BorderThickness = 3;
            this.viewBtn.CheckedState.Parent = this.viewBtn;
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
            this.viewBtn.Location = new System.Drawing.Point(399, 121);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.ShadowDecoration.Parent = this.viewBtn;
            this.viewBtn.Size = new System.Drawing.Size(128, 36);
            this.viewBtn.TabIndex = 82;
            this.viewBtn.Text = "View Rates";
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label2.Location = new System.Drawing.Point(470, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Month:";
            // 
            // fabricGrid
            // 
            this.fabricGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fabricGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fabricGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.fabricGrid.BackgroundColor = System.Drawing.Color.White;
            this.fabricGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fabricGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.fabricGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fabricGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.fabricGrid.GridColor = System.Drawing.Color.White;
            this.fabricGrid.Location = new System.Drawing.Point(231, 196);
            this.fabricGrid.Name = "fabricGrid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fabricGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.fabricGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.fabricGrid.Size = new System.Drawing.Size(459, 233);
            this.fabricGrid.TabIndex = 88;
            // 
            // datepicker3
            // 
            this.datepicker3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datepicker3.Animated = true;
            this.datepicker3.BorderColor = System.Drawing.Color.DimGray;
            this.datepicker3.BorderRadius = 5;
            this.datepicker3.BorderThickness = 3;
            this.datepicker3.Checked = true;
            this.datepicker3.CheckedState.Parent = this.datepicker3;
            this.datepicker3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.datepicker3.FillColor = System.Drawing.Color.White;
            this.datepicker3.Font = new System.Drawing.Font("Arial", 10F);
            this.datepicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker3.HoverState.Parent = this.datepicker3;
            this.datepicker3.Location = new System.Drawing.Point(538, 36);
            this.datepicker3.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker3.MinDate = new System.DateTime(2021, 12, 28, 12, 15, 32, 0);
            this.datepicker3.Name = "datepicker3";
            this.datepicker3.ShadowDecoration.Parent = this.datepicker3;
            this.datepicker3.Size = new System.Drawing.Size(145, 39);
            this.datepicker3.TabIndex = 89;
            this.datepicker3.Value = new System.DateTime(2021, 12, 28, 12, 25, 56, 0);
            // 
            // UC_rateHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.datepicker3);
            this.Controls.Add(this.fabricGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fidcombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewBtn);
            this.Name = "UC_rateHistory";
            this.Size = new System.Drawing.Size(925, 517);
            this.Load += new System.EventHandler(this.UC_rateHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fabricGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox fidcombo;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button viewBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView fabricGrid;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker3;
    }
}
