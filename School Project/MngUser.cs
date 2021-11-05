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
    public partial class MngUser : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        string str = "Quản lý tài khoản";
        public MngUser()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        private void MngUser_Load(object sender, EventArgs e)
        {
            cn.Open();
            display();
        }

        private void MngUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            cn.Close();
        }

        public void inputreset()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            comboBox1.ResetText();
        }

        public void display()
        {
            string sqlSELECT = "SELECT *FROM user_info";
            SqlCommand cmd = new SqlCommand(sqlSELECT, cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            UserList.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO user_info VALUES (@username, @password, @role) ";
            SqlCommand cmd = new SqlCommand(sqlINSERT, cn);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            cmd.Parameters.AddWithValue("role", comboBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            display();

            inputreset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string sqlEDIT = "UPDATE user_info SET username = @username, password = @password, role = @role where username = '" + UserList.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sqlEDIT, cn);
            cmd.Parameters.AddWithValue("username", txtUsername.Text);
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            cmd.Parameters.AddWithValue("role", comboBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            display();

            inputreset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này? Nhấn Yes để xóa", str, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("delete from user_info where username = '" + UserList.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                inputreset();

                MessageBox.Show("Đã xóa hoc sinh vừa chọn", str, MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT *FROM user_info WHERE username = @username ";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);
            cmd.Parameters.AddWithValue("username", txtSearch.Text);
            cmd.Parameters.AddWithValue("password", txtPassword.Text);
            cmd.Parameters.AddWithValue("role", comboBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            UserList.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            inputreset();
            txtSearch.Clear();
            display();
        }
    }
}
