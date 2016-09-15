using ConsoleScrapbook.FormBuilderAPI.Forms;
using ConsoleScrapbook.FormBuilderAPI.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleScrapbook.FormBuilderAPI.Infrastructure
{
    class FormAppDbContext : DbContext
    {
        public FormAppDbContext()
        {

        }

        // Modules
        public DbSet<CounterSig> CounterSig { get; set; }
        public DbSet<EqualityMon> EqualityMon { get; set; }
        public DbSet<FTPDec> FTPDec { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<PhotoCert> PhotoCert { get; set; }
        public DbSet<PreviousReg> PreviousReg { get; set; }
        public DbSet<Qualification> Qualification { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Tutor> Tutor { get; set; }
        public DbSet<WorkExp> WorkExp { get; set; }

        // Forms
        public DbSet<NonRegForm> NonRegForm { get; set; }
        public DbSet<PreregForm> PreregForm { get; set; }
        public DbSet<TechnicianForm> TechnicianForm { get; set; }

    }
}
