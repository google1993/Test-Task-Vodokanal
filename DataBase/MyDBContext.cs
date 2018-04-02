using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestsVodokanal.DataBase
{
    class MyDBContext : DbContext
    {
        private string connectionString;
        private bool sqlProvider;

        public MyDBContext() : base()
        {
            sqlProvider = true;
            connectionString = "Server = cron-vs.tk; Database = Vodokanal; Uid = vodokanal; Pwd = test1282test; Charset = utf8";
        }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<States> States { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (sqlProvider)
                optionsBuilder.UseMySQL(connectionString);
            else
                optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
