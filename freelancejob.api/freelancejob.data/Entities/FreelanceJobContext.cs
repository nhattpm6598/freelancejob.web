using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace freelancejob.data.Entities
{
    public partial class FreelanceJobContext : DbContext
    {
        public FreelanceJobContext(DbContextOptions<FreelanceJobContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblConvenant> TblConvenants { get; set; }
        public virtual DbSet<TblJob> TblJobs { get; set; }
        public virtual DbSet<TblJobRequest> TblJobRequests { get; set; }
        public virtual DbSet<TblReport> TblReports { get; set; }
        public virtual DbSet<TblSkillExpertise> TblSkillExpertises { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblUserSkill> TblUserSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                return;
            }

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tbl_Category");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblConvenant>(entity =>
            {
                entity.ToTable("tbl_Convenant");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblJob>(entity =>
            {
                entity.ToTable("tbl_Job");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Price).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblJobRequest>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.SkillId });

                entity.ToTable("tbl_JobRequest");
            });

            modelBuilder.Entity<TblReport>(entity =>
            {
                entity.ToTable("tbl_Report");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSkillExpertise>(entity =>
            {
                entity.ToTable("tbl_SkillExpertise");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tbl_User");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.Firstname).HasMaxLength(50);

                entity.Property(e => e.Languages).HasMaxLength(50);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Major).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Verifications).HasMaxLength(50);
            });

            modelBuilder.Entity<TblUserSkill>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SkillId });

                entity.ToTable("tbl_UserSkill");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
