using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace School_Project
{
    public partial class Form5 : Form
    {
        private SqlConnection cn;
        private SqlDataReader dr;
        private ClassDB db = new ClassDB();
        private string _title = "Hệ thống quản lý";
        private MngMarks s;
        private string none = "";

        public Form5()
        {
            InitializeComponent();
            cn = new SqlConnection();
            cn.ConnectionString = db.GetConnection();
        }

        public void LoadRecords()
        {
            cn.Open();
            var a = new SqlCommand("select tenMonHoc, Diemso from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "'", cn);
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["tenMonHoc"].ToString(), dr["Diemso"].ToString());
            }
            dr.Close();
        }

        public void LoadRecords2()
        {
            List<string> monhoc = new List<string>();
            cn.Open();
            var a = new SqlCommand("select * from R16");
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                monhoc.Add(dr["tenMonHoc"].ToString());
            }
            dr.Close(); cn.Close();

            List<string> monmoi = new List<string>();
            cn.Open();
            var b = new SqlCommand("select * from R4 where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "'",cn);
            dr = b.ExecuteReader();
            for(int i = 0; i < monhoc.Count; i++)
            {
                int k = 0;
                while(dr.Read())
                {
                    if(dr["tenMonHoc"].ToString() == monhoc[i])
                    {
                        k++;
                    }
                }
                if(k == 0)
                {
                    monmoi.Add(monhoc[i]);
                }
            }
            if(monmoi.Count > 0)
            {
                foreach (string monmo in monmoi)
                {
                    var c = new SqlCommand("insert into R4(maHocSinh, tenMonHoc, Diemso, maNangLuc, maPhamchat, Kyhoc, Namhoc, tenLop) values(@maHocSinh, @tenMonHoc, @Diemso, @maNangLuc, @maPhamchat, @Kyhoc, @Namhoc, @tenLop)", cn);
                    c.Parameters.AddWithValue("maHocSinh", s.dataGridView1.CurrentRow.Cells[0].ToString());
                    c.Parameters.AddWithValue("tenMonHoc", monmo);
                    c.Parameters.AddWithValue("Diemso", none);
                    c.Parameters.AddWithValue("maNangLuc", none);
                    c.Parameters.AddWithValue("maPhamchat", none);
                    c.Parameters.AddWithValue("Kyhoc", s.comboBox2.Text);
                    c.Parameters.AddWithValue("Namhoc", s.comboBox3.Text);
                    c.Parameters.AddWithValue("tenLop", s.comboBox1.Text);
                    c.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> monhoc = new List<string>();
            cn.Open();
            var a = new SqlCommand("select * from R16");
            dr = a.ExecuteReader();
            while (dr.Read())
            {
                monhoc.Add(dr["tenMonHoc"].ToString());
            }
            dr.Close(); cn.Close();
            

            cn.Open();
            /*foreach ()
            {
                var b = new SqlCommand("update R4 set Diemso = @Diemso where maHocSinh = '" + s.dataGridView1.CurrentRow.Cells[0].ToString() + "' and Kyhoc = '" + s.comboBox2.Text + "' and Namhoc = '" + s.comboBox3.Text + "' and tenMonHoc = '" + monho + "'", cn);
                b.Parameters.AddWithValue("Diemso",)
            }*/

        }
    }
}
