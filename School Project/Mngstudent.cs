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
            SqlCommand cm = new SqlCommand("select name, class, age, gender, dob from student_info", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["name"].ToString(), dr["class"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString());
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
            SqlCommand cm = new SqlCommand("select * from student_info where name = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.namebox.Text = dr["name"].ToString();
                f.classbox.Text = dr["class"].ToString();
                f.agebox.Text = dr["age"].ToString();
                f.genderbox.Text = dr["gender"].ToString();
                f.dateofbirthbox.Text = dr["dob"].ToString();
                f.placeofbirthbox.Text = dr["pob"].ToString();
                f.ethnicbox.Text = dr["ethnic"].ToString();
                f.nationalitybox.Text = dr["nationality"].ToString();
                f.hometownbox.Text = dr["hometown"].ToString();
                f.addressbox.Text = dr["home_address"].ToString();
                f.momnamebox.Text = dr["mom_name"].ToString();
                f.dadnamebox.Text = dr["dad_name"].ToString();
                f.guardiannamebox.Text = dr["guardian_name"].ToString();
                f.heightbox.Text = dr["height"].ToString();
                f.weightbox.Text = dr["weight"].ToString();
            }
            dr.Close();
            cn.Close();
            f.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này? Nhấn Yes để xóa", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cm = new SqlCommand("delete from student_info where name = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
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
