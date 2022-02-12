
namespace School_Project
{
    partial class Mainwindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainwindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Manage_Students = new System.Windows.Forms.ToolStripButton();
            this.Manage_Teacher = new System.Windows.Forms.ToolStripButton();
            this.Manage_Marks = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.Manage_Users = new System.Windows.Forms.ToolStripButton();
            this.Log_out = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Manage_Students,
            this.Manage_Teacher,
            this.Manage_Marks,
            this.toolStripLabel3,
            this.toolStripLabel1,
            this.Manage_Users,
            this.Log_out});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(876, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Manage_Students
            // 
            this.Manage_Students.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Students.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Students.Image")));
            this.Manage_Students.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Students.Name = "Manage_Students";
            this.Manage_Students.Size = new System.Drawing.Size(136, 32);
            this.Manage_Students.Text = "Quản lý học sinh";
            this.Manage_Students.Click += new System.EventHandler(this.Manage_Students_Click);
            // 
            // Manage_Teacher
            // 
            this.Manage_Teacher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Teacher.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Teacher.Image")));
            this.Manage_Teacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Teacher.Name = "Manage_Teacher";
            this.Manage_Teacher.Size = new System.Drawing.Size(141, 32);
            this.Manage_Teacher.Text = "Quản lý giáo viên";
            this.Manage_Teacher.Click += new System.EventHandler(this.Manage_Teacher_Click);
            // 
            // Manage_Marks
            // 
            this.Manage_Marks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Marks.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Marks.Image")));
            this.Manage_Marks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Marks.Name = "Manage_Marks";
            this.Manage_Marks.Size = new System.Drawing.Size(179, 32);
            this.Manage_Marks.Text = "Quản lý kết quả học tập";
            this.Manage_Marks.Click += new System.EventHandler(this.Manage_Marks_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Image = global::School_Project.Properties.Resources.Screenshot_2022_02_06_164113;
            this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(131, 32);
            this.toolStripLabel3.Text = "Quản lý môn học";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(123, 32);
            this.toolStripLabel1.Text = "Quản lý lớp học";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // Manage_Users
            // 
            this.Manage_Users.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Users.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Users.Image")));
            this.Manage_Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Users.Name = "Manage_Users";
            this.Manage_Users.Size = new System.Drawing.Size(156, 32);
            this.Manage_Users.Text = "Quản lý người dùng";
            this.Manage_Users.Click += new System.EventHandler(this.Manage_Users_Click);
            // 
            // Log_out
            // 
            this.Log_out.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_out.Image = ((System.Drawing.Image)(resources.GetObject("Log_out.Image")));
            this.Log_out.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(99, 32);
            this.Log_out.Text = "Đăng xuất";
            this.Log_out.Click += new System.EventHandler(this.Log_out_Click);
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::School_Project.Properties.Resources.Trước_C1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainwindow_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStrip toolStrip1;
        protected internal System.Windows.Forms.ToolStripButton Manage_Teacher;
        protected internal System.Windows.Forms.ToolStripButton Manage_Students;
        protected internal System.Windows.Forms.ToolStripButton Manage_Marks;
        protected internal System.Windows.Forms.ToolStripButton Manage_Users;
        protected internal System.Windows.Forms.ToolStripButton Log_out;
        protected internal System.Windows.Forms.ToolStripButton toolStripLabel3;
        protected internal System.Windows.Forms.ToolStripButton toolStripLabel1;
    }
}