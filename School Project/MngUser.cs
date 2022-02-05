using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            string sqlSELECT = "SELECT *FROM R8";
            SqlCommand cmd = new SqlCommand(sqlSELECT, cn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            UserList.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sqlINSERT = "INSERT INTO R8 VALUES (@Tendangnhap, @Matkhau, @Quyenhan) ";
            SqlCommand cmd = new SqlCommand(sqlINSERT, cn);
            cmd.Parameters.AddWithValue("Tendangnhap", txtUsername.Text);
            cmd.Parameters.AddWithValue("Matkhau", txtPassword.Text);
            cmd.Parameters.AddWithValue("Quyenhan", comboBox1.Text.ToString());
            cmd.ExecuteNonQuery();
            display();

            inputreset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            string sqlEDIT = "UPDATE R8 SET Tendangnhap = @Tendangnhap, Matkhau = @Matkhau, Quyenhan = @Quyenhan where ID = '" + UserList.CurrentRow.Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sqlEDIT, cn);
            cmd.Parameters.AddWithValue("Tendangnhap", txtUsername.Text);
            cmd.Parameters.AddWithValue("Matkhau", txtPassword.Text);
            cmd.Parameters.AddWithValue("Quyenhan", comboBox1.Text);
            cmd.ExecuteNonQuery();
            display();

            inputreset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa tài khoản này? Nhấn Yes để xóa", str, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("delete from R8 where Tendangnhap = '" + UserList.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cm.ExecuteNonQuery();
                inputreset();

                MessageBox.Show("Đã xóa tài khoản vừa chọn", str, MessageBoxButtons.OK, MessageBoxIcon.Information);
                display();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sqlSearch = "SELECT *FROM R8 WHERE Tendangnhap = '" + txtSearch.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlSearch, cn);
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
