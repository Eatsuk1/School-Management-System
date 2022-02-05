using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace School_Project
{
    public partial class Login : Form
    {
        #region khởi tạo tham số ban đầu cần thiết
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        public Login()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }
        #endregion

        //đăng nhập
        private void loginbutton_Click(object sender, EventArgs e)
        {
            Mainwindow s = new Mainwindow();
            if (compare() == "admin")
            {
                this.Hide();
                s.Show();
            }
            else if (compare() == "giáo viên")
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

        //đối chiếu tài khoản để cấp quyền truy cập
        public string compare()
        {
            string a = "";
            cn.Open();
            SqlCommand cm = new SqlCommand("Select Tendangnhap, Matkhau, Quyenhan from R8", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                if (usernamebox.Text == dr["Tendangnhap"].ToString() && passwordbox.Text == dr["Matkhau"].ToString())
                {
                    a = dr["Quyenhan"].ToString();
                }
            }
            dr.Close();
            cn.Close();
            return a;
        }

        //tắt ứng dụng
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //quên mật khẩu
        private void forgotbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ Admin để được cấp lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
