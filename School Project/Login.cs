using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Project
{
    public partial class Login : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Mainwindow s = new Mainwindow();
            if(compare() == "admin")
            {
                this.Hide();
                s.Show();
            }else if(compare() == "teacher")
            {
                this.Hide();
                s.Manage_Staff.Enabled = false;
                s.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public string compare ()
        {
            string a = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("Select username, password, role from user_info", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                if (usernamebox.Text == dr["username"].ToString() && passwordbox.Text == dr["password"].ToString())
                {
                    a = dr["role"].ToString();
                }
            }
            dr.Close();
            cn.Close();
            return a;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
