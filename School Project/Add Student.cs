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
    public partial class Add_Student : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        ClassDB db = new ClassDB();
        string _title = "School Management System";

        public Add_Student()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            agebox.Text = years(dateofbirthbox.Value.Date, DateTime.Now.Date).ToString();
        }
        
        int years(DateTime start, DateTime end)
        {
            return (end.Year - start.Year - 1) + (((end.Month > start.Month) || (end.Month == start.Month) && (end.Day >= start.Day)) ? 1 : 0);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (namebox.Text == "" | classbox.Text == "" | genderbox.Text == "")
                {
                    MessageBox.Show("No fields must be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Are you sure all the student details are entered correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   

                    cn.Open();
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.CommandText = "add_student";
                    cm.Parameters.AddWithValue("@id", idbox.Text);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.Parameters.AddWithValue("@class", classbox.Text);
                    cm.Parameters.AddWithValue("@age", agebox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.SelectedItem);
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Value);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Record has successfully saved!", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            genderbox.Text = "";
            classbox.Clear();
            agebox.Clear();
        }

        private void genderbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }
    }
}
