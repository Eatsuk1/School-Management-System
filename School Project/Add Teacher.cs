using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Add_Teacher : Form
    {
        #region khởi tạo tham số ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataReader _dr;
        private ClassDB db = new ClassDB();
        private Mngteacher f;
        private string _title = "Hệ thống quản lý";
        private string b;

        public Add_Teacher(Mngteacher f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        #endregion khởi tạo tham số ban đầu cần thiết

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {
            

            //tạo list các textbox để kiểm tra đã điền đủ hay chưa
            List<string> textbox = new List<string>();
            textbox.Add(namebox.Text); textbox.Add(genderbox.Text);
            textbox.Add(addressbox.Text); textbox.Add(phonenumbox.Text);

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
                    SqlCommand cm = new SqlCommand("INSERT INTO R1(tenGiaoVien,ngaysinhGiaoVien,Gioitinh,Diachi,Sodienthoai,Trangthai) VALUES(@tenGiaoVien,@ngaysinhGiaoVien,@Gioitinh,@Diachi,@Sodienthoai,@Trangthai)", cn);
                    cm.Parameters.AddWithValue("tenGiaoVien", namebox.Text);
                    cm.Parameters.AddWithValue("ngaysinhGiaoVien", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("Gioitinh", genderbox.Text);
                    cm.Parameters.AddWithValue("Diachi", addressbox.Text);
                    cm.Parameters.AddWithValue("Sodienthoai", phonenumbox.Text);
                    cm.Parameters.AddWithValue("Trangthai", statusbox.SelectedItem.ToString());
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Lưu thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            f.LoadRecords();
            Close();
        }

        //xóa thông tin vừa nhập
        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            dateofbirthbox.Value = DateTime.Now;
            genderbox.SelectedIndex = -1;
            statusbox.SelectedIndex = -1;
            addressbox.Clear();
            phonenumbox.Clear();
        }

    }
}