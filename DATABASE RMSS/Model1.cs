using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DATABASE_RMSS
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ACCOUNT_RECRUITER> ACCOUNT_RECRUITER { get; set; }
        public virtual DbSet<ANSWER> ANSWER { get; set; }
        public virtual DbSet<CANDIDATE_APPLY> CANDIDATE_APPLY { get; set; }
        public virtual DbSet<INFO_COMPANY> INFO_COMPANY { get; set; }
        public virtual DbSet<JOBS_QAs> JOBS_QA { get; set; }
        public virtual DbSet<MANAGEJOB> MANAGEJOB { get; set; }
        public virtual DbSet<POST> POSTS { get; set; }
        public virtual DbSet<QUESTION> QUESTION { get; set; }
        public virtual DbSet<sysdiagram> sysdiagram { get; set; }
        public virtual DbSet<CANDIDATE_TEST> CANDIDATE_TEST { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT_RECRUITER>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT_RECRUITER>()
                .Property(e => e.PASSWORDS)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT_RECRUITER>()
                .Property(e => e.ROLE_)
                .IsUnicode(false);

            modelBuilder.Entity<CANDIDATE_APPLY>()
                .Property(e => e.PHONE_CANDIDATE)
                .IsUnicode(false);

            modelBuilder.Entity<CANDIDATE_APPLY>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<INFO_COMPANY>()
                .Property(e => e.PHONE_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<INFO_COMPANY>()
                .Property(e => e.EMAIL_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<INFO_COMPANY>()
                .Property(e => e.LOGO_COMPANY)
                .IsUnicode(false);

            modelBuilder.Entity<MANAGEJOB>()
                .Property(e => e.OPENAPPLY)
                .IsUnicode(false);
        }
    }
}
