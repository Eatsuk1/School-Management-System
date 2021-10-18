using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Project
{
    public partial class Edit_Student : Form
    {
        SqlConnection cn;
        ClassDB db = new ClassDB();
        Mngstudent f;
        string _title = "School Management System";
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

        private void dateofbirth_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure all student details are corrected?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("UPDATE student_info SET name = @name, class = @class, age = @age, gender = @gender, dob = @dob where id =@id", cn);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.Parameters.AddWithValue("@class", classbox.Text);
                    cm.Parameters.AddWithValue("@age", agebox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.Text);
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@id", idbox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has successfully updated!", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dateofbirthbox_ValueChanged(object sender, EventArgs e)
        {
            agebox.Text = years(dateofbirthbox.Value.Date, DateTime.Now.Date).ToString();
        }

        int years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) + (((end.Month > start.Month) || (end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
        }
    }
}
