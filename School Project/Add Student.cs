using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Add_Student : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private Mngstudent f;
        private string _title = "Hệ thống quản lý";

        public Add_Student(Mngstudent f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        //tự động tinh tuổi khi nhập ngày sinh (thông qua hàm years)
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
            //tra ve ma so lop
            cn.Open();
            var a = new SqlCommand("select maLop from R3 where tenLop = '" + classbox.Text + "'", cn);
            dr = a.ExecuteReader();
            dr.Read();
            string b = dr["maLop"].ToString();
            dr.Close();
            cn.Close();

            //tạo list các textbox để kiểm tra đã điền đủ hay chưa
            List<string> textbox = new List<string>();
            textbox.Add(namebox.Text); textbox.Add(classbox.Text); textbox.Add(genderbox.Text); textbox.Add(placeofbirthbox.Text);
            textbox.Add(ethnicbox.Text); textbox.Add(nationalitybox.Text); textbox.Add(hometownbox.Text); textbox.Add(addressbox.Text);
            textbox.Add(momnamebox.Text); textbox.Add(dadnamebox.Text); textbox.Add(heightbox.Text); textbox.Add(weightbox.Text);
            textbox.Add(phonenumbox.Text); textbox.Add(agebox.Text);

            try
            {
                foreach (string s in textbox)
                {
                    if (string.IsNullOrEmpty(s))
                    {
                        MessageBox.Show("Thông tin điền thiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO R2(maHocSinh,tenHocSinh,Tuoi,Gioitinh,NgaySinh,Noisinh,Dantoc,Quoctich,Quequan,Diachi,Tenme,Tenbo,Sodienthoai,Chieucao,Cannang,maLop) VALUES(@maHocSinh,@tenHocSinh,@Tuoi,@Gioitinh,@NgaySinh,@Noisinh,@Dantoc,@Quoctich,@Quequan,@Diachi,@Tenme,@Tenbo,@Sodienthoai,@Chieucao,@Cannang,@maLop)", cn);
                    cm.Parameters.AddWithValue("@maHocSinh", idstudentbox.Text);
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
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Lưu thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadRecords();
                    Close();
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
            genderbox.SelectedIndex = -1;
            classbox.SelectedIndex = -1;
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