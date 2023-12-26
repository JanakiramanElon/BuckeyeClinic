using BuckeyeClinic.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BuckeyeClinic
{
    public class PatientInfoDb : DbContext
    {
        public IConfiguration Configuration { get; }
        public PatientInfoDb()
        {

        }
        public PatientInfoDb(DbContextOptions<PatientInfoDb> options) : base(options)
        {

        }
        public DbSet<PatientInfo> PatientInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
            optionsBuilder.UseSqlServer(ConnectionHelper.ConnectionString);
        }
    }
}
