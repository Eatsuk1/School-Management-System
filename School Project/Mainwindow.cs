using System;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mainwindow : Form
    {
        bool isExit = true; //sử đụng dể phân biệt log out và thoát chương trình

        public Mainwindow()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //quản lý học sinh
        private void Manage_Students_Click(object sender, EventArgs e)
        {
            Mngstudent s = new Mngstudent();
            s.LoadRecords();
            s.Show();
        }

        //quản lý nhân sự
        private void Manage_Staff_Click(object sender, EventArgs e)
        {
            MngStaff s = new MngStaff();
            s.LoadRecords();
            s.Show();
        }

        private void Mainwindow_Load(object sender, EventArgs e)
        {

        }

        private void Manage_Marks_Click(object sender, EventArgs e)
        {
           
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

        //đóng ứng dụng
        private void Mainwindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
