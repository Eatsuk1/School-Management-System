
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
            this.loginlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginlabel.Location = new System.Drawing.Point(163, 41);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(184, 46);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Đăng nhập";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.Location = new System.Drawing.Point(78, 135);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(137, 25);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "Tên đăng nhập";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordlabel.Location = new System.Drawing.Point(78, 198);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(91, 25);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "Mật khẩu";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(221, 136);
            this.usernamebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(186, 27);
            this.usernamebox.TabIndex = 3;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(221, 199);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(186, 27);
            this.passwordbox.TabIndex = 4;
            this.passwordbox.UseSystemPasswordChar = true;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(120, 273);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(96, 53);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Enter";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // forgotbutton
            // 
            this.forgotbutton.Location = new System.Drawing.Point(307, 273);
            this.forgotbutton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.forgotbutton.Name = "forgotbutton";
            this.forgotbutton.Size = new System.Drawing.Size(101, 53);
            this.forgotbutton.TabIndex = 6;
            this.forgotbutton.Text = "Quên mật khẩu";
            this.forgotbutton.UseVisualStyleBackColor = true;
            this.forgotbutton.Click += new System.EventHandler(this.forgotbutton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 429);
            this.Controls.Add(this.forgotbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.loginlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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