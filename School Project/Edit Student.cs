using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Edit_Student : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        Mngstudent f;
        string _title = "Hệ thống quản lý";
        public Edit_Student(Mngstudent f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {
            //tra ve ma so lop
            cn.Open();
            var a = new SqlCommand("select maLop from R3 where tenLop = '" + classbox.Text + "'", cn);
            dr = a.ExecuteReader();
            dr.Read();
            string b = dr["maLop"].ToString();
            dr.Close();
            cn.Close();

            try
            {
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE R2 SET tenHocSinh = @tenHocSinh, Tuoi = @Tuoi, Gioitinh = @Gioitinh, NgaySinh = @NgaySinh, Noisinh = @Noisinh, Dantoc = @Dantoc, Quoctich = @Quoctich, Quequan = @Quequan, Diachi = @Diachi, Tenme = @Tenme, Tenbo = @Tenbo, Sodienthoai = @Sodienthoai, Chieucao = @Chieucao, Cannang = @Cannang, maLop = @maLop where maHocSinh = @maHocSinh", cn);
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
                    cm.Parameters.AddWithValue("@maLop", b);
                    cm.Parameters.AddWithValue("@maHocSinh", idstudentbox.Text);
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

        //tự động tinh tuổi khi nhập ngày sinh (thông qua hàm years)
        private void dateofbirthbox_ValueChanged(object sender, EventArgs e)
        {
            agebox.Text = years(dateofbirthbox.Value.Date, DateTime.Now.Date).ToString();
        }

        int years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) + (((end.Month > start.Month) || (end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
        }

        //xóa thông tin vừa nhập
        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            genderbox.Items.Clear();
            classbox.Items.Clear();
            
            ethnicbox.Clear();
            nationalitybox.Clear();
            placeofbirthbox.Clear();
            hometownbox.Clear();
            addressbox.Clear();
            momnamebox.Clear(); dadnamebox.Clear(); idstudentbox.Clear();
            dateofbirthbox.Value = DateTime.Now; agebox.Clear();
            phonenumbox.Clear();
        }
    }
}
