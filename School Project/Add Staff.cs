using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace School_Project
{
    public partial class Add_Staff : Form
    {
        SqlConnection cn;
        ClassDB db = new ClassDB();
        MngStaff f;
        string _title = "Hệ thống quản lý";

        public Add_Staff(MngStaff f)
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
            this.f = f;
        }

        private void Add_Staff_Load(object sender, EventArgs e)
        {

        }

        //lưu thông tin
        private void savebutton_Click(object sender, EventArgs e)
        {
            //tạo list các textbox để kiểm tra đã điền đủ hay chưa
            List<string> textbox = new List<string>();
            textbox.Add(namebox.Text); textbox.Add(genderbox.Text); textbox.Add(ethnicbox.Text); textbox.Add(nationalitybox.Text);
            textbox.Add(hometownbox.Text); textbox.Add(addressbox.Text); textbox.Add(phonenumbox.Text); textbox.Add(designationbox.Text);
            textbox.Add(qualificationbox.Text);

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
                    SqlCommand cm = new SqlCommand("INSERT INTO staff_info(name, dob, gender, ethnic, nationality, hometown, current_resident, phone_number, designation, qualification)VALUES( @name, @dob, @gender, @ethnic, @nationality, @hometown, @current_resident, @phone_number, @designation, @qualification)", cn);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.Text);
                    cm.Parameters.AddWithValue("@ethnic", ethnicbox.Text);
                    cm.Parameters.AddWithValue("@nationality", nationalitybox.Text);
                    cm.Parameters.AddWithValue("@hometown", hometownbox.Text);
                    cm.Parameters.AddWithValue("@current_resident", addressbox.Text);
                    cm.Parameters.AddWithValue("@phone_number", phonenumbox.Text);
                    cm.Parameters.AddWithValue("@designation", designationbox.Text);
                    cm.Parameters.AddWithValue("@qualification", qualificationbox.Text);
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
