using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace School_Project
{
    public partial class Mainwindow : Form
    {
        public Mainwindow()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Manage_Students_Click(object sender, EventArgs e)
        {
            Mngstudent s = new Mngstudent();
            s.LoadRecords();
            s.ShowDialog();
        }
    }
}
