namespace ProjectIVI.UserControls
{
    partial class UC_newFabric
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ftypebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ratebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fnamebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.fabricGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.fabricGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ftypebox
            // 
            this.ftypebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ftypebox.BorderColor = System.Drawing.Color.Gray;
            this.ftypebox.BorderRadius = 5;
            this.ftypebox.BorderThickness = 3;
            this.ftypebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ftypebox.DefaultText = "";
            this.ftypebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ftypebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ftypebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ftypebox.DisabledState.Parent = this.ftypebox;
            this.ftypebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ftypebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ftypebox.FocusedState.Parent = this.ftypebox;
            this.ftypebox.Font = new System.Drawing.Font("Arial", 11F);
            this.ftypebox.ForeColor = System.Drawing.Color.Black;
            this.ftypebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ftypebox.HoverState.Parent = this.ftypebox;
            this.ftypebox.Location = new System.Drawing.Point(378, 134);
            this.ftypebox.Margin = new System.Windows.Forms.Padding(4);
            this.ftypebox.Name = "ftypebox";
            this.ftypebox.PasswordChar = '\0';
            this.ftypebox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ftypebox.PlaceholderText = "";
            this.ftypebox.SelectedText = "";
            this.ftypebox.ShadowDecoration.Parent = this.ftypebox;
            this.ftypebox.Size = new System.Drawing.Size(186, 33);
            this.ftypebox.TabIndex = 44;
            this.ftypebox.TextChanged += new System.EventHandler(this.ftypebox_TextChanged);
            this.ftypebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ftypebox_KeyPress);
            // 
            // ratebox
            // 
            this.ratebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ratebox.BorderColor = System.Drawing.Color.Gray;
            this.ratebox.BorderRadius = 5;
            this.ratebox.BorderThickness = 3;
            this.ratebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ratebox.DefaultText = "";
            this.ratebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ratebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ratebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ratebox.DisabledState.Parent = this.ratebox;
            this.ratebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ratebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ratebox.FocusedState.Parent = this.ratebox;
            this.ratebox.Font = new System.Drawing.Font("Arial", 11F);
            this.ratebox.ForeColor = System.Drawing.Color.Black;
            this.ratebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ratebox.HoverState.Parent = this.ratebox;
            this.ratebox.Location = new System.Drawing.Point(378, 87);
            this.ratebox.Margin = new System.Windows.Forms.Padding(4);
            this.ratebox.Name = "ratebox";
            this.ratebox.PasswordChar = '\0';
            this.ratebox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ratebox.PlaceholderText = "";
            this.ratebox.SelectedText = "";
            this.ratebox.ShadowDecoration.Parent = this.ratebox;
            this.ratebox.Size = new System.Drawing.Size(186, 33);
            this.ratebox.TabIndex = 45;
            this.ratebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ratebox_KeyPress);
            // 
            // fnamebox
            // 
            this.fnamebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnamebox.BorderColor = System.Drawing.Color.Gray;
            this.fnamebox.BorderRadius = 5;
            this.fnamebox.BorderThickness = 3;
            this.fnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnamebox.DefaultText = "";
            this.fnamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fnamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fnamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnamebox.DisabledState.Parent = this.fnamebox;
            this.fnamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fnamebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnamebox.FocusedState.Parent = this.fnamebox;
            this.fnamebox.Font = new System.Drawing.Font("Arial", 11F);
            this.fnamebox.ForeColor = System.Drawing.Color.Black;
            this.fnamebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fnamebox.HoverState.Parent = this.fnamebox;
            this.fnamebox.Location = new System.Drawing.Point(378, 40);
            this.fnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.fnamebox.Name = "fnamebox";
            this.fnamebox.PasswordChar = '\0';
            this.fnamebox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.fnamebox.PlaceholderText = "";
            this.fnamebox.SelectedText = "";
            this.fnamebox.ShadowDecoration.Parent = this.fnamebox;
            this.fnamebox.Size = new System.Drawing.Size(186, 33);
            this.fnamebox.TabIndex = 46;
            this.fnamebox.TextChanged += new System.EventHandler(this.fnamebox_TextChanged);
            this.fnamebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fnamebox_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(231, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 39;
            this.label9.Text = "Rate (per meter):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(269, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Fabric Type:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Fabric Name:";
            // 
            // addBtn
            // 
            this.addBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtn.Animated = true;
            this.addBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.addBtn.BorderRadius = 10;
            this.addBtn.BorderThickness = 3;
            this.addBtn.CheckedState.Parent = this.addBtn;
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
            this.addBtn.Location = new System.Drawing.Point(378, 192);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(115, 37);
            this.addBtn.TabIndex = 36;
            this.addBtn.Text = "Enter Data";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click_1);
            // 
            // fabricGrid
            // 
            this.fabricGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fabricGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fabricGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.fabricGrid.BackgroundColor = System.Drawing.Color.White;
            this.fabricGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fabricGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.fabricGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fabricGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.fabricGrid.GridColor = System.Drawing.Color.White;
            this.fabricGrid.Location = new System.Drawing.Point(175, 276);
            this.fabricGrid.Name = "fabricGrid";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fabricGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.fabricGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.fabricGrid.Size = new System.Drawing.Size(558, 76);
            this.fabricGrid.TabIndex = 50;
            // 
            // UC_newFabric
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.fabricGrid);
            this.Controls.Add(this.ftypebox);
            this.Controls.Add(this.ratebox);
            this.Controls.Add(this.fnamebox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_newFabric";
            this.Size = new System.Drawing.Size(925, 517);
            this.Load += new System.EventHandler(this.UC_newFabric_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.fabricGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox ftypebox;
        private Guna.UI2.WinForms.Guna2TextBox ratebox;
        private Guna.UI2.WinForms.Guna2TextBox fnamebox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.DataGridView fabricGrid;
    }
}
