namespace School_Project
{
    class ClassDB
    {
        public string GetConnection()
        {
            string cn = "Server=tcp:ktpm20211.database.windows.net,1433;Initial Catalog=ktpm;Persist Security Info=False;User ID=anhlee;Password=Ktpm20211;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return cn;
        }
    }
}
