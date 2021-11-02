
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addnewbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.searchfilter = new System.Windows.Forms.Label();
            this.filterbox = new System.Windows.Forms.ComboBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Enabled = false;
            this.searchbox.Location = new System.Drawing.Point(308, 22);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(211, 23);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
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
            this.name,
            this.Class,
            this.age,
            this.gender,
            this.dateofbirth});
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // addnewbutton
            // 
            this.addnewbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addnewbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addnewbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addnewbutton.Location = new System.Drawing.Point(95, 383);
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
            this.deletebutton.Location = new System.Drawing.Point(575, 383);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(103, 43);
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
            this.editbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editbutton.Location = new System.Drawing.Point(352, 383);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(98, 43);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Chỉnh sửa thông tin";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // searchfilter
            // 
            this.searchfilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfilter.AutoSize = true;
            this.searchfilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchfilter.Location = new System.Drawing.Point(69, 27);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(115, 15);
            this.searchfilter.TabIndex = 6;
            this.searchfilter.Text = "Tìm kiếm qua bộ lọc";
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
            "Họ tên",
            "Lớp",
            "Tuổi",
            "Giới tính",
            "Dân tộc"});
            this.filterbox.Location = new System.Drawing.Point(190, 22);
            this.filterbox.Name = "filterbox";
            this.filterbox.Size = new System.Drawing.Size(100, 23);
            this.filterbox.TabIndex = 7;
            this.filterbox.SelectedIndexChanged += new System.EventHandler(this.filterbox_SelectedIndexChanged);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(536, 22);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(57, 25);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Enter";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Họ và tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 77;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.HeaderText = "Tuổi";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 55;
            // 
            // gender
            // 
            this.gender.HeaderText = "Giới tính";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 80;
            // 
            // dateofbirth
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            dataGridViewCellStyle1.NullValue = null;
            this.dateofbirth.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateofbirth.HeaderText = "Ngày sinh";
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.ReadOnly = true;
            this.dateofbirth.Width = 120;
            // 
            // Mngstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.filterbox);
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mngstudent";
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.Mngstudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addnewbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Label searchfilter;
        private System.Windows.Forms.ComboBox filterbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirth;
    }
}