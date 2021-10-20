
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
            this.id = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.Label();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.dateofbirth = new System.Windows.Forms.Label();
            this.dateofbirthbox = new System.Windows.Forms.DateTimePicker();
            this.designation = new System.Windows.Forms.Label();
            this.qualification = new System.Windows.Forms.Label();
            this.designationbox = new System.Windows.Forms.ComboBox();
            this.qualificationbox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(89, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 15);
            this.id.TabIndex = 14;
            this.id.Text = "ID";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(113, 47);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(100, 23);
            this.idbox.TabIndex = 15;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(89, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 15);
            this.name.TabIndex = 16;
            this.name.Text = "Full Name";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(156, 99);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(201, 23);
            this.namebox.TabIndex = 17;
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(89, 170);
            this.gender.Name = "gender";
            this.gender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender.Size = new System.Drawing.Size(45, 15);
            this.gender.TabIndex = 18;
            this.gender.Text = "Gender";
            // 
            // genderbox
            // 
            this.genderbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(140, 165);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(79, 23);
            this.genderbox.TabIndex = 19;
            // 
            // dateofbirth
            // 
            this.dateofbirth.AutoSize = true;
            this.dateofbirth.Location = new System.Drawing.Point(304, 168);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(73, 15);
            this.dateofbirth.TabIndex = 20;
            this.dateofbirth.Text = "Date of birth";
            // 
            // dateofbirthbox
            // 
            this.dateofbirthbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateofbirthbox.Location = new System.Drawing.Point(383, 164);
            this.dateofbirthbox.Name = "dateofbirthbox";
            this.dateofbirthbox.Size = new System.Drawing.Size(102, 23);
            this.dateofbirthbox.TabIndex = 21;
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Location = new System.Drawing.Point(89, 233);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(70, 15);
            this.designation.TabIndex = 22;
            this.designation.Text = "Designation";
            // 
            // qualification
            // 
            this.qualification.AutoSize = true;
            this.qualification.Location = new System.Drawing.Point(89, 305);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(75, 15);
            this.qualification.TabIndex = 23;
            this.qualification.Text = "Qualification";
            // 
            // designationbox
            // 
            this.designationbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.designationbox.FormattingEnabled = true;
            this.designationbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.designationbox.Location = new System.Drawing.Point(165, 230);
            this.designationbox.Name = "designationbox";
            this.designationbox.Size = new System.Drawing.Size(127, 23);
            this.designationbox.TabIndex = 24;
            // 
            // qualificationbox
            // 
            this.qualificationbox.Location = new System.Drawing.Point(170, 302);
            this.qualificationbox.Name = "qualificationbox";
            this.qualificationbox.Size = new System.Drawing.Size(304, 23);
            this.qualificationbox.TabIndex = 25;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(89, 394);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(124, 61);
            this.savebutton.TabIndex = 26;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(350, 394);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(124, 61);
            this.clearbutton.TabIndex = 27;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 513);
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
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add_Staff";
            this.Text = "Add Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Label dateofbirth;
        private System.Windows.Forms.DateTimePicker dateofbirthbox;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.Label qualification;
        private System.Windows.Forms.ComboBox designationbox;
        private System.Windows.Forms.TextBox qualificationbox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbutton;
    }
}