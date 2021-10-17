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
    public partial class Mngstudent : Form
    {
        public Mngstudent()
        {
            InitializeComponent();
        }

        private void Mngstudent_Load(object sender, EventArgs e)
        {

        }
        
        private void addnewbutton_Click(object sender, EventArgs e)
        {
            Add_Student s = new Add_Student();
            s.ShowDialog();
        }
    }
}
