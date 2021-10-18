
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
            this.id = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(112, 85);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(187, 23);
            this.namebox.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(45, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 15);
            this.name.TabIndex = 1;
            this.name.Text = "Full Name";
            // 
            // classroom
            // 
            this.classroom.AutoSize = true;
            this.classroom.Location = new System.Drawing.Point(45, 151);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(34, 15);
            this.classroom.TabIndex = 2;
            this.classroom.Text = "Class";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(45, 205);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(45, 15);
            this.gender.TabIndex = 3;
            this.gender.Text = "Gender";
            this.gender.Click += new System.EventHandler(this.gender_Click);
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Location = new System.Drawing.Point(45, 260);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(73, 15);
            this.dateofbirth.TabIndex = 4;
            this.dateofbirth.Text = "Date of birth";
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(95, 202);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(79, 23);
            this.genderbox.TabIndex = 6;
            this.genderbox.SelectedIndexChanged += new System.EventHandler(this.genderbox_SelectedIndexChanged);
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(124, 254);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(102, 23);
            this.dateofbirthbox.TabIndex = 7;
            this.dateofbirthbox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(74, 346);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(120, 48);
            this.savebutton.TabIndex = 8;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(254, 346);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(120, 48);
            this.clearbutton.TabIndex = 9;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(85, 148);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(89, 23);
            this.classbox.TabIndex = 10;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(220, 151);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(28, 15);
            this.age.TabIndex = 11;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(254, 148);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(45, 23);
            this.agebox.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(45, 25);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 15);
            this.id.TabIndex = 13;
            this.id.Text = "ID";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(74, 22);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 23);
            this.idbox.TabIndex = 14;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 431);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.id);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Student";
            this.Text = "Add Student";
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
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idbox;
    }
}