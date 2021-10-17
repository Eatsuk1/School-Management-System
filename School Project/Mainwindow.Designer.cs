
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
            this.Manage_Staff = new System.Windows.Forms.ToolStripButton();
            this.Manage_Marks = new System.Windows.Forms.ToolStripButton();
            this.Manage_Fee = new System.Windows.Forms.ToolStripButton();
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
            this.Manage_Staff,
            this.Manage_Marks,
            this.Manage_Fee,
            this.Manage_Users,
            this.Log_out});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(876, 35);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Manage_Students
            // 
            this.Manage_Students.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Students.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Students.Image")));
            this.Manage_Students.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Students.Name = "Manage_Students";
            this.Manage_Students.Size = new System.Drawing.Size(142, 32);
            this.Manage_Students.Text = "Manage Students";
            this.Manage_Students.Click += new System.EventHandler(this.Manage_Students_Click);
            // 
            // Manage_Staff
            // 
            this.Manage_Staff.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Staff.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Staff.Image")));
            this.Manage_Staff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Staff.Name = "Manage_Staff";
            this.Manage_Staff.Size = new System.Drawing.Size(118, 32);
            this.Manage_Staff.Text = "Manage Staff";
            // 
            // Manage_Marks
            // 
            this.Manage_Marks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Marks.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Marks.Image")));
            this.Manage_Marks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Marks.Name = "Manage_Marks";
            this.Manage_Marks.Size = new System.Drawing.Size(128, 32);
            this.Manage_Marks.Text = "Manage Marks";
            // 
            // Manage_Fee
            // 
            this.Manage_Fee.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Fee.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Fee.Image")));
            this.Manage_Fee.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Fee.Name = "Manage_Fee";
            this.Manage_Fee.Size = new System.Drawing.Size(112, 32);
            this.Manage_Fee.Text = "Manage Fee";
            // 
            // Manage_Users
            // 
            this.Manage_Users.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Manage_Users.Image = ((System.Drawing.Image)(resources.GetObject("Manage_Users.Image")));
            this.Manage_Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Manage_Users.Name = "Manage_Users";
            this.Manage_Users.Size = new System.Drawing.Size(125, 32);
            this.Manage_Users.Text = "Manage Users";
            // 
            // Log_out
            // 
            this.Log_out.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Log_out.Image = ((System.Drawing.Image)(resources.GetObject("Log_out.Image")));
            this.Log_out.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Log_out.Name = "Log_out";
            this.Log_out.Size = new System.Drawing.Size(85, 32);
            this.Log_out.Text = "Log out";
            // 
            // Mainwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainwindow";
            this.Text = "Homepage";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Manage_Students;
        private System.Windows.Forms.ToolStripButton Manage_Staff;
        private System.Windows.Forms.ToolStripButton Manage_Marks;
        private System.Windows.Forms.ToolStripButton Manage_Fee;
        private System.Windows.Forms.ToolStripButton Manage_Users;
        private System.Windows.Forms.ToolStripButton Log_out;
    }
}