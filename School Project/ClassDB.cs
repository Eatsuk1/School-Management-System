using System;
using System.Collections.Generic;
using System.Text;

namespace School_Project
{
    class ClassDB
    {
        public string GetConnection()
        {
            string cn = @"Data Source=SH1RO\SQLEXPRESS;Initial Catalog=ktpm;Integrated Security=True";
            return cn;
        }
    }
}
