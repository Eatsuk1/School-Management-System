using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class MngStaff : Form
    {
        SqlConnection cn;
        SqlDataReader dr;
        ClassDB db = new ClassDB();
        string _title = "School Management System";
        public MngStaff()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from staff_info", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["id"].ToString(), dr["name"].ToString(), DateTime.Parse(dr["dob"].ToString()).ToShortDateString(), dr["gender"].ToString(), dr["designation"].ToString(), dr["qualification"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Staff s = new Add_Staff(this);
            s.ShowDialog();
        }

        private void MngStaff_Load(object sender, EventArgs e)
        {

        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            Edit_Staff f = new Edit_Staff(this);
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from staff_info where id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                f.idbox.Text = dr["id"].ToString();
                f.namebox.Text = dr["name"].ToString();
                f.dateofbirthbox.Text = dr["dob"].ToString();
                f.genderbox.Text = dr["gender"].ToString();
                f.designationbox.Text = dr["designation"].ToString();
                f.qualificationbox.Text = dr["qualification"].ToString();
            }
            dr.Close();
            cn.Close();
            f.ShowDialog();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete? Click Yes to confirm", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SqlCommand cm = new SqlCommand("delete from staff_info where id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Deleted successfully.", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecords();
            }
        }

        private void filterbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
