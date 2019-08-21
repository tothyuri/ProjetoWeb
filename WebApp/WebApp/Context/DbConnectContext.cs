using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Context
{
    public class DbConnectContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
    }
}