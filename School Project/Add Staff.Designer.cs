
namespace School_Project
{
    partial class Add_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Staff));
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.qualification = new System.Windows.Forms.Label();
            this.qualificationbox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.phonenumbox = new System.Windows.Forms.TextBox();
            this.hometownbox = new System.Windows.Forms.TextBox();
            this.hometown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(87, 104);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(92, 25);
            this.name.TabIndex = 16;
            this.name.Text = "Họ và tên";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(197, 97);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(229, 32);
            this.namebox.TabIndex = 17;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(87, 209);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(84, 25);
            this.gender.TabIndex = 18;
            this.gender.Text = "Giới tính";
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(197, 206);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(90, 33);
            this.genderbox.TabIndex = 19;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(83, 161);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(96, 25);
            this.dateofbirth.TabIndex = 20;
            this.dateofbirth.Text = "Ngày sinh";
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(197, 155);
            this.dateofbirthbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(116, 32);
            this.dateofbirthbox.TabIndex = 21;
            // 
            // qualification
            // 
            this.qualification.AutoSize = true;
            this.qualification.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qualification.Location = new System.Drawing.Point(87, 414);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(75, 25);
            this.qualification.TabIndex = 23;
            this.qualification.Text = "Mã Lớp";
            // 
            // qualificationbox
            // 
            this.qualificationbox.Location = new System.Drawing.Point(197, 411);
            this.qualificationbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.qualificationbox.Multiline = true;
            this.qualificationbox.Name = "qualificationbox";
            this.qualificationbox.Size = new System.Drawing.Size(189, 38);
            this.qualificationbox.TabIndex = 25;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(517, 133);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(142, 81);
            this.savebutton.TabIndex = 26;
            this.savebutton.Text = "Lưu";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(517, 349);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(142, 81);
            this.clearbutton.TabIndex = 27;
            this.clearbutton.Text = "Xóa";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(68, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Số điện thoại";
            // 
            // phonenumbox
            // 
            this.phonenumbox.Location = new System.Drawing.Point(197, 349);
            this.phonenumbox.Name = "phonenumbox";
            this.phonenumbox.Size = new System.Drawing.Size(130, 32);
            this.phonenumbox.TabIndex = 34;
            // 
            // hometownbox
            // 
            this.hometownbox.Location = new System.Drawing.Point(197, 257);
            this.hometownbox.Multiline = true;
            this.hometownbox.Name = "hometownbox";
            this.hometownbox.Size = new System.Drawing.Size(229, 66);
            this.hometownbox.TabIndex = 35;
            // 
            // hometown
            // 
            this.hometown.AutoSize = true;
            this.hometown.Location = new System.Drawing.Point(87, 260);
            this.hometown.Name = "hometown";
            this.hometown.Size = new System.Drawing.Size(70, 25);
            this.hometown.TabIndex = 36;
            this.hometown.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 32);
            this.textBox1.TabIndex = 39;
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 561);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hometown);
            this.Controls.Add(this.hometownbox);
            this.Controls.Add(this.phonenumbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.qualificationbox);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.dateofbirthbox);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Add_Staff";
            this.Text = "Thêm giáo viên mới";
            this.Load += new System.EventHandler(this.Add_Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.DateTimePicker dateofbirthbox;
        private System.Windows.Forms.Label qualification;
        private System.Windows.Forms.TextBox qualificationbox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phonenumbox;
        private System.Windows.Forms.TextBox hometownbox;
        private System.Windows.Forms.Label hometown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}