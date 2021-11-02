using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Add_Staff : Form
    {
        SqlConnection cn;
        ClassDB db = new ClassDB();
        MngStaff f;
        string _title = "School Management System";

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

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (namebox.Text == "" | designationbox.Text == "" | genderbox.Text == "" | idbox.Text == "" | qualificationbox.Text == "")
                {
                    MessageBox.Show("No fields must be left blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                if (MessageBox.Show("Are you sure all staff details are correct?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand("INSERT INTO staff_info(id, name, dob, gender, designation, qualification)VALUES(@id, @name, @dob, @gender, @designation, @qualification)", cn);
                    cm.Parameters.AddWithValue("@id", idbox.Text);
                    cm.Parameters.AddWithValue("@name", namebox.Text);
                    cm.Parameters.AddWithValue("@dob", dateofbirthbox.Text);
                    cm.Parameters.AddWithValue("@gender", genderbox.Text);
                    cm.Parameters.AddWithValue("@designation", designationbox.Text);
                    cm.Parameters.AddWithValue("@qualification", qualificationbox.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Info has successfully saved!", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            namebox.Clear();
            genderbox.Text = "";
            designationbox.Text = "";
            qualificationbox.Clear();
            idbox.Clear();
            dateofbirthbox.Value = DateTime.Now;
        }
    }
}
