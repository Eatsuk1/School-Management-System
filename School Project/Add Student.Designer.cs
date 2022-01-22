
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
            this.malop = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.Label();
            this.agebox = new System.Windows.Forms.TextBox();
            this.ethnic = new System.Windows.Forms.Label();
            this.nationality = new System.Windows.Forms.Label();
            this.placeofbirth = new System.Windows.Forms.Label();
            this.hometown = new System.Windows.Forms.Label();
            this.dadname = new System.Windows.Forms.Label();
            this.momname = new System.Windows.Forms.Label();
            this.mahocsinh = new System.Windows.Forms.Label();
            this.ethnicbox = new System.Windows.Forms.TextBox();
            this.nationalitybox = new System.Windows.Forms.TextBox();
            this.placeofbirthbox = new System.Windows.Forms.TextBox();
            this.hometownbox = new System.Windows.Forms.TextBox();
            this.momnamebox = new System.Windows.Forms.TextBox();
            this.dadnamebox = new System.Windows.Forms.TextBox();
            this.idstudentbox = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.Label();
            this.heightbox = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.Label();
            this.weightbox = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.Label();
            this.phonenumbox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.classbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(421, 61);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(213, 27);
            this.namebox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(323, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(92, 25);
            this.name.TabIndex = 1;
            this.name.Text = "Họ và tên";
            // 
            // malop
            // 
            this.malop.AutoSize = true;
            this.malop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.malop.Location = new System.Drawing.Point(1117, 64);
            this.malop.Name = "malop";
            this.malop.Size = new System.Drawing.Size(75, 25);
            this.malop.TabIndex = 2;
            this.malop.Text = "Mã Lớp";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(323, 152);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(84, 25);
            this.gender.TabIndex = 3;
            this.gender.Text = "Giới tính";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(700, 63);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(96, 25);
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
            "Nu"});
            this.genderbox.Location = new System.Drawing.Point(421, 155);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(73, 28);
            this.genderbox.TabIndex = 6;
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(802, 62);
            this.dateofbirthbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(116, 27);
            this.dateofbirthbox.TabIndex = 7;
            this.dateofbirthbox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.savebutton.Location = new System.Drawing.Point(323, 487);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(161, 84);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Lưu thay đổi";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearbutton.Location = new System.Drawing.Point(763, 487);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(161, 84);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Xóa thay đổi";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(962, 64);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(49, 25);
            this.age.TabIndex = 11;
            this.age.Text = "Tuổi";
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(1017, 61);
            this.agebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(51, 27);
            this.agebox.TabIndex = 12;
            // 
            // ethnic
            // 
            this.ethnic.AutoSize = true;
            this.ethnic.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ethnic.Location = new System.Drawing.Point(55, 154);
            this.ethnic.Name = "ethnic";
            this.ethnic.Size = new System.Drawing.Size(77, 25);
            this.ethnic.TabIndex = 13;
            this.ethnic.Text = "Dân tộc";
            // 
            // nationality
            // 
            this.nationality.AutoSize = true;
            this.nationality.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nationality.Location = new System.Drawing.Point(546, 154);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(93, 25);
            this.nationality.TabIndex = 14;
            this.nationality.Text = "Quốc tịch";
            // 
            // placeofbirth
            // 
            this.placeofbirth.AutoSize = true;
            this.placeofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placeofbirth.Location = new System.Drawing.Point(57, 260);
            this.placeofbirth.Name = "placeofbirth";
            this.placeofbirth.Size = new System.Drawing.Size(82, 25);
            this.placeofbirth.TabIndex = 15;
            this.placeofbirth.Text = "Nơi sinh";
            // 
            // hometown
            // 
            this.hometown.AutoSize = true;
            this.hometown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hometown.Location = new System.Drawing.Point(421, 260);
            this.hometown.Name = "hometown";
            this.hometown.Size = new System.Drawing.Size(95, 25);
            this.hometown.TabIndex = 16;
            this.hometown.Text = "Quê quán";
            // 
            // dadname
            // 
            this.dadname.AutoSize = true;
            this.dadname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dadname.Location = new System.Drawing.Point(421, 376);
            this.dadname.Name = "dadname";
            this.dadname.Size = new System.Drawing.Size(119, 25);
            this.dadname.TabIndex = 18;
            this.dadname.Text = "Họ và tên bố";
            // 
            // momname
            // 
            this.momname.AutoSize = true;
            this.momname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.momname.Location = new System.Drawing.Point(55, 376);
            this.momname.Name = "momname";
            this.momname.Size = new System.Drawing.Size(123, 25);
            this.momname.TabIndex = 19;
            this.momname.Text = "Họ và tên mẹ";
            // 
            // mahocsinh
            // 
            this.mahocsinh.AutoSize = true;
            this.mahocsinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mahocsinh.Location = new System.Drawing.Point(55, 63);
            this.mahocsinh.Name = "mahocsinh";
            this.mahocsinh.Size = new System.Drawing.Size(115, 25);
            this.mahocsinh.TabIndex = 20;
            this.mahocsinh.Text = "Mã học sinh";
            // 
            // ethnicbox
            // 
            this.ethnicbox.Location = new System.Drawing.Point(138, 153);
            this.ethnicbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ethnicbox.Name = "ethnicbox";
            this.ethnicbox.Size = new System.Drawing.Size(102, 27);
            this.ethnicbox.TabIndex = 21;
            // 
            // nationalitybox
            // 
            this.nationalitybox.Location = new System.Drawing.Point(645, 155);
            this.nationalitybox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nationalitybox.Name = "nationalitybox";
            this.nationalitybox.Size = new System.Drawing.Size(135, 27);
            this.nationalitybox.TabIndex = 22;
            // 
            // placeofbirthbox
            // 
            this.placeofbirthbox.Location = new System.Drawing.Point(145, 242);
            this.placeofbirthbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.placeofbirthbox.Multiline = true;
            this.placeofbirthbox.Name = "placeofbirthbox";
            this.placeofbirthbox.Size = new System.Drawing.Size(213, 60);
            this.placeofbirthbox.TabIndex = 24;
            // 
            // hometownbox
            // 
            this.hometownbox.Location = new System.Drawing.Point(522, 242);
            this.hometownbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hometownbox.Multiline = true;
            this.hometownbox.Name = "hometownbox";
            this.hometownbox.Size = new System.Drawing.Size(255, 60);
            this.hometownbox.TabIndex = 25;
            // 
            // momnamebox
            // 
            this.momnamebox.Location = new System.Drawing.Point(184, 374);
            this.momnamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.momnamebox.Name = "momnamebox";
            this.momnamebox.Size = new System.Drawing.Size(183, 27);
            this.momnamebox.TabIndex = 26;
            // 
            // dadnamebox
            // 
            this.dadnamebox.Location = new System.Drawing.Point(546, 374);
            this.dadnamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dadnamebox.Name = "dadnamebox";
            this.dadnamebox.Size = new System.Drawing.Size(190, 27);
            this.dadnamebox.TabIndex = 27;
            // 
            // idstudentbox
            // 
            this.idstudentbox.Location = new System.Drawing.Point(176, 61);
            this.idstudentbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idstudentbox.Name = "idstudentbox";
            this.idstudentbox.Size = new System.Drawing.Size(104, 27);
            this.idstudentbox.TabIndex = 28;
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height.Location = new System.Drawing.Point(822, 154);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(96, 25);
            this.height.TabIndex = 29;
            this.height.Text = "Chiều cao";
            // 
            // heightbox
            // 
            this.heightbox.Location = new System.Drawing.Point(924, 155);
            this.heightbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.heightbox.Name = "heightbox";
            this.heightbox.Size = new System.Drawing.Size(86, 27);
            this.heightbox.TabIndex = 30;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weight.Location = new System.Drawing.Point(1054, 154);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(93, 25);
            this.weight.TabIndex = 31;
            this.weight.Text = "Cân nặng";
            // 
            // weightbox
            // 
            this.weightbox.Location = new System.Drawing.Point(1153, 155);
            this.weightbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.weightbox.Name = "weightbox";
            this.weightbox.Size = new System.Drawing.Size(77, 27);
            this.weightbox.TabIndex = 32;
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenum.Location = new System.Drawing.Point(802, 373);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(123, 25);
            this.phonenum.TabIndex = 33;
            this.phonenum.Text = "Số điện thoại";
            // 
            // phonenumbox
            // 
            this.phonenumbox.Location = new System.Drawing.Point(931, 371);
            this.phonenumbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phonenumbox.Name = "phonenumbox";
            this.phonenumbox.Size = new System.Drawing.Size(190, 27);
            this.phonenumbox.TabIndex = 34;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(830, 260);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(70, 25);
            this.address.TabIndex = 35;
            this.address.Text = "Địa chỉ";
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(906, 242);
            this.addressbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(255, 60);
            this.addressbox.TabIndex = 36;
            // 
            // classbox
            // 
            this.classbox.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.classbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classbox.FormattingEnabled = true;
            this.classbox.Items.AddRange(new object[] {
            "3A"});
            this.classbox.Location = new System.Drawing.Point(1198, 63);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(76, 28);
            this.classbox.TabIndex = 37;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 599);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phonenumbox);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.weightbox);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.heightbox);
            this.Controls.Add(this.height);
            this.Controls.Add(this.idstudentbox);
            this.Controls.Add(this.dadnamebox);
            this.Controls.Add(this.momnamebox);
            this.Controls.Add(this.hometownbox);
            this.Controls.Add(this.placeofbirthbox);
            this.Controls.Add(this.nationalitybox);
            this.Controls.Add(this.ethnicbox);
            this.Controls.Add(this.mahocsinh);
            this.Controls.Add(this.momname);
            this.Controls.Add(this.dadname);
            this.Controls.Add(this.hometown);
            this.Controls.Add(this.placeofbirth);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.ethnic);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.age);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.dateofbirthbox);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.malop);
            this.Controls.Add(this.name);
            this.Controls.Add(this.namebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Add_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm học sinh mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label malop;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label ethnic;
        private System.Windows.Forms.Label nationality;
        private System.Windows.Forms.Label placeofbirth;
        private System.Windows.Forms.Label hometown;
        private System.Windows.Forms.Label dadname;
        private System.Windows.Forms.Label momname;
        private System.Windows.Forms.Label mahocsinh;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.Label address;
        internal System.Windows.Forms.TextBox namebox;
        internal System.Windows.Forms.DateTimePicker dateofbirthbox;
        internal System.Windows.Forms.TextBox agebox;
        internal System.Windows.Forms.TextBox ethnicbox;
        internal System.Windows.Forms.TextBox nationalitybox;
        internal System.Windows.Forms.TextBox placeofbirthbox;
        internal System.Windows.Forms.TextBox hometownbox;
        internal System.Windows.Forms.TextBox momnamebox;
        internal System.Windows.Forms.TextBox dadnamebox;
        internal System.Windows.Forms.TextBox idstudentbox;
        internal System.Windows.Forms.TextBox heightbox;
        internal System.Windows.Forms.TextBox weightbox;
        internal System.Windows.Forms.TextBox phonenumbox;
        internal System.Windows.Forms.TextBox addressbox;
        internal System.Windows.Forms.ComboBox genderbox;
        internal System.Windows.Forms.ComboBox classbox;
    }
}