
namespace School_Project
{
    partial class Edit_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Student));
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.classroom = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.idbox = new System.Windows.Forms.TextBox();
            this.namebox = new System.Windows.Forms.TextBox();
            this.classbox = new System.Windows.Forms.TextBox();
            this.agebox = new System.Windows.Forms.TextBox();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(52, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 15);
            this.id.TabIndex = 14;
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(52, 80);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 15);
            this.name.TabIndex = 15;
            this.name.Text = "Full Name";
            // 
            // classroom
            // 
            this.classroom.AutoSize = true;
            this.classroom.Location = new System.Drawing.Point(52, 136);
            this.classroom.Name = "classroom";
            this.classroom.Size = new System.Drawing.Size(34, 15);
            this.classroom.TabIndex = 16;
            this.classroom.Text = "Class";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(223, 136);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(28, 15);
            this.age.TabIndex = 17;
            this.age.Text = "Age";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(52, 206);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(45, 15);
            this.gender.TabIndex = 18;
            this.gender.Text = "Gender";
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Location = new System.Drawing.Point(52, 268);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(73, 15);
            this.dateofbirth.TabIndex = 19;
            this.dateofbirth.Text = "Date of birth";
            this.dateofbirth.Click += new System.EventHandler(this.dateofbirth_Click);
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(131, 262);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(102, 23);
            this.dateofbirthbox.TabIndex = 20;
            this.dateofbirthbox.ValueChanged += new System.EventHandler(this.dateofbirthbox_ValueChanged);
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(76, 18);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 23);
            this.idbox.TabIndex = 21;
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(119, 77);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(187, 23);
            this.namebox.TabIndex = 22;
            // 
            // classbox
            // 
            this.classbox.Location = new System.Drawing.Point(92, 133);
            this.classbox.Name = "classbox";
            this.classbox.Size = new System.Drawing.Size(89, 23);
            this.classbox.TabIndex = 23;
            // 
            // agebox
            // 
            this.agebox.Location = new System.Drawing.Point(257, 133);
            this.agebox.Name = "agebox";
            this.agebox.Size = new System.Drawing.Size(45, 23);
            this.agebox.TabIndex = 24;
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(103, 198);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(79, 23);
            this.genderbox.TabIndex = 25;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(52, 329);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(120, 48);
            this.savebutton.TabIndex = 26;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(223, 329);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(120, 48);
            this.clearbutton.TabIndex = 27;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // Edit_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 428);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.genderbox);
            this.Controls.Add(this.agebox);
            this.Controls.Add(this.classbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.dateofbirthbox);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.age);
            this.Controls.Add(this.classroom);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Student";
            this.Text = "Edit Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label classroom;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
        internal System.Windows.Forms.DateTimePicker dateofbirthbox;
        internal System.Windows.Forms.TextBox idbox;
        internal System.Windows.Forms.TextBox namebox;
        internal System.Windows.Forms.TextBox classbox;
        internal System.Windows.Forms.TextBox agebox;
        internal System.Windows.Forms.ComboBox genderbox;
    }
}