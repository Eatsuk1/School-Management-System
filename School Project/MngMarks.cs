using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Project
{
    public partial class MngMarks : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private string none = "";

        public MngMarks()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadRecords()
        {
            dataGridView1.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("select maHocSinh, tenHocSinh from R10 where tenLop = '" + comboBox1.Text + "' and Namhoc = '" + comboBox3.Text + "'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["maHocSinh"].ToString(), dr["tenHocSinh"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            cn.Open();
            var a = new SqlCommand("select tenLop from R14", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["tenLop"].ToString());
            }
            dr.Close(); cn.Close();
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            cn.Open();
            var a = new SqlCommand("select Namhoc from R15", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["Namhoc"].ToString());
            }
            dr.Close(); cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<string> monhoc = new List<string>();
            //cn.Open();
            //var a = new SqlCommand("select * from R16", cn);
            //dr = a.ExecuteReader();
            //while (dr.Read())
            //{
            //    monhoc.Add(dr["tenMonHoc"].ToString());
            //}
            //dr.Close(); cn.Close();

            Form5 s = new Form5(this);
            Form6 s1 = new Form6(this);

            cn.Open();
            var b = new SqlCommand("select * from R4 where maHocSinh = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "' and Kyhoc = '" + comboBox2.Text + "' and Namhoc = '" + comboBox3.Text + "'", cn);
            dr = b.ExecuteReader();
            if (dr.HasRows)
            {
                
                
                    dr.Close();
                    cn.Close();
                
                    s1.LoadRecords();
                    s1.ShowDialog();
                
            }
            else
            {
                //try
                //{
                //    dr.Close();

                //    #region bỏ đi

                //    /*var cm = new SqlCommand("insert into R6(TuphucvuTuquan, Hoptac, Tuhocvagiaiquyetvande) values(@TuphucvuTuquan, @Hoptac, @Tuhocvagiaiquyetvande)", cn);
                //    cm.Parameters.AddWithValue("TuphucvuTuquan", none);
                //    cm.Parameters.AddWithValue("Hoptac", none);
                //    cm.Parameters.AddWithValue("Tuhocvagiaiquyetvande", none);
                //    cm.ExecuteNonQuery();

                //    var cm2 = new SqlCommand("select maNangLuc from R6 where TuphucvuTuquan = '" + none + "' and Hoptac = '" + none + "' and Tuhocvagiaiquyetvande = '" + none + "'", cn);
                //    dr = cm2.ExecuteReader(); dr.Read(); string temp = dr["maNangLuc"].ToString(); dr.Close();

                //    var cm1 = new SqlCommand("insert into R7(ChamhocChamlam, TutinTrachnhiem, TrungthucKyluat, DoanketYeuthuong) values(@ChamhocChamlam, @TutinTrachnhiem, @TrungthucKyluat, @DoanketYeuthuong)", cn);
                //    cm1.Parameters.AddWithValue("ChamhocChamlam", none);
                //    cm1.Parameters.AddWithValue("TutinTrachnhiem", none);
                //    cm1.Parameters.AddWithValue("TrungthucKyluat", none);
                //    cm1.Parameters.AddWithValue("DoanketYeuthuong", none);
                //    cm1.ExecuteNonQuery();

                //    var cm3 = new SqlCommand("select maPhamchat from R7 where ChamhocChamlam = '" + none + "' and TutinTrachnhiem = '" + none + "' and TrungthucKyluat = '" + none + "' and DoanketYeuthuong = '" + none + "'", cn);
                //    dr = cm3.ExecuteReader(); dr.Read(); string temp1 = dr["maPhamchat"].ToString(); dr.Close();*/

                //    #endregion bỏ đi

                //    foreach (var item in monhoc)
                //    {
                //        var c = new SqlCommand("insert into R4(maHocSinh, tenMonHoc, Diemso, maNangLuc, maPhamchat, Kyhoc, Namhoc, tenLop) values(@maHocSinh, @tenMonHoc, @Diemso, @maNangLuc, @maPhamchat, @Kyhoc, @Namhoc, @tenLop)", cn);
                //        c.Parameters.AddWithValue("maHocSinh", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                //        c.Parameters.AddWithValue("Diemso", none);
                //        c.Parameters.AddWithValue("tenMonHoc", item);
                //        c.Parameters.AddWithValue("maNangLuc", none);
                //        c.Parameters.AddWithValue("maPhamchat", none);
                //        c.Parameters.AddWithValue("Kyhoc", comboBox2.Text);
                //        c.Parameters.AddWithValue("Namhoc", comboBox3.Text);
                //        c.Parameters.AddWithValue("tenLop", comboBox1.Text);
                //        c.ExecuteNonQuery();
                //    }
                //    cn.Close();
                //    s.LoadRecords(); s.ShowDialog();
                //}
                //catch (Exception ex)
                //{
                //    cn.Close();
                //    MessageBox.Show(ex.Message, _title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                dr.Close();
                cn.Close();
                
                s.LoadRecords2();
                s.ShowDialog();
            
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}