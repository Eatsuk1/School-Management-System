using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace School_Project
{
    public partial class Edit_Staff : Form
    {
        SqlConnection cn;
        ClassDB db = new ClassDB();
        MngStaff f;
        string _title = "Hệ thống quản lý";

        public Edit_Staff(MngStaff f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tất cả thông tin đã được nhập đúng?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE staff_info SET dob = @dob, gender = @gender, ethnic = @ethnic, nationality = @nationality, hometown = @hometown, current_resident = @current_resident, phone_number = @phone_number, designation = @designation, qualification = @qualification where name = @name", cn);
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.Text);
                    cm.Parameters.AddWithValue("@ethnic", ethnicbox.Text);
                    cm.Parameters.AddWithValue("@nationality", nationalitybox.Text);
                    cm.Parameters.AddWithValue("@hometown", hometownbox.Text);
                    cm.Parameters.AddWithValue("@current_resident", addressbox.Text);
                    cm.Parameters.AddWithValue("@phone_number", phonenumbox.Text);
                    cm.Parameters.AddWithValue("@designation", designationbox.Text);
                    cm.Parameters.AddWithValue("@qualification", qualificationbox.Text);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Cập nhật thông tin thành công", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            designationbox.Text = "";
            qualificationbox.Clear();
            dateofbirthbox.Value = DateTime.Now;
            ethnicbox.Clear();
            nationalitybox.Clear();
            hometownbox.Clear();
            addressbox.Clear();
            phonenumbox.Clear();
        }
    }
}
