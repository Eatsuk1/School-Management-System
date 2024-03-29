﻿
namespace School_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.forgotbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.BackColor = System.Drawing.SystemColors.Control;
            this.loginlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginlabel.Location = new System.Drawing.Point(12, 36);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(433, 37);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Trường Tiểu Học Bách Khoa Hà Nội";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.Location = new System.Drawing.Point(68, 122);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(107, 20);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Tên đăng nhập";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel.Location = new System.Drawing.Point(68, 174);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(70, 20);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "Mật khẩu";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(193, 119);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(200, 23);
            this.usernamebox.TabIndex = 3;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(193, 171);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(200, 23);
            this.passwordbox.TabIndex = 4;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginbutton.Location = new System.Drawing.Point(91, 231);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(84, 40);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Đăng nhập";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // forgotbutton
            // 
            this.forgotbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.forgotbutton.Location = new System.Drawing.Point(272, 231);
            this.forgotbutton.Name = "forgotbutton";
            this.forgotbutton.Size = new System.Drawing.Size(84, 40);
            this.forgotbutton.TabIndex = 6;
            this.forgotbutton.Text = "Quên mật khẩu";
            this.forgotbutton.UseVisualStyleBackColor = false;
            this.forgotbutton.Click += new System.EventHandler(this.forgotbutton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::School_Project.Properties.Resources.k11_1618210390788910112165_23_0_648_1000_crop_1618243934065760570168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 308);
            this.Controls.Add(this.forgotbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.loginlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiểu học";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button forgotbutton;
    }
}