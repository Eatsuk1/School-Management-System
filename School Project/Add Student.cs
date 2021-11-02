using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Add_Student : Form
    {
        SqlConnection cn;
        ClassDB db = new ClassDB();
        Mngstudent f;
        string _title = "Hệ thống quản lý";

        public Add_Student(Mngstudent f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        //tự động tinh tuổi khi nhập ngày sinh (thông qua hàm years)
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            agebox.Text = years(dateofbirthbox.Value.Date, DateTime.Now.Date).ToString();
        }

        int years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) + (((end.Month > start.Month) || (end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
        }        

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {
            //tạo list các textbox để kiểm tra đã điền đủ hay chưa
            List<string> textbox = new List<string>();
            textbox.Add(namebox.Text); textbox.Add(classbox.Text); textbox.Add(genderbox.Text); textbox.Add(placeofbirthbox.Text);
            textbox.Add(ethnicbox.Text); textbox.Add(nationalitybox.Text); textbox.Add(hometownbox.Text); textbox.Add(addressbox.Text);
            textbox.Add(momnamebox.Text); textbox.Add(dadnamebox.Text); textbox.Add(heightbox.Text); textbox.Add(weightbox.Text);

            try
            {
                foreach (string s in textbox) {
                    if (string.IsNullOrEmpty(s))
                    {
                        MessageBox.Show("Thông tin điền thiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return;
                    }
                }
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO student_info(name, class, age, gender, dob, pob, ethnic, nationality, hometown, home_address, mom_name, dad_name, guardian_name, height, weight)VALUES(@name, @class, @age, @gender, @dob, @pob, @ethnic, @nationality, @hometown, @home_address, @mom_name, @dad_name, @guardian_name, @height, @weight)", cn);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.Parameters.AddWithValue("@class", classbox.Text);
                    cm.Parameters.AddWithValue("@age", agebox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.SelectedItem.ToString());
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@pob", placeofbirthbox.Text);
                    cm.Parameters.AddWithValue("@ethnic", ethnicbox.Text);
                    cm.Parameters.AddWithValue("@nationality", nationalitybox.Text);
                    cm.Parameters.AddWithValue("@hometown", hometownbox.Text);
                    cm.Parameters.AddWithValue("@home_address", addressbox.Text);
                    cm.Parameters.AddWithValue("@mom_name", momnamebox.Text);
                    cm.Parameters.AddWithValue("@dad_name", dadnamebox.Text);
                    cm.Parameters.AddWithValue("@guardian_name", guardiannamebox.Text);
                    cm.Parameters.AddWithValue("@height", heightbox.Text);
                    cm.Parameters.AddWithValue("@weight", weightbox.Text);
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
            genderbox.Text = "";
            classbox.Clear();
            agebox.Text = "";
            ethnicbox.Clear();
            nationalitybox.Clear();
            placeofbirthbox.Clear();
            hometownbox.Clear();
            addressbox.Clear();
            momnamebox.Clear(); dadnamebox.Clear(); guardiannamebox.Clear();
            dateofbirthbox.Value = DateTime.Now;
        }

        private void genderbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void ethnicbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void placeofbirth_Click(object sender, EventArgs e)
        {

        }
    }
}
