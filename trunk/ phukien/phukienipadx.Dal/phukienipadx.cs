namespace phukienipadx.Dal
{
    using System.Configuration;

    public partial class phukienipadxContext : phukienipadxDataContext
    {
        private static string connectionString
        {
            get { return ConfigurationManager.ConnectionStrings["PhukienConnectionString"].ConnectionString; }
        }

        public phukienipadxContext()
            : base(connectionString)
        {

        }
    }
}