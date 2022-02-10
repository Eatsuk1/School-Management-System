
namespace School_Project
{
    partial class Mngstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mngstudent));
            this.namebox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendercol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.searchfilter = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.CheckBox();
            this.gender = new System.Windows.Forms.CheckBox();
            this.name = new System.Windows.Forms.CheckBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.agenumeric = new System.Windows.Forms.NumericUpDown();
            this.resetbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namebox.Enabled = false;
            this.namebox.Location = new System.Drawing.Point(507, 11);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(211, 23);
            this.namebox.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcol,
            this.namecol,
            this.agecol,
            this.gendercol,
            this.dateofbirthcol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 2;
            // 
            // idcol
            // 
            this.idcol.HeaderText = "ID";
            this.idcol.Name = "idcol";
            this.idcol.ReadOnly = true;
            this.idcol.Width = 70;
            // 
            // namecol
            // 
            this.namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namecol.HeaderText = "Họ và tên";
            this.namecol.MinimumWidth = 6;
            this.namecol.Name = "namecol";
            this.namecol.ReadOnly = true;
            // 
            // agecol
            // 
            this.agecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agecol.HeaderText = "Tuổi";
            this.agecol.MinimumWidth = 6;
            this.agecol.Name = "agecol";
            this.agecol.ReadOnly = true;
            this.agecol.Width = 55;
            // 
            // gendercol
            // 
            this.gendercol.HeaderText = "Giới tính";
            this.gendercol.MinimumWidth = 6;
            this.gendercol.Name = "gendercol";
            this.gendercol.ReadOnly = true;
            this.gendercol.Width = 80;
            // 
            // dateofbirthcol
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dateofbirthcol.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateofbirthcol.HeaderText = "Ngày sinh";
            this.dateofbirthcol.MinimumWidth = 6;
            this.dateofbirthcol.Name = "dateofbirthcol";
            this.dateofbirthcol.ReadOnly = true;
            this.dateofbirthcol.Width = 120;
            // 
            // addnewbutton
            // 
            this.addnewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addnewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnewbutton.Location = new System.Drawing.Point(67, 383);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(141, 43);
            this.addnewbutton.TabIndex = 3;
            this.addnewbutton.Text = "Thêm học sinh mới";
            this.addnewbutton.UseVisualStyleBackColor = true;
            this.addnewbutton.Click += new System.EventHandler(this.addnewbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deletebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton.Location = new System.Drawing.Point(588, 383);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(141, 43);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "Xóa học sinh";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.editbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editbutton.Location = new System.Drawing.Point(331, 383);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(141, 43);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Cập nhật thông tin";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // searchfilter
            // 
            this.searchfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfilter.AutoSize = true;
            this.searchfilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchfilter.Location = new System.Drawing.Point(12, 14);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(118, 15);
            this.searchfilter.TabIndex = 6;
            this.searchfilter.Text = "Tìm kiếm qua bộ lọc:";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(732, 9);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(57, 25);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Enter";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(150, 13);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(47, 19);
            this.age.TabIndex = 9;
            this.age.Text = "tuổi";
            this.age.UseVisualStyleBackColor = true;
            this.age.CheckStateChanged += new System.EventHandler(this.age_CheckStateChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(271, 13);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(70, 19);
            this.gender.TabIndex = 10;
            this.gender.Text = "giới tính";
            this.gender.UseVisualStyleBackColor = true;
            this.gender.CheckStateChanged += new System.EventHandler(this.gender_CheckStateChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(438, 14);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 19);
            this.name.TabIndex = 12;
            this.name.Text = "họ tên";
            this.name.UseVisualStyleBackColor = true;
            this.name.CheckStateChanged += new System.EventHandler(this.name_CheckStateChanged);
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.Enabled = false;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.genderbox.Location = new System.Drawing.Point(352, 11);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(64, 23);
            this.genderbox.TabIndex = 13;
            // 
            // agenumeric
            // 
            this.agenumeric.Enabled = false;
            this.agenumeric.Location = new System.Drawing.Point(206, 12);
            this.agenumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agenumeric.Name = "agenumeric";
            this.agenumeric.Size = new System.Drawing.Size(38, 23);
            this.agenumeric.TabIndex = 14;
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(12, 45);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(82, 22);
            this.resetbutton.TabIndex = 15;
            this.resetbutton.Text = "Làm mới";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // Mngstudent
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.agenumeric);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.namebox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mngstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý học sinh";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label searchfilter;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.CheckBox age;
        private System.Windows.Forms.CheckBox gender;
        private System.Windows.Forms.CheckBox name;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.NumericUpDown agenumeric;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn agecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthcol;
    }
}