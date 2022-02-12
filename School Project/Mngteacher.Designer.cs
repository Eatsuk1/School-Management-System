
namespace School_Project
{
    partial class Mngteacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mngteacher));
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchfilter = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirthcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gendercol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumbercol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaicol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.CheckBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.CheckBox();
            this.namebox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(664, 11);
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
            this.searchfilter.Location = new System.Drawing.Point(12, 16);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(118, 15);
            this.searchfilter.TabIndex = 10;
            this.searchfilter.Text = "Tìm kiếm qua bộ lọc:";
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
            this.ID,
            this.namecol,
            this.dateofbirthcol,
            this.gendercol,
            this.phonenumbercol,
            this.trangthaicol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 70;
            // 
            // namecol
            // 
            this.namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namecol.HeaderText = "Họ tên";
            this.namecol.MinimumWidth = 6;
            this.namecol.Name = "namecol";
            this.namecol.ReadOnly = true;
            // 
            // dateofbirthcol
            // 
            this.dateofbirthcol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dateofbirthcol.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateofbirthcol.HeaderText = "Ngày sinh";
            this.dateofbirthcol.MinimumWidth = 6;
            this.dateofbirthcol.Name = "dateofbirthcol";
            this.dateofbirthcol.ReadOnly = true;
            this.dateofbirthcol.Width = 85;
            // 
            // gendercol
            // 
            this.gendercol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gendercol.HeaderText = "Giới tính";
            this.gendercol.MinimumWidth = 6;
            this.gendercol.Name = "gendercol";
            this.gendercol.ReadOnly = true;
            this.gendercol.Width = 77;
            // 
            // phonenumbercol
            // 
            this.phonenumbercol.HeaderText = "Số điện thoại";
            this.phonenumbercol.MinimumWidth = 6;
            this.phonenumbercol.Name = "phonenumbercol";
            this.phonenumbercol.ReadOnly = true;
            this.phonenumbercol.Width = 120;
            // 
            // trangthaicol
            // 
            this.trangthaicol.HeaderText = "Trạng thái";
            this.trangthaicol.Name = "trangthaicol";
            this.trangthaicol.Width = 120;
            // 
            // addnewbutton
            // 
            this.addnewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addnewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnewbutton.Location = new System.Drawing.Point(74, 386);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(141, 43);
            this.addnewbutton.TabIndex = 13;
            this.addnewbutton.Text = "Thêm giáo viên mới";
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
            this.editbutton.Location = new System.Drawing.Point(327, 386);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(141, 43);
            this.editbutton.TabIndex = 14;
            this.editbutton.Text = "Cập nhật thông tin";
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
            this.deletebutton.Location = new System.Drawing.Point(592, 386);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(141, 43);
            this.deletebutton.TabIndex = 15;
            this.deletebutton.Text = "Xóa giáo viên";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(12, 52);
            this.resetbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(82, 22);
            this.resetbutton.TabIndex = 16;
            this.resetbutton.Text = "Làm mới";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(164, 15);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(70, 19);
            this.gender.TabIndex = 17;
            this.gender.Text = "giới tính";
            this.gender.UseVisualStyleBackColor = true;
            this.gender.CheckStateChanged += new System.EventHandler(this.gender_CheckStateChanged);
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.Enabled = false;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.genderbox.Location = new System.Drawing.Point(244, 14);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(64, 23);
            this.genderbox.TabIndex = 18;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(365, 15);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(60, 19);
            this.name.TabIndex = 19;
            this.name.Text = "họ tên";
            this.name.UseVisualStyleBackColor = true;
            this.name.CheckStateChanged += new System.EventHandler(this.name_CheckStateChanged);
            // 
            // namebox
            // 
            this.namebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.namebox.Enabled = false;
            this.namebox.Location = new System.Drawing.Point(434, 14);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(211, 23);
            this.namebox.TabIndex = 20;
            // 
            // Mngteacher
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.searchbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mngteacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giáo viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label searchfilter;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.CheckBox gender;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.CheckBox name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumbercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaicol;
    }
}