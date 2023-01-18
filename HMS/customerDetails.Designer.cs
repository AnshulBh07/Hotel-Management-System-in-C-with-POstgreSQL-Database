namespace HMS
{
    partial class customerDetails
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchByCombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.custDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchByTxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.custDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(441, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Search By";
            // 
            // searchByCombobox
            // 
            this.searchByCombobox.BackColor = System.Drawing.Color.Transparent;
            this.searchByCombobox.CustomizableEdges = customizableEdges1;
            this.searchByCombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchByCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByCombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByCombobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchByCombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.searchByCombobox.ItemHeight = 30;
            this.searchByCombobox.Items.AddRange(new object[] {
            "Name",
            "Mobile Number",
            "Room Number"});
            this.searchByCombobox.Location = new System.Drawing.Point(441, 68);
            this.searchByCombobox.Name = "searchByCombobox";
            this.searchByCombobox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.searchByCombobox.Size = new System.Drawing.Size(361, 36);
            this.searchByCombobox.TabIndex = 31;
            this.searchByCombobox.SelectedIndexChanged += new System.EventHandler(this.searchByCombobox_SelectedIndexChanged);
            // 
            // custDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.custDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.custDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.custDetails.ColumnHeadersHeight = 4;
            this.custDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.custDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.custDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.custDetails.Location = new System.Drawing.Point(22, 174);
            this.custDetails.Name = "custDetails";
            this.custDetails.RowHeadersVisible = false;
            this.custDetails.RowHeadersWidth = 51;
            this.custDetails.RowTemplate.Height = 29;
            this.custDetails.Size = new System.Drawing.Size(1252, 426);
            this.custDetails.TabIndex = 32;
            this.custDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.custDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.custDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.custDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.custDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.custDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.custDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.custDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.custDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.custDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.custDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.custDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.custDetails.ThemeStyle.HeaderStyle.Height = 4;
            this.custDetails.ThemeStyle.ReadOnly = false;
            this.custDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.custDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.custDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.custDetails.ThemeStyle.RowsStyle.Height = 29;
            this.custDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.custDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.custDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // searchByTxtbox
            // 
            this.searchByTxtbox.CustomizableEdges = customizableEdges3;
            this.searchByTxtbox.DefaultText = "";
            this.searchByTxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchByTxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchByTxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByTxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchByTxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByTxtbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchByTxtbox.ForeColor = System.Drawing.Color.Black;
            this.searchByTxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchByTxtbox.Location = new System.Drawing.Point(441, 111);
            this.searchByTxtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByTxtbox.Name = "searchByTxtbox";
            this.searchByTxtbox.PasswordChar = '\0';
            this.searchByTxtbox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchByTxtbox.PlaceholderText = "";
            this.searchByTxtbox.SelectedText = "";
            this.searchByTxtbox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.searchByTxtbox.Size = new System.Drawing.Size(361, 49);
            this.searchByTxtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.searchByTxtbox.TabIndex = 33;
            this.searchByTxtbox.TextOffset = new System.Drawing.Point(10, 0);
            this.searchByTxtbox.TextChanged += new System.EventHandler(this.searchByTxtbox_TextChanged);
            // 
            // customerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1298, 623);
            this.Controls.Add(this.searchByTxtbox);
            this.Controls.Add(this.custDetails);
            this.Controls.Add(this.searchByCombobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customerDetails";
            this.Text = "customerDetails";
            this.Load += new System.EventHandler(this.customerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox searchByCombobox;
        private Guna.UI2.WinForms.Guna2DataGridView custDetails;
        private Guna.UI2.WinForms.Guna2TextBox searchByTxtbox;
    }
}