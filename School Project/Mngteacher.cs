using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mngteacher : Form
    {
        #region khởi tạo biến ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataReader _dr;
        private SqlDataReader _idcls;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";

        public Mngteacher()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        #endregion khởi tạo biến ban đầu cần thiết

        //đưa các dữ liệu vào bảng
        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R1", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["maGiaoVien"].ToString(), dr["tenGiaoVien"].ToString(), DateTime.Parse(dr["ngaysinhGiaoVien"].ToString()).ToShortDateString(), dr["Gioitinh"].ToString(), dr["Sodienthoai"].ToString(), dr["Trangthai"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #region chức năng của mngteacher

        //thêm giáo viên mới
        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Teacher s = new Add_Teacher(this);
            s.Show();
        }

        //chỉnh sửa thông tin giáo viên
        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Teacher f = new Edit_Teacher(this);
            cn.Open();

            //xác định giáo viên cần chỉnh sửa và lấy dữ liệu từ giáo viên đó
            SqlCommand cm = new SqlCommand("select * from R1 where maGiaoVien = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();

            //đưa dữ liệu từ database lên phần mềm để cập nhật
            if (dr.HasRows)
            {
                f.namebox.Text = dr["tenGiaoVien"].ToString();
                f.dateofbirthbox.Text = dr["ngaysinhGiaoVien"].ToString();
                f.genderbox.Text = dr["Gioitinh"].ToString();
                f.addressbox.Text = dr["Diachi"].ToString();
                f.phonenumbox.Text = dr["Sodienthoai"].ToString();
                f.idteacher = dr["maGiaoVien"].ToString();
                f.statusbox.Text = dr["Trangthai"].ToString();
            }

            dr.Close();
            cn.Close();
            f.ShowDialog();
        }

        //xóa giáo viên
        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên này? Nhấn Yes để xóa", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SqlCommand cm = new SqlCommand("Delete from R1 where maGiaoVien = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Đã xóa giáo viên vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion chức năng của mngteacher

        #region chức năng tìm kiếm

        //hàm filter cho search
        public void LoadSearch()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm;
            if (gender.Checked == false || name.Checked == false)
            {
                if (gender.Checked == true)
                {
                    cm = new SqlCommand("select maGiaoVien, tenGiaoVien, ngaysinhGiaoVien, Gioitinh, Sodienthoai, Trangthai from R1 where Gioitinh = '" + genderbox.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["maGiaoVien"].ToString(), dr["tenGiaoVien"].ToString(), DateTime.Parse(dr["ngaysinhGiaoVien"].ToString()).ToShortDateString(), dr["Gioitinh"].ToString(), dr["Sodienthoai"].ToString(), dr["Trangthai"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
                else if (name.Checked == true)
                {
                    cm = new SqlCommand("select maGiaoVien, tenGiaoVien, ngaysinhGiaoVien, Gioitinh, Sodienthoai, Trangthai from R1 where tenGiaoVien like '%" + namebox.Text + "%'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["maGiaoVien"].ToString(), dr["tenGiaoVien"].ToString(), DateTime.Parse(dr["ngaysinhGiaoVien"].ToString()).ToShortDateString(), dr["Gioitinh"].ToString(), dr["Sodienthoai"].ToString(), dr["Trangthai"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            else
            {
                cn.Close();
                MessageBox.Show("Bộ lọc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadRecords();
            }
            cn.Close();
        }

        //kích hoạt tìm kiếm
        private void searchbutton_Click(object sender, EventArgs e)
        {
            LoadSearch();
        }

        //làm mới lại bảng
        private void resetbutton_Click(object sender, EventArgs e)
        {
            LoadRecords();
            gender.Checked = name.Checked = false;
        }

        #region mở khóa filter bằng cách kiểm tra xem đã được tích hay chưa

        private void gender_CheckStateChanged(object sender, EventArgs e)
        {
            if (gender.Checked) genderbox.Enabled = true;
            else { genderbox.SelectedIndex = -1; genderbox.Enabled = false; }
        }

        private void name_CheckStateChanged(object sender, EventArgs e)
        {
            if (name.Checked) namebox.Enabled = true;
            else { namebox.Clear(); namebox.Enabled = false; }
        }

        #endregion mở khóa filter bằng cách kiểm tra xem đã được tích hay chưa

        #endregion chức năng tìm kiếm
    }
}