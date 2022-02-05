using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Edit_Student : Form
    {
        #region khởi tạo tham số ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private Mngstudent f;
        private string _title = "Hệ thống quản lý";
        internal string idstudent;

        public Edit_Student(Mngstudent f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        #endregion khởi tạo tham số ban đầu cần thiết

        //tự động tinh tuổi khi nhập ngày sinh (thông qua hàm years)
        private void dateofbirthbox_ValueChanged(object sender, EventArgs e)
        {
            agebox.Text = years(dateofbirthbox.Value.Date, DateTime.Now.Date).ToString();
        }

        private int years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) + (((end.Month > start.Month) || (end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
        }

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE R2 SET tenHocSinh = @tenHocSinh, Tuoi = @Tuoi, Gioitinh = @Gioitinh, NgaySinh = @NgaySinh, Noisinh = @Noisinh, Dantoc = @Dantoc, Quoctich = @Quoctich, Quequan = @Quequan, Diachi = @Diachi, Tenme = @Tenme, Tenbo = @Tenbo, Sodienthoai = @Sodienthoai, Chieucao = @Chieucao, Cannang = @Cannang where maHocSinh = '" + idstudent + "'", cn);
                    cm.Parameters.AddWithValue("@tenHocSinh", namebox.Text);
                    cm.Parameters.AddWithValue("@Tuoi", agebox.Text);
                    cm.Parameters.AddWithValue("@Gioitinh", genderbox.SelectedItem.ToString());
                    cm.Parameters.AddWithValue("@NgaySinh", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@NoiSinh", placeofbirthbox.Text);
                    cm.Parameters.AddWithValue("@Dantoc", ethnicbox.Text);
                    cm.Parameters.AddWithValue("@Quoctich", nationalitybox.Text);
                    cm.Parameters.AddWithValue("@Quequan", hometownbox.Text);
                    cm.Parameters.AddWithValue("@Diachi", addressbox.Text);
                    cm.Parameters.AddWithValue("@Tenme", momnamebox.Text);
                    cm.Parameters.AddWithValue("@Tenbo", dadnamebox.Text);
                    cm.Parameters.AddWithValue("@Sodienthoai", phonenumbox.Text);
                    cm.Parameters.AddWithValue("@Chieucao", heightbox.Text);
                    cm.Parameters.AddWithValue("@Cannang", weightbox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cập nhật thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //xóa thông tin vừa nhập
        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            genderbox.Items.Clear();
            ethnicbox.Clear();
            nationalitybox.Clear();
            placeofbirthbox.Clear();
            hometownbox.Clear();
            addressbox.Clear();
            momnamebox.Clear(); dadnamebox.Clear();
            dateofbirthbox.Value = DateTime.Now; agebox.Clear();
            phonenumbox.Clear();
        }
    }
}