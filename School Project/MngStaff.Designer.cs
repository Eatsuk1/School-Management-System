
namespace School_Project
{
    partial class MngStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngStaff));
            this.searchbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchfilter = new System.Windows.Forms.Label();
            this.filterbox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Enabled = false;
            this.searchbox.Location = new System.Drawing.Point(257, 30);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(211, 23);
            this.searchbox.TabIndex = 2;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(474, 30);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(57, 25);
            this.searchbutton.TabIndex = 9;
            this.searchbutton.Text = "Enter";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchfilter
            // 
            this.searchfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfilter.AutoSize = true;
            this.searchfilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchfilter.Location = new System.Drawing.Point(58, 35);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(87, 15);
            this.searchfilter.TabIndex = 10;
            this.searchfilter.Text = "Search by Filter";
            // 
            // filterbox
            // 
            this.filterbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterbox.FormattingEnabled = true;
            this.filterbox.Items.AddRange(new object[] {
            "",
            "ID",
            "Name",
            "Date of Birth",
            "Gender",
            "Designation",
            "Qualification"});
            this.filterbox.Location = new System.Drawing.Point(151, 30);
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(100, 23);
            this.filterbox.TabIndex = 11;
            this.filterbox.SelectedIndexChanged += new System.EventHandler(this.filterbox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dateofbirth,
            this.gender,
            this.Designation,
            this.Qualification});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dateofbirth.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateofbirth.HeaderText = "Date of Birth";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            this.dateofbirth.Width = 98;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 70;
            // 
            // Designation
            // 
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.ReadOnly = true;
            // 
            // Qualification
            // 
            this.Qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            this.Qualification.ReadOnly = true;
            // 
            // addnewbutton
            // 
            this.addnewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addnewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnewbutton.Location = new System.Drawing.Point(85, 386);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(113, 43);
            this.addnewbutton.TabIndex = 13;
            this.addnewbutton.Text = "Add new staff";
            this.addnewbutton.UseVisualStyleBackColor = true;
            this.addnewbutton.Click += new System.EventHandler(this.addnewbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editbutton.Location = new System.Drawing.Point(345, 386);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(98, 43);
            this.editbutton.TabIndex = 14;
            this.editbutton.Text = "Edit Staff";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.Location = new System.Drawing.Point(604, 386);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(103, 43);
            this.deletebutton.TabIndex = 15;
            this.deletebutton.Text = "Delete Staff";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // MngStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MngStaff";
            this.Text = "Manage Staff";
            this.Load += new System.EventHandler(this.MngStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label searchfilter;
        private System.Windows.Forms.ComboBox filterbox;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}