using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Edit_Teacher : Form
    {
        #region khởi tạo tham số ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataReader _dr;
        private ClassDB db = new ClassDB();
        private Mngteacher f;
        private string _title = "Hệ thống quản lý";
        internal string idteacher;

        public Edit_Teacher(Mngteacher f)
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
            try
            {
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE R1 SET tenGiaoVien = @tenGiaoVien,ngaysinhGiaoVien = @ngaysinhGiaoVien,Gioitinh = @Gioitinh,Diachi = @Diachi,Sodienthoai = @Sodienthoai where maGiaoVien = '" + idteacher + "'", cn);
                    cm.Parameters.AddWithValue("tenGiaoVien", namebox.Text);
                    cm.Parameters.AddWithValue("ngaysinhGiaoVien", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("Gioitinh", genderbox.Text);
                    cm.Parameters.AddWithValue("Diachi", addressbox.Text);
                    cm.Parameters.AddWithValue("Sodienthoai", phonenumbox.Text);
                    cm.ExecuteNonQuery();

                    //lưu lớp giáo viên phụ trách
                    for (int i = 0; i < classbox.Items.Count; i++)
                    {
                        var a = new SqlCommand("select maLop from R3 where tenLop = '" + classbox.Items[i].ToString() + "'", cn);
                        _dr = a.ExecuteReader();
                        _dr.Read();
                        var c = new SqlCommand("select maLop from R9 where maGiaoVien = '" + idteacher + "'", cn);
                        dr = c.ExecuteReader();
                        int tmp = 0;
                        while (dr.Read())
                        {
                            if (_dr["maLop"].ToString() == dr["maLop"].ToString())
                            {
                                if (classbox.GetItemChecked(i) == false)
                                {
                                    var dltclass = new SqlCommand("delete from R9 where maLop = '" + _dr["maLop"].ToString() + "' and maGiaoVien = '" + idteacher + "'", cn);
                                    dltclass.ExecuteNonQuery();
                                }
                                tmp++;
                            }
                        }
                        if (tmp == 0)
                        {
                            if (classbox.GetItemChecked(i) == true)
                            {
                                var addclass = new SqlCommand("insert into R9 (maGiaoVien, maLop) values(@maGiaoVien, @maLop)", cn);
                                addclass.Parameters.AddWithValue("maGiaoVien", idteacher);
                                addclass.Parameters.AddWithValue("maLop", _dr["maLop"].ToString());
                                addclass.ExecuteNonQuery();
                            }
                        }
                        _dr.Close();
                    }

                    MessageBox.Show("Cập nhật thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            addressbox.Clear();
            phonenumbox.Clear();
            classbox.SelectedIndex = -1;
        }
    }
}