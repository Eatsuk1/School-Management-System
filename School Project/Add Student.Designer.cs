
namespace School_Project
{
    partial class Add_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student));
            this.namebox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.classroom = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.classbox = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.TextBox();
            this.ethnic = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.Label();
            this.placeofbirth = new System.Windows.Forms.Label();
            this.hometown = new System.Windows.Forms.Label();
            this.homeaddess = new System.Windows.Forms.Label();
            this.dadname = new System.Windows.Forms.Label();
            this.momname = new System.Windows.Forms.Label();
            this.guardianname = new System.Windows.Forms.Label();
            this.ethnicbox = new System.Windows.Forms.TextBox();
            this.nationalitybox = new System.Windows.Forms.TextBox();
            this.hometownbox = new System.Windows.Forms.TextBox();
            this.placeofbirthbox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.momnamebox = new System.Windows.Forms.TextBox();
            this.dadnamebox = new System.Windows.Forms.TextBox();
            this.guardiannamebox = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.heightbox = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(129, 48);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(187, 23);
            this.namebox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(50, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 20);
            this.name.TabIndex = 1;
            this.name.Text = "Họ và tên";
            // 
            // classroom
            // 
            this.classroom.AutoSize = true;
            this.classroom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classroom.Location = new System.Drawing.Point(892, 51);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(34, 20);
            this.classroom.TabIndex = 2;
            this.classroom.Text = "Lớp";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(347, 51);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(65, 20);
            this.gender.TabIndex = 3;
            this.gender.Text = "Giới tính";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(526, 51);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(74, 20);
            this.dateofbirth.TabIndex = 4;
            this.dateofbirth.Text = "Ngày sinh";
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.genderbox.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.genderbox.Location = new System.Drawing.Point(425, 48);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(64, 23);
            this.genderbox.TabIndex = 6;
            this.genderbox.SelectedIndexChanged += new System.EventHandler(this.genderbox_SelectedIndexChanged);
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(606, 48);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(102, 23);
            this.dateofbirthbox.TabIndex = 7;
            this.dateofbirthbox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(283, 365);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(141, 63);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Lưu thay đổi";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearbutton.Location = new System.Drawing.Point(668, 365);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(141, 63);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Xóa thay đổi";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(932, 50);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(67, 23);
            this.classbox.TabIndex = 10;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(744, 50);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(38, 20);
            this.age.TabIndex = 11;
            this.age.Text = "Tuổi";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(788, 48);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(45, 23);
            this.agebox.TabIndex = 12;
            // 
            // ethnic
            // 
            this.ethnic.AutoSize = true;
            this.ethnic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ethnic.Location = new System.Drawing.Point(50, 120);
            this.ethnic.Name = "ethnic";
            this.ethnic.Size = new System.Drawing.Size(61, 20);
            this.ethnic.TabIndex = 13;
            this.ethnic.Text = "Dân tộc";
            // 
            // nationality
            // 
            this.nationality.AutoSize = true;
            this.nationality.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationality.Location = new System.Drawing.Point(347, 120);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(72, 20);
            this.nationality.TabIndex = 14;
            this.nationality.Text = "Quốc tịch";
            // 
            // placeofbirth
            // 
            this.placeofbirth.AutoSize = true;
            this.placeofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeofbirth.Location = new System.Drawing.Point(48, 208);
            this.placeofbirth.Name = "placeofbirth";
            this.placeofbirth.Size = new System.Drawing.Size(63, 20);
            this.placeofbirth.TabIndex = 15;
            this.placeofbirth.Text = "Nơi sinh";
            this.placeofbirth.Click += new System.EventHandler(this.placeofbirth_Click);
            // 
            // hometown
            // 
            this.hometown.AutoSize = true;
            this.hometown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hometown.Location = new System.Drawing.Point(347, 208);
            this.hometown.Name = "hometown";
            this.hometown.Size = new System.Drawing.Size(73, 20);
            this.hometown.TabIndex = 16;
            this.hometown.Text = "Quê quán";
            // 
            // homeaddess
            // 
            this.homeaddess.AutoSize = true;
            this.homeaddess.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeaddess.Location = new System.Drawing.Point(709, 208);
            this.homeaddess.Name = "homeaddess";
            this.homeaddess.Size = new System.Drawing.Size(99, 20);
            this.homeaddess.TabIndex = 17;
            this.homeaddess.Text = "Nơi ở hiện tại";
            // 
            // dadname
            // 
            this.dadname.AutoSize = true;
            this.dadname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dadname.Location = new System.Drawing.Point(382, 298);
            this.dadname.Name = "dadname";
            this.dadname.Size = new System.Drawing.Size(95, 20);
            this.dadname.TabIndex = 18;
            this.dadname.Text = "Họ và tên bố";
            // 
            // momname
            // 
            this.momname.AutoSize = true;
            this.momname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.momname.Location = new System.Drawing.Point(50, 298);
            this.momname.Name = "momname";
            this.momname.Size = new System.Drawing.Size(98, 20);
            this.momname.TabIndex = 19;
            this.momname.Text = "Họ và tên mẹ";
            // 
            // guardianname
            // 
            this.guardianname.AutoSize = true;
            this.guardianname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guardianname.Location = new System.Drawing.Point(709, 298);
            this.guardianname.Name = "guardianname";
            this.guardianname.Size = new System.Drawing.Size(168, 20);
            this.guardianname.TabIndex = 20;
            this.guardianname.Text = "Người giám hộ (nếu có)";
            // 
            // ethnicbox
            // 
            this.ethnicbox.Location = new System.Drawing.Point(129, 117);
            this.ethnicbox.Name = "ethnicbox";
            this.ethnicbox.Size = new System.Drawing.Size(90, 23);
            this.ethnicbox.TabIndex = 21;
            this.ethnicbox.TextChanged += new System.EventHandler(this.ethnicbox_TextChanged);
            // 
            // nationalitybox
            // 
            this.nationalitybox.Location = new System.Drawing.Point(437, 116);
            this.nationalitybox.Name = "nationalitybox";
            this.nationalitybox.Size = new System.Drawing.Size(119, 23);
            this.nationalitybox.TabIndex = 22;
            // 
            // hometownbox
            // 
            this.hometownbox.Location = new System.Drawing.Point(826, 196);
            this.hometownbox.Multiline = true;
            this.hometownbox.Name = "hometownbox";
            this.hometownbox.Size = new System.Drawing.Size(240, 46);
            this.hometownbox.TabIndex = 23;
            this.hometownbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // placeofbirthbox
            // 
            this.placeofbirthbox.Location = new System.Drawing.Point(129, 196);
            this.placeofbirthbox.Multiline = true;
            this.placeofbirthbox.Name = "placeofbirthbox";
            this.placeofbirthbox.Size = new System.Drawing.Size(187, 46);
            this.placeofbirthbox.TabIndex = 24;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(437, 196);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(224, 46);
            this.addressbox.TabIndex = 25;
            // 
            // momnamebox
            // 
            this.momnamebox.Location = new System.Drawing.Point(155, 295);
            this.momnamebox.Name = "momnamebox";
            this.momnamebox.Size = new System.Drawing.Size(161, 23);
            this.momnamebox.TabIndex = 26;
            // 
            // dadnamebox
            // 
            this.dadnamebox.Location = new System.Drawing.Point(494, 295);
            this.dadnamebox.Name = "dadnamebox";
            this.dadnamebox.Size = new System.Drawing.Size(167, 23);
            this.dadnamebox.TabIndex = 27;
            // 
            // guardiannamebox
            // 
            this.guardiannamebox.Location = new System.Drawing.Point(892, 299);
            this.guardiannamebox.Name = "guardiannamebox";
            this.guardiannamebox.Size = new System.Drawing.Size(174, 23);
            this.guardiannamebox.TabIndex = 28;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height.Location = new System.Drawing.Point(708, 117);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(74, 20);
            this.height.TabIndex = 29;
            this.height.Text = "Chiều cao";
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(788, 117);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(76, 23);
            this.heightbox.TabIndex = 30;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight.Location = new System.Drawing.Point(892, 116);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(71, 20);
            this.weight.TabIndex = 31;
            this.weight.Text = "Cân nặng";
            // 
            // weightbox
            // 
            this.weightbox.Location = new System.Drawing.Point(969, 117);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(68, 23);
            this.weightbox.TabIndex = 32;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 449);
            this.Controls.Add(this.weightbox);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.heightbox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.guardiannamebox);
            this.Controls.Add(this.dadnamebox);
            this.Controls.Add(this.momnamebox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.placeofbirthbox);
            this.Controls.Add(this.hometownbox);
            this.Controls.Add(this.nationalitybox);
            this.Controls.Add(this.ethnicbox);
            this.Controls.Add(this.guardianname);
            this.Controls.Add(this.momname);
            this.Controls.Add(this.dadname);
            this.Controls.Add(this.homeaddess);
            this.Controls.Add(this.hometown);
            this.Controls.Add(this.placeofbirth);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.ethnic);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.dateofbirthbox);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.classroom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.namebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm học sinh mới";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label classroom;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.DateTimePicker dateofbirthbox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.TextBox classbox;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox agebox;
        private System.Windows.Forms.Label ethnic;
        private System.Windows.Forms.Label nationality;
        private System.Windows.Forms.Label placeofbirth;
        private System.Windows.Forms.Label hometown;
        private System.Windows.Forms.Label homeaddess;
        private System.Windows.Forms.Label dadname;
        private System.Windows.Forms.Label momname;
        private System.Windows.Forms.Label guardianname;
        private System.Windows.Forms.TextBox ethnicbox;
        private System.Windows.Forms.TextBox nationalitybox;
        private System.Windows.Forms.TextBox hometownbox;
        private System.Windows.Forms.TextBox placeofbirthbox;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.TextBox momnamebox;
        private System.Windows.Forms.TextBox dadnamebox;
        private System.Windows.Forms.TextBox guardiannamebox;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.TextBox heightbox;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.TextBox weightbox;
    }
}