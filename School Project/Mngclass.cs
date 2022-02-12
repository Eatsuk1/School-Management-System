using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mngclass : Form
    {
        #region khởi tạo tham số ban đầu cần thiết

        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";

        public Mngclass()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        #endregion khởi tạo tham số ban đầu cần thiết

        public void LoadRecordsTch()
        {
            dataGridViewtch.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select R9.maGiaoVien, R1.tenGiaoVien from R9, R1 where tenLop = '" + classbox.Text + "' and Namhoc = '" + schoolyearbox.Text + "' and R9.maGiaoVien = R1.maGiaoVien", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridViewtch.Rows.Add(dr["maGiaoVien"].ToString(), dr["tenGiaoVien"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadRecordStd()
        {
            dataGridViewstd.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select R10.maHocSinh, R2.tenHocSinh from R10, R2 where tenLop = '" + classbox.Text + "' and Namhoc = '" + schoolyearbox.Text + "' and R10.maHocSinh = R2.maHocSinh", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridViewstd.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void Loadclass()
        {
            try
            {
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                cn.Open();
                SqlCommand cm = new SqlCommand("select R3.maGVCN, R3.maLoptruong, R3.Siso, R1.tenGiaoVien, R2.tenHocSinh from R3, R1, R2 where tenLop = '" + classbox.Text + "' and Namhoc = '" + schoolyearbox.Text + "' and R3.maGVCN = R1.maGiaoVien and R3.maLoptruong = R2.maHocSinh", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                textBox1.Text = dr["tenGiaoVien"].ToString();
                textBox2.Text = dr["tenHocSinh"].ToString();
                textBox3.Text = dr["Siso"].ToString();
                dr.Close();
                cn.Close();
            }
            catch (Exception ex)
            {
                cn.Close();
                if (!Settings1.Default.Dontshow)
                {
                    new Formerrorclass().ShowDialog();
                }
            }
        }

        public int Siso()
        {
            int a = dataGridViewstd.Rows.Count;
            return a;
        }

        //thêm lớp
        private void addbutton_Click(object sender, EventArgs e)
        {
            Formaddclass s = new Formaddclass();
            s.ShowDialog();
        }

        private void classbox_Click(object sender, EventArgs e)
        {
            classbox.Items.Clear();
            cn.Open();
            var a = new SqlCommand("select tenLop from R14", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                classbox.Items.Add(dr["tenLop"].ToString());
            }
            dr.Close(); cn.Close();
        }

        private void schoolyearbox_Click(object sender, EventArgs e)
        {
            schoolyearbox.Items.Clear();
            cn.Open();
            var a = new SqlCommand("select Namhoc from R15", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                schoolyearbox.Items.Add(dr["Namhoc"].ToString());
            }
            dr.Close(); cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3(this);
            s.LoadRecords(); s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa giáo viên này khỏi lớp?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("delete from R9 where maGiaoVien = '" + dataGridViewtch.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Đã xóa giáo viên vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordsTch();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 s = new Form4(this);
            s.LoadRecords(); s.ShowDialog();
        }

        private void classbox_TextChanged(object sender, EventArgs e)
        {
            LoadRecordsTch();
            LoadRecordStd();
            Loadclass();
        }

        private void schoolyearbox_TextChanged(object sender, EventArgs e)
        {
            LoadRecordsTch();
            LoadRecordStd();
            Loadclass();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa học sinh này khỏi lớp?", _title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cm = new SqlCommand("delete from R10 where maHocSinh = '" + dataGridViewstd.CurrentRow.Cells[0].Value.ToString() + "'", cn);
                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Đã xóa học sinh vừa chọn", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordStd();
                cn.Open();
                var a = new SqlCommand("update R3 set Siso = @Siso where tenLop = '" + classbox.Text + "' and Namhoc = '" + schoolyearbox.Text + "'", cn);
                a.Parameters.AddWithValue("Siso", Siso());
                a.ExecuteNonQuery();
                cn.Close();
                Loadclass();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                int i = 0;
                var cm = new SqlCommand("select tenLop, Namhoc from R3", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["tenLop"].ToString() == classbox.Text && dr["Namhoc"].ToString() == schoolyearbox.Text)
                    {
                        i++;
                    }
                }
                if (i == 0)
                {
                    var a = new SqlCommand("insert into R3(tenLop, Siso, Namhoc, maGVCN, maLoptruong) values(@tenLop, @Siso, @Namhoc, @maGVCN, @maLoptruong)", cn);
                    a.Parameters.AddWithValue("tenLop", classbox.Text);
                    a.Parameters.AddWithValue("Siso", Siso());
                    a.Parameters.AddWithValue("Namhoc", schoolyearbox.Text);
                    a.Parameters.AddWithValue("maGVCN", dataGridViewtch.CurrentRow.Cells[0].Value.ToString());
                    a.Parameters.AddWithValue("maLoptruong", dataGridViewstd.CurrentRow.Cells[0].Value.ToString());
                    a.ExecuteNonQuery();
                    dr.Close();
                    cn.Close();
                    MessageBox.Show("Đã đặt giáo viên chủ nhiệm và lớp trưởng", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecordsTch();
                    LoadRecordStd();
                    Loadclass();
                }
                else
                {
                    dr.Close();
                    cn.Close();
                    MessageBox.Show("Lớp đã có giáo viên chủ nhiệm và lớp trưởng", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                var a = new SqlCommand("update R3 set maGVCN = @maGVCN, maLoptruong = @maLoptruong where tenLop = '" + classbox.Text + "' and Namhoc = '" + schoolyearbox.Text + "'", cn);
                a.Parameters.AddWithValue("maGVCN", dataGridViewtch.CurrentRow.Cells[0].Value.ToString());
                a.Parameters.AddWithValue("maLoptruong", dataGridViewstd.CurrentRow.Cells[0].Value.ToString());
                a.ExecuteNonQuery(); cn.Close();
                MessageBox.Show("Đã đổi giáo viên chủ nhiệm và lớp trưởng", _title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRecordsTch();
                LoadRecordStd();
                Loadclass();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}