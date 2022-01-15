
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
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Location = new System.Drawing.Point(379, 29);
            this.searchbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(241, 27);
            this.searchbox.TabIndex = 1;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namecol,
            this.classcol,
            this.agecol,
            this.gendercol,
            this.dateofbirthcol});
            this.dataGridView1.Location = new System.Drawing.Point(14, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(887, 387);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // namecol
            // 
            this.namecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namecol.HeaderText = "Họ và tên";
            this.namecol.MinimumWidth = 6;
            this.namecol.Name = "namecol";
            this.namecol.ReadOnly = true;
            // 
            // classcol
            // 
            this.classcol.HeaderText = "Lớp";
            this.classcol.MinimumWidth = 6;
            this.classcol.Name = "classcol";
            this.classcol.ReadOnly = true;
            this.classcol.Width = 77;
            // 
            // agecol
            // 
            this.agecol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.agecol.HeaderText = "Tuổi";
            this.agecol.MinimumWidth = 6;
            this.agecol.Name = "agecol";
            this.agecol.ReadOnly = true;
            this.agecol.Width = 67;
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
            this.addnewbutton.Location = new System.Drawing.Point(109, 511);
            this.addnewbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addnewbutton.Name = "addnewbutton";
            this.addnewbutton.Size = new System.Drawing.Size(161, 57);
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
            this.deletebutton.Location = new System.Drawing.Point(657, 511);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(118, 57);
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
            this.editbutton.Location = new System.Drawing.Point(402, 511);
            this.editbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(112, 57);
            this.editbutton.TabIndex = 5;
            this.editbutton.Text = "Cập nhật thông tin";
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
            this.searchfilter.Location = new System.Drawing.Point(66, 33);
            this.searchfilter.Name = "searchfilter";
            this.searchfilter.Size = new System.Drawing.Size(145, 20);
            this.searchfilter.TabIndex = 6;
            this.searchfilter.Text = "Tìm kiếm qua bộ lọc";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(657, 29);
            this.searchbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(65, 33);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Enter";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(217, 32);
            this.age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(57, 24);
            this.age.TabIndex = 9;
            this.age.Text = "tuổi";
            this.age.UseVisualStyleBackColor = true;
            this.age.CheckedChanged += new System.EventHandler(this.age_CheckedChanged);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(278, 31);
            this.gender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(86, 24);
            this.gender.TabIndex = 10;
            this.gender.Text = "giới tính";
            this.gender.UseVisualStyleBackColor = true;
            this.gender.CheckedChanged += new System.EventHandler(this.gender_CheckedChanged);
            // 
            // Mngstudent
            // 
            this.AcceptButton = this.searchbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchfilter);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addnewbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mngstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn classcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn agecol;
        private System.Windows.Forms.DataGridViewTextBoxColumn gendercol;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofbirthcol;
        private System.Windows.Forms.CheckBox age;
        private System.Windows.Forms.CheckBox gender;
    }
}