namespace phukienipadx.Dal
{
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Data;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.ComponentModel;
    using System;
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