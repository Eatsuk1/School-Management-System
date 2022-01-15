using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mngteacher : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        string _title = "Hệ thống quản lý";
        public Mngteacher()
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
            SqlCommand cm = new SqlCommand("select * from teacher_info", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString(), dr["subject"].ToString(), dr["class"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        //thêm giáo viên mới
        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Teacher s = new Add_Teacher(this);
            s.ShowDialog();
        }

        private void MngStaff_Load(object sender, EventArgs e)
        {

        }

        //chỉnh sửa thông tin giáo viên
        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Staff f = new Edit_Staff(this);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from staff_info where name = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.namebox.Text = dr["name"].ToString();
                f.dateofbirthbox.Text = dr["dob"].ToString();
                f.genderbox.Text = dr["gender"].ToString();
                f.ethnicbox.Text = dr["ethnic"].ToString();
                f.nationalitybox.Text = dr["nationality"].ToString();
                f.hometownbox.Text = dr["hometown"].ToString();
                f.addressbox.Text = dr["home_address"].ToString();
                f.phonenumbox.Text = dr["phone_number"].ToString();
                f.designationbox.Text = dr["designation"].ToString();
                f.qualificationbox.Text = dr["qualification"].ToString();
            }
            dr.Close();
            cn.Close();
            f.ShowDialog();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên này? Nhấn Yes để xóa", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cm = new SqlCommand("delete from staff_info where name = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Deleted successfully.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlCommand cm = new SqlCommand("select name, gender, ethnic, designation from staff_info where " + filterbox.Text + " = '" + searchWord + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["name"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString(), dr["gender"].ToString(), dr["designation"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            LoadSearch(searchbox.Text);
        }

        //lock / unlock thanh search
        private void filterbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterbox.Text == "Họ tên" || filterbox.Text == "Giới tính" || filterbox.Text == "Dân tộc" || filterbox.Text == "Chức vụ")
            {
                searchbox.Enabled = true;
            }
            else
            {
                searchbox.Enabled = false;
            }
        }
    }
}
