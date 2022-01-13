
namespace School_Project
{
    partial class Edit_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Staff));
            this.addressbox = new System.Windows.Forms.TextBox();
            this.hometown = new System.Windows.Forms.Label();
            this.hometownbox = new System.Windows.Forms.TextBox();
            this.phonenumbox = new System.Windows.Forms.TextBox();
            this.nationalitybox = new System.Windows.Forms.TextBox();
            this.ethnicbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.Label();
            this.ethnic = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.qualificationbox = new System.Windows.Forms.TextBox();
            this.designationbox = new System.Windows.Forms.ComboBox();
            this.qualification = new System.Windows.Forms.Label();
            this.designation = new System.Windows.Forms.Label();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(511, 207);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(229, 66);
            this.addressbox.TabIndex = 59;
            // 
            // hometown
            // 
            this.hometown.AutoSize = true;
            this.hometown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hometown.Location = new System.Drawing.Point(50, 207);
            this.hometown.Name = "hometown";
            this.hometown.Size = new System.Drawing.Size(73, 20);
            this.hometown.TabIndex = 58;
            this.hometown.Text = "Quê quán";
            // 
            // hometownbox
            // 
            this.hometownbox.Location = new System.Drawing.Point(140, 204);
            this.hometownbox.Multiline = true;
            this.hometownbox.Name = "hometownbox";
            this.hometownbox.Size = new System.Drawing.Size(229, 66);
            this.hometownbox.TabIndex = 57;
            // 
            // phonenumbox
            // 
            this.phonenumbox.Location = new System.Drawing.Point(762, 111);
            this.phonenumbox.Name = "phonenumbox";
            this.phonenumbox.Size = new System.Drawing.Size(130, 23);
            this.phonenumbox.TabIndex = 56;
            // 
            // nationalitybox
            // 
            this.nationalitybox.Location = new System.Drawing.Point(483, 111);
            this.nationalitybox.Name = "nationalitybox";
            this.nationalitybox.Size = new System.Drawing.Size(113, 23);
            this.nationalitybox.TabIndex = 55;
            // 
            // ethnicbox
            // 
            this.ethnicbox.Location = new System.Drawing.Point(140, 111);
            this.ethnicbox.Name = "ethnicbox";
            this.ethnicbox.Size = new System.Drawing.Size(100, 23);
            this.ethnicbox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(659, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Số điện thoại";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(406, 207);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(99, 20);
            this.address.TabIndex = 52;
            this.address.Text = "Nơi ở hiện tại";
            // 
            // nationality
            // 
            this.nationality.AutoSize = true;
            this.nationality.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationality.Location = new System.Drawing.Point(405, 114);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(72, 20);
            this.nationality.TabIndex = 51;
            this.nationality.Text = "Quốc tịch";
            // 
            // ethnic
            // 
            this.ethnic.AutoSize = true;
            this.ethnic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ethnic.Location = new System.Drawing.Point(50, 118);
            this.ethnic.Name = "ethnic";
            this.ethnic.Size = new System.Drawing.Size(61, 20);
            this.ethnic.TabIndex = 50;
            this.ethnic.Text = "Dân tộc";
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearbutton.Location = new System.Drawing.Point(659, 433);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(142, 81);
            this.clearbutton.TabIndex = 49;
            this.clearbutton.Text = "Xóa thay đổi";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(175, 433);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(142, 81);
            this.savebutton.TabIndex = 48;
            this.savebutton.Text = "Lưu thay đổi";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // qualificationbox
            // 
            this.qualificationbox.Location = new System.Drawing.Point(483, 308);
            this.qualificationbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qualificationbox.Multiline = true;
            this.qualificationbox.Name = "qualificationbox";
            this.qualificationbox.Size = new System.Drawing.Size(338, 41);
            this.qualificationbox.TabIndex = 47;
            // 
            // designationbox
            // 
            this.designationbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationbox.FormattingEnabled = true;
            this.designationbox.Items.AddRange(new object[] {
            "Teacher",
            "Librarian",
            "Security",
            "Lao công"});
            this.designationbox.Location = new System.Drawing.Point(140, 308);
            this.designationbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.designationbox.Name = "designationbox";
            this.designationbox.Size = new System.Drawing.Size(145, 23);
            this.designationbox.TabIndex = 46;
            // 
            // qualification
            // 
            this.qualification.AutoSize = true;
            this.qualification.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qualification.Location = new System.Drawing.Point(405, 311);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(71, 20);
            this.qualification.TabIndex = 45;
            this.qualification.Text = "Bằng cấp";
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.designation.Location = new System.Drawing.Point(50, 311);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(61, 20);
            this.designation.TabIndex = 44;
            this.designation.Text = "Chức vụ";
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(497, 33);
            this.dateofbirthbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(116, 23);
            this.dateofbirthbox.TabIndex = 43;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(405, 36);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(74, 20);
            this.dateofbirth.TabIndex = 42;
            this.dateofbirth.Text = "Ngày sinh";
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(731, 37);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(90, 23);
            this.genderbox.TabIndex = 41;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(659, 36);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(65, 20);
            this.gender.TabIndex = 40;
            this.gender.Text = "Giới tính";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(140, 32);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(229, 23);
            this.namebox.TabIndex = 39;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(50, 31);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 20);
            this.name.TabIndex = 38;
            this.name.Text = "Họ và tên";
            // 
            // Edit_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 540);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.hometown);
            this.Controls.Add(this.hometownbox);
            this.Controls.Add(this.phonenumbox);
            this.Controls.Add(this.nationalitybox);
            this.Controls.Add(this.ethnicbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.ethnic);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.qualificationbox);
            this.Controls.Add(this.designationbox);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.dateofbirthbox);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Edit_Staff";
            this.Text = "Cập nhật thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hometown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label nationality;
        private System.Windows.Forms.Label ethnic;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label qualification;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label name;
        internal System.Windows.Forms.TextBox addressbox;
        internal System.Windows.Forms.TextBox hometownbox;
        internal System.Windows.Forms.TextBox phonenumbox;
        internal System.Windows.Forms.TextBox nationalitybox;
        internal System.Windows.Forms.TextBox ethnicbox;
        internal System.Windows.Forms.TextBox qualificationbox;
        internal System.Windows.Forms.ComboBox designationbox;
        internal System.Windows.Forms.DateTimePicker dateofbirthbox;
        internal System.Windows.Forms.ComboBox genderbox;
        internal System.Windows.Forms.TextBox namebox;
    }
}