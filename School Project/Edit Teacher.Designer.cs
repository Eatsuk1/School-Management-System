
namespace School_Project
{
    partial class Edit_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Teacher));
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.phonenum = new System.Windows.Forms.Label();
            this.phonenumbox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(87, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(73, 20);
            this.name.TabIndex = 16;
            this.name.Text = "Họ và tên";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(197, 97);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(229, 27);
            this.namebox.TabIndex = 17;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gender.Location = new System.Drawing.Point(95, 209);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(65, 20);
            this.gender.TabIndex = 18;
            this.gender.Text = "Giới tính";
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.genderbox.Location = new System.Drawing.Point(197, 206);
            this.genderbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(90, 28);
            this.genderbox.TabIndex = 19;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateofbirth.Location = new System.Drawing.Point(86, 160);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(74, 20);
            this.dateofbirth.TabIndex = 20;
            this.dateofbirth.Text = "Ngày sinh";
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(197, 155);
            this.dateofbirthbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(130, 27);
            this.dateofbirthbox.TabIndex = 21;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(517, 97);
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
            this.clearbutton.Location = new System.Drawing.Point(517, 295);
            this.clearbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(142, 81);
            this.clearbutton.TabIndex = 27;
            this.clearbutton.Text = "Xóa";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenum.Location = new System.Drawing.Point(63, 352);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(97, 20);
            this.phonenum.TabIndex = 31;
            this.phonenum.Text = "Số điện thoại";
            // 
            // phonenumbox
            // 
            this.phonenumbox.Location = new System.Drawing.Point(197, 349);
            this.phonenumbox.Name = "phonenumbox";
            this.phonenumbox.Size = new System.Drawing.Size(130, 27);
            this.phonenumbox.TabIndex = 34;
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(197, 257);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(229, 66);
            this.addressbox.TabIndex = 35;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(105, 260);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(55, 20);
            this.address.TabIndex = 36;
            this.address.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Trạng thái";
            // 
            // statusbox
            // 
            this.statusbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusbox.FormattingEnabled = true;
            this.statusbox.Items.AddRange(new object[] {
            "Đang công tác",
            "Nghỉ phép",
            "Về hưu"});
            this.statusbox.Location = new System.Drawing.Point(197, 406);
            this.statusbox.Name = "statusbox";
            this.statusbox.Size = new System.Drawing.Size(130, 28);
            this.statusbox.TabIndex = 39;
            // 
            // Edit_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 489);
            this.Controls.Add(this.statusbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.phonenumbox);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
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
            this.Name = "Edit_Teacher";
            this.Text = "Cập nhật thông tin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.Label address;
        internal System.Windows.Forms.TextBox namebox;
        internal System.Windows.Forms.ComboBox genderbox;
        internal System.Windows.Forms.DateTimePicker dateofbirthbox;
        internal System.Windows.Forms.TextBox phonenumbox;
        internal System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox statusbox;
    }
}