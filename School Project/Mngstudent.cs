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
        string _title = "School Management System";
        public Mngstudent()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from student_info", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["class"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }

        private void Mngstudent_Load(object sender, EventArgs e)
        {

        }

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Student s = new Add_Student(this);
            s.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Student f = new Edit_Student(this);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from student_info where id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.idbox.Text = dr["id"].ToString();
                f.namebox.Text = dr["name"].ToString();
                f.classbox.Text = dr["class"].ToString();
                f.agebox.Text = dr["age"].ToString();
                f.genderbox.Text = dr["gender"].ToString();
                f.dateofbirthbox.Text = dr["dob"].ToString();
            }
            dr.Close();
            cn.Close();
            f.ShowDialog();

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete? Click Yes to confirm", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cm = new SqlCommand("delete from student_info where id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
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

        public void LoadSearch(string searchWord)
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from student_info where " + filterbox.Text + " = '" + searchWord + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), dr["class"].ToString(), dr["age"].ToString(), dr["gender"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString());
            }
            dr.Close();
            cn.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void filterbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterbox.Text == "ID" || filterbox.Text == "Name" || filterbox.Text == "Class" || filterbox.Text == "Age" || filterbox.Text == "Gender")
            {
                searchbox.Enabled = true;
            }
            else
            {
                searchbox.Enabled = false;
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            LoadSearch(searchbox.Text);
        }
    }
}
