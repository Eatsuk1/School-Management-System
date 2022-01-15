using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace School_Project
{
    public partial class Mngstudent : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        string _title = "Hệ thống quản lý";
        public Mngstudent()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        //đưa các dữ liệu vào bảng
        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            var cm = new SqlCommand("select R2.tenHocSinh, R3.tenLop, R2.Tuoi, R2.Gioitinh, R2.NgaySinh from R2,R3 where R2.maLop = R3.maLop", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenHocSinh"].ToString(), dr["tenLop"].ToString(), dr["Tuoi"].ToString(), dr["Gioitinh"].ToString(), DateTime.Parse(dr["NgaySinh"].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }

        private void Mngstudent_Load(object sender, EventArgs e)
        {

        }

        //thêm học sinh mới
        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Student s = new Add_Student(this);
            s.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        //chỉnh sửa thông tin học sinh
        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Student f = new Edit_Student(this);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R2 where tenHocSinh = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.idstudentbox.Text = dr["maHocSinh"].ToString();
                f.namebox.Text = dr["tenHocSinh"].ToString();
                f.classbox.Text = dr["maLop"].ToString();
                f.agebox.Text = dr["Tuoi"].ToString();
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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này? Nhấn Yes để xóa", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cm = new SqlCommand("delete from R2 where tenHocSinh = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Đã xóa hoc sinh vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                LoadRecords();
            }
        }

        
        //hàm filter cho search
        public void LoadSearch(string searchWord)
        {
            
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select name, class, age, gender, dob from student_info where " + age.Name + " = '" + searchWord + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["name"].ToString(), dr["class"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            LoadSearch(searchbox.Text);
        }

        private void age_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gender_CheckedChanged(object sender, EventArgs e)
        {

        }

        //lock / unlock thanh search

    }
}
