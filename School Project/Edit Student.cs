using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Edit_Student : Form
    {
        SqlConnection cn;
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
            try
            {
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE student_info SET class = @class, age = @age, gender = @gender, dob = @dob, pob = @pob, ethnic = @ethnic, nationality = @nationality, hometown = @hometown, home_address = @home_address, mom_name = @mom_name, dad_name = @dad_name, guardian_name = @guardian_name, height = @height, weight = @weight where name = @name", cn);
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
                    cm.Parameters.AddWithValue("@name", namebox.Text);
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
    }
}
