﻿using System;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mainwindow : Form
    {
        private bool isExit = true; //sử đụng dể phân biệt log out và thoát chương trình

        public Mainwindow()
        {
            InitializeComponent(); //phương thức quản lý mọi thứ hiện diện trên forms, được quản lý bởi windows forms designer
        }

        //quản lý học sinh
        private void Manage_Students_Click(object sender, EventArgs e)
        {
            Mngstudent s = new Mngstudent();
            s.LoadRecords();
            s.Show();
        }

        
        //quản lý kết quả học tập
        private void Manage_Marks_Click(object sender, EventArgs e)
        {
            MngMarks s = new MngMarks();
            s.Show();
        }

        //đăng xuất
        private void Log_out_Click(object sender, EventArgs e)
        {
            isExit = false;
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Login f = new Login();
                f.Show();
            }
        }

        private void Manage_Users_Click(object sender, EventArgs e)
        {
            MngUser f = new MngUser();
            f.Show();
        }

        //đóng ứng dụng
        private void Mainwindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
                    if (result == System.Windows.Forms.DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        //quản lý môn học
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Mngsubject s = new Mngsubject();
            s.LoadSubject(); s.Show();
        }

        //quản lý lớp học
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Mngclass s = new Mngclass();
            s.Show();
        }

        //quản lý giáo viên
        private void Manage_Teacher_Click(object sender, EventArgs e)
        {
            Mngteacher s = new Mngteacher();
            s.LoadRecords();
            s.Show();
        }
    }
}