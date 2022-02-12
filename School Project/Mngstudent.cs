using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mngstudent : Form
    {
        #region khởi tạo tham số ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private SqlDataReader _dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";

        public Mngstudent()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        #endregion khởi tạo tham số ban đầu cần thiết

        //đưa các dữ liệu vào bảng
        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            var cm = new SqlCommand("select * from R2", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString(), dr["Gioitinh"].ToString(), DateTime.Parse(dr["NgaySinh"].ToString()).ToShortDateString(), dr["Trangthai"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        #region chức năng của quản lý học sinh

        //thêm học sinh mới
        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Student s = new Add_Student(this);
            s.Show();
        }

        //chỉnh sửa thông tin học sinh
        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Student f = new Edit_Student(this);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R2 where maHocSinh = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.idstudent = dr["maHocSinh"].ToString();
                f.namebox.Text = dr["tenHocSinh"].ToString();
                f.statusbox.Text = dr["Trangthai"].ToString();
                f.genderbox.Text = dr["Gioitinh"].ToString();
                f.dateofbirthbox.Text = dr["NgaySinh"].ToString();
                f.placeofbirthbox.Text = dr["NoiSinh"].ToString();
                f.ethnicbox.Text = dr["Dantoc"].ToString();
                f.nationalitybox.Text = dr["Quoctich"].ToString();
                f.addressbox.Text = dr["Diachi"].ToString();
                f.hometownbox.Text = dr["Quequan"].ToString();
                f.momnamebox.Text = dr["Tenme"].ToString();
                f.dadnamebox.Text = dr["Tenbo"].ToString();
                f.phonenumbox.Text = dr["Sodienthoai"].ToString();
                f.heightbox.Text = dr["Chieucao"].ToString();
                f.weightbox.Text = dr["Cannang"].ToString();
            }
            dr.Close();
            cn.Close();
            f.Show();
        }

        //xóa học sinh khỏi cơ sở dữ liệu
        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này? Nhấn Yes để xóa", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("delete from R2 where maHocSinh = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Đã xóa hoc sinh vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();
            }
        }

        

        #endregion chức năng của quản lý học sinh

        #region chức năng tìm kiếm

        //chạy search
        public void LoadSearch()
        {
            try
            {
                dataGridView1.Rows.Clear();
                cn.Open();
                SqlCommand cm;
                if (age.Checked == true && gender.Checked == false && name.Checked == false)
                {
                    cm = new SqlCommand("select * from R2 where Tuoi = '" + agenumeric.Value + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString(), dr["Gioitinh"].ToString(), DateTime.Parse(dr["NgaySinh"].ToString()).ToShortDateString(), dr["Trangthai"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
                else if (age.Checked == false && gender.Checked == false && name.Checked == true)
                {
                    cm = new SqlCommand("select * from R2 where tenHocSinh like '%" + namebox.Text + "%'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString(), dr["Gioitinh"].ToString(), DateTime.Parse(dr["NgaySinh"].ToString()).ToShortDateString(), dr["Trangthai"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
                else if (age.Checked == false && gender.Checked == true && name.Checked == false)
                {

                    cm = new SqlCommand("select * from R2 where Gioitinh = '" + genderbox.Text + "'", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        dataGridView1.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString(), dr["Gioitinh"].ToString(), DateTime.Parse(dr["NgaySinh"].ToString()).ToShortDateString(), dr["Trangthai"].ToString());
                    }
                    dr.Close();
                    cn.Close();
                }
                else if (name.Checked == true && age.Checked == true || name.Checked == true && gender.Checked == true)
                {
                    cn.Close();
                    MessageBox.Show("Bộ lọc không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadRecords();
                }
                cn.Close();
            }catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            age.Checked = gender.Checked = name.Checked = false;
        }

        #region mở khóa filter bằng cách kiểm tra xem đã được tích hay chưa

        private void age_CheckStateChanged(object sender, EventArgs e)
        {
            if (age.Checked) agenumeric.Enabled = true;
            else { agenumeric.ResetText(); agenumeric.Enabled = false; }
        }

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