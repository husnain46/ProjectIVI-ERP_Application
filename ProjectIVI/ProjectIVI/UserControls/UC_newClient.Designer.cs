namespace ProjectIVI.UserControls
{
    partial class UC_newClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mailbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.citybox = new Guna.UI2.WinForms.Guna2TextBox();
            this.contactbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.companybox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cnamebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clientGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mailbox
            // 
            this.mailbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mailbox.BorderColor = System.Drawing.Color.Gray;
            this.mailbox.BorderRadius = 5;
            this.mailbox.BorderThickness = 3;
            this.mailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailbox.DefaultText = "";
            this.mailbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mailbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mailbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.DisabledState.Parent = this.mailbox;
            this.mailbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mailbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.FocusedState.Parent = this.mailbox;
            this.mailbox.Font = new System.Drawing.Font("Arial", 11F);
            this.mailbox.ForeColor = System.Drawing.Color.Black;
            this.mailbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mailbox.HoverState.Parent = this.mailbox;
            this.mailbox.Location = new System.Drawing.Point(371, 216);
            this.mailbox.Margin = new System.Windows.Forms.Padding(4);
            this.mailbox.Name = "mailbox";
            this.mailbox.PasswordChar = '\0';
            this.mailbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.mailbox.PlaceholderText = "";
            this.mailbox.SelectedText = "";
            this.mailbox.ShadowDecoration.Parent = this.mailbox;
            this.mailbox.Size = new System.Drawing.Size(186, 33);
            this.mailbox.TabIndex = 30;
            this.mailbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mailbox_KeyPress);
            // 
            // citybox
            // 
            this.citybox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.citybox.BorderColor = System.Drawing.Color.Gray;
            this.citybox.BorderRadius = 5;
            this.citybox.BorderThickness = 3;
            this.citybox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.citybox.DefaultText = "";
            this.citybox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.citybox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.citybox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.citybox.DisabledState.Parent = this.citybox;
            this.citybox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.citybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.citybox.FocusedState.Parent = this.citybox;
            this.citybox.Font = new System.Drawing.Font("Arial", 11F);
            this.citybox.ForeColor = System.Drawing.Color.Black;
            this.citybox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.citybox.HoverState.Parent = this.citybox;
            this.citybox.Location = new System.Drawing.Point(371, 171);
            this.citybox.Margin = new System.Windows.Forms.Padding(4);
            this.citybox.Name = "citybox";
            this.citybox.PasswordChar = '\0';
            this.citybox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.citybox.PlaceholderText = "";
            this.citybox.SelectedText = "";
            this.citybox.ShadowDecoration.Parent = this.citybox;
            this.citybox.Size = new System.Drawing.Size(186, 33);
            this.citybox.TabIndex = 31;
            this.citybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.citybox_KeyPress);
            // 
            // contactbox
            // 
            this.contactbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactbox.BorderColor = System.Drawing.Color.Gray;
            this.contactbox.BorderRadius = 5;
            this.contactbox.BorderThickness = 3;
            this.contactbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactbox.DefaultText = "";
            this.contactbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactbox.DisabledState.Parent = this.contactbox;
            this.contactbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactbox.FocusedState.Parent = this.contactbox;
            this.contactbox.Font = new System.Drawing.Font("Arial", 11F);
            this.contactbox.ForeColor = System.Drawing.Color.Black;
            this.contactbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactbox.HoverState.Parent = this.contactbox;
            this.contactbox.Location = new System.Drawing.Point(371, 125);
            this.contactbox.Margin = new System.Windows.Forms.Padding(4);
            this.contactbox.Name = "contactbox";
            this.contactbox.PasswordChar = '\0';
            this.contactbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.contactbox.PlaceholderText = "";
            this.contactbox.SelectedText = "";
            this.contactbox.ShadowDecoration.Parent = this.contactbox;
            this.contactbox.Size = new System.Drawing.Size(186, 33);
            this.contactbox.TabIndex = 32;
            this.contactbox.TextChanged += new System.EventHandler(this.contactbox_TextChanged);
            this.contactbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactbox_KeyPress);
            // 
            // companybox
            // 
            this.companybox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.companybox.BorderColor = System.Drawing.Color.Gray;
            this.companybox.BorderRadius = 5;
            this.companybox.BorderThickness = 3;
            this.companybox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companybox.DefaultText = "";
            this.companybox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.companybox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.companybox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companybox.DisabledState.Parent = this.companybox;
            this.companybox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.companybox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companybox.FocusedState.Parent = this.companybox;
            this.companybox.Font = new System.Drawing.Font("Arial", 11F);
            this.companybox.ForeColor = System.Drawing.Color.Black;
            this.companybox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.companybox.HoverState.Parent = this.companybox;
            this.companybox.Location = new System.Drawing.Point(371, 78);
            this.companybox.Margin = new System.Windows.Forms.Padding(4);
            this.companybox.Name = "companybox";
            this.companybox.PasswordChar = '\0';
            this.companybox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.companybox.PlaceholderText = "";
            this.companybox.SelectedText = "";
            this.companybox.ShadowDecoration.Parent = this.companybox;
            this.companybox.Size = new System.Drawing.Size(186, 33);
            this.companybox.TabIndex = 33;
            this.companybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companybox_KeyPress);
            // 
            // cnamebox
            // 
            this.cnamebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cnamebox.BorderColor = System.Drawing.Color.Gray;
            this.cnamebox.BorderRadius = 5;
            this.cnamebox.BorderThickness = 3;
            this.cnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cnamebox.DefaultText = "";
            this.cnamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cnamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cnamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnamebox.DisabledState.Parent = this.cnamebox;
            this.cnamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cnamebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnamebox.FocusedState.Parent = this.cnamebox;
            this.cnamebox.Font = new System.Drawing.Font("Arial", 11F);
            this.cnamebox.ForeColor = System.Drawing.Color.Black;
            this.cnamebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cnamebox.HoverState.Parent = this.cnamebox;
            this.cnamebox.Location = new System.Drawing.Point(371, 31);
            this.cnamebox.Margin = new System.Windows.Forms.Padding(4);
            this.cnamebox.Name = "cnamebox";
            this.cnamebox.PasswordChar = '\0';
            this.cnamebox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.cnamebox.PlaceholderText = "";
            this.cnamebox.SelectedText = "";
            this.cnamebox.ShadowDecoration.Parent = this.cnamebox;
            this.cnamebox.Size = new System.Drawing.Size(186, 33);
            this.cnamebox.TabIndex = 34;
            this.cnamebox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cnamebox_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label8.Location = new System.Drawing.Point(318, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "City:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label7.Location = new System.Drawing.Point(308, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label9.Location = new System.Drawing.Point(225, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "Company Name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label6.Location = new System.Drawing.Point(287, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Contact:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.label5.Location = new System.Drawing.Point(254, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Client Name:";
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
            this.addBtn.Location = new System.Drawing.Point(371, 276);
            this.addBtn.Name = "addBtn";
            this.addBtn.ShadowDecoration.Parent = this.addBtn;
            this.addBtn.Size = new System.Drawing.Size(115, 37);
            this.addBtn.TabIndex = 24;
            this.addBtn.Text = "Enter Data";
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // clientGrid
            // 
            this.clientGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.clientGrid.BackgroundColor = System.Drawing.Color.White;
            this.clientGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.clientGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.clientGrid.GridColor = System.Drawing.Color.White;
            this.clientGrid.Location = new System.Drawing.Point(93, 366);
            this.clientGrid.Name = "clientGrid";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.clientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.clientGrid.Size = new System.Drawing.Size(741, 97);
            this.clientGrid.TabIndex = 49;
            // 
            // UC_newClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.clientGrid);
            this.Controls.Add(this.mailbox);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.contactbox);
            this.Controls.Add(this.companybox);
            this.Controls.Add(this.cnamebox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addBtn);
            this.Name = "UC_newClient";
            this.Size = new System.Drawing.Size(925, 517);
            this.Load += new System.EventHandler(this.UC_newClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox mailbox;
        private Guna.UI2.WinForms.Guna2TextBox citybox;
        private Guna.UI2.WinForms.Guna2TextBox contactbox;
        private Guna.UI2.WinForms.Guna2TextBox companybox;
        private Guna.UI2.WinForms.Guna2TextBox cnamebox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button addBtn;
        private System.Windows.Forms.DataGridView clientGrid;
    }
}
