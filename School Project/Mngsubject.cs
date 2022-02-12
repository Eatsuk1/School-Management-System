using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mngsubject : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";

        public Mngsubject()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadSubject()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select * from R16", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenMonHoc"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var a = new SqlCommand("insert into R16(tenMonHoc) values(@tenMonHoc)", cn);
                a.Parameters.AddWithValue("tenMonHoc", textBox1.Text);
                a.ExecuteNonQuery();
                cn.Close();
                LoadSubject();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var a = new SqlCommand("Delete from R16 where tenMonHoc = '" + dataGridView1.CurrentCell.Value.ToString() + "'", cn);
                a.ExecuteNonQuery();
                MessageBox.Show("Đã xóa môn học vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                LoadSubject();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}