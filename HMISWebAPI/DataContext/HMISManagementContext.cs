using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models.Models;

#nullable disable

namespace HMISWebAPI.DataContext
{
    public partial class HMISManagementContext : DbContext
    {
        public HMISManagementContext()
        {
        }

        public HMISManagementContext(DbContextOptions<HMISManagementContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<TblAreaSetupNew> TblAreaSetupNews { get; set; }
        //public virtual DbSet<TblCitySetup> TblCitySetups { get; set; }
        //public virtual DbSet<TblCompanyClientSetup> TblCompanyClientSetups { get; set; }
        //public virtual DbSet<TblCompanySetup> TblCompanySetups { get; set; }
        //public virtual DbSet<TblDepartmentSetup> TblDepartmentSetups { get; set; }

        public virtual DbSet<AreaSetupNew> areaSetupNews { get; set; }
        public virtual DbSet<CitySetup> citySetups { get; set; }
        public virtual DbSet<CompanyClientSetup> companyClientSetups { get; set; }
        public virtual DbSet<CompanySetup> companySetups { get; set; }
        public virtual DbSet<DepartmentSetup> departmentSetups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-7P10DAH\\SQLEXPRESS;Database=HMISManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AreaSetupNew>(entity =>
            {
                entity.HasKey(e => e.AreaCode);

                entity.ToTable("tbl_AreaSetupNew");

                entity.Property(e => e.AreaCode)
                    .HasMaxLength(50)
                    .HasColumnName("AREA_CODE");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("CITY_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.MakerDatetime)
                    .HasColumnType("date")
                    .HasColumnName("MAKER_DATETIME");

                entity.Property(e => e.MakerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MAKER_ID");

                entity.Property(e => e.MakerwrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("MAKERWRKST_ID");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATE_ID");

                entity.Property(e => e.UpdatewrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEWRKST_ID");
            });

            modelBuilder.Entity<CitySetup>(entity =>
            {
                entity.HasKey(e => e.CityCode);

                entity.ToTable("tbl_CitySetup");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(50)
                    .HasColumnName("CITY_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.MakerDatetime)
                    .HasColumnType("date")
                    .HasColumnName("MAKER_DATETIME");

                entity.Property(e => e.MakerId)
                    .HasMaxLength(50)
                    .HasColumnName("MAKER_ID");

                entity.Property(e => e.MakerwrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("MAKERWRKST_ID");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATE_ID");

                entity.Property(e => e.UpdatewrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEWRKST_ID");
            });

            modelBuilder.Entity<CompanyClientSetup>(entity =>
            {
                entity.HasKey(e => e.CmpnyClintCode);

                entity.ToTable("tbl_CompanyClientSetup");

                entity.Property(e => e.CmpnyClintCode)
                    .HasMaxLength(6)
                    .HasColumnName("CMPNY_CLINT_CODE");

                entity.Property(e => e.CmpnyAddres)
                    .HasMaxLength(100)
                    .HasColumnName("CMPNY_ADDRES");

                entity.Property(e => e.CmpnyAddres1)
                    .HasMaxLength(100)
                    .HasColumnName("CMPNY_ADDRES1");

                entity.Property(e => e.CmpnyAddres2)
                    .HasMaxLength(100)
                    .HasColumnName("CMPNY_ADDRES2");

                entity.Property(e => e.CmpnyClintName)
                    .HasMaxLength(60)
                    .HasColumnName("CMPNY_CLINT_NAME");

                entity.Property(e => e.CmpnyContNo)
                    .HasMaxLength(25)
                    .HasColumnName("CMPNY_CONT_NO");

                entity.Property(e => e.MakerDatetime)
                    .HasColumnType("date")
                    .HasColumnName("MAKER_DATETIME");

                entity.Property(e => e.MakerId)
                    .HasMaxLength(20)
                    .HasColumnName("MAKER_ID");

                entity.Property(e => e.MakerwrkstId)
                    .HasMaxLength(30)
                    .HasColumnName("MAKERWRKST_ID");

                entity.Property(e => e.OldClientId)
                    .HasMaxLength(6)
                    .HasColumnName("OLD_CLIENT_ID");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(20)
                    .HasColumnName("UPDATE_ID");

                entity.Property(e => e.UpdatewrkstId)
                    .HasMaxLength(30)
                    .HasColumnName("UPDATEWRKST_ID");
            });

            modelBuilder.Entity<CompanySetup>(entity =>
            {
                entity.HasKey(e => e.CmpnyCode);

                entity.ToTable("tbl_CompanySetup");

                entity.Property(e => e.CmpnyCode)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_CODE");

                entity.Property(e => e.CmpnyAddres)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_ADDRES");

                entity.Property(e => e.CmpnyAddres1)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_ADDRES1");

                entity.Property(e => e.CmpnyAddres2)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_ADDRES2");

                entity.Property(e => e.CmpnyContDesig)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_CONT_DESIG");

                entity.Property(e => e.CmpnyContNo)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_CONT_NO");

                entity.Property(e => e.CmpnyContPerson)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_CONT_PERSON");

                entity.Property(e => e.CmpnyDiscount).HasColumnName("CMPNY_DISCOUNT");

                entity.Property(e => e.CmpnyEbsAccNo)
                    .HasMaxLength(200)
                    .HasColumnName("CMPNY_EBS_ACC_NO");

                entity.Property(e => e.CmpnyEmail)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_EMAIL");

                entity.Property(e => e.CmpnyFaxNo)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_FAX_NO");

                entity.Property(e => e.CmpnyFlag).HasColumnName("CMPNY_FLAG");

                entity.Property(e => e.CmpnyGlCode)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_GL_CODE");

                entity.Property(e => e.CmpnyLandLine)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_LAND_LINE");

                entity.Property(e => e.CmpnyLogo)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_LOGO");

                entity.Property(e => e.CmpnyName)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_NAME");

                entity.Property(e => e.CmpnyOldCId)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_OLD_C_ID");

                entity.Property(e => e.CmpnyPkgRateRef)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_PKG_RATE_REF");

                entity.Property(e => e.CmpnySlogin)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_SLOGIN");

                entity.Property(e => e.CmpnyStatus).HasColumnName("CMPNY_STATUS");

                entity.Property(e => e.CmpnyUanNo)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_UAN_NO");

                entity.Property(e => e.CmpnyUrl)
                    .HasMaxLength(150)
                    .HasColumnName("CMPNY_URL");

                entity.Property(e => e.CmpnyZakat).HasColumnName("CMPNY_ZAKAT");

                entity.Property(e => e.MakerDatetime)
                    .HasColumnType("date")
                    .HasColumnName("MAKER_DATETIME");

                entity.Property(e => e.MakerId)
                    .HasMaxLength(150)
                    .HasColumnName("MAKER_ID");

                entity.Property(e => e.MakerwrkstId)
                    .HasMaxLength(150)
                    .HasColumnName("MAKERWRKST_ID");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(150)
                    .HasColumnName("UPDATE_ID");

                entity.Property(e => e.UpdatewrkstId)
                    .HasMaxLength(150)
                    .HasColumnName("UPDATEWRKST_ID");
            });

            modelBuilder.Entity<DepartmentSetup>(entity =>
            {
                entity.HasKey(e => e.DptCode);

                entity.ToTable("tbl_DepartmentSetup");

                entity.Property(e => e.DptCode)
                    .HasMaxLength(50)
                    .HasColumnName("DPT_CODE");

                entity.Property(e => e.DptDescription)
                    .HasMaxLength(100)
                    .HasColumnName("DPT_DESCRIPTION");

                entity.Property(e => e.DptStatus).HasColumnName("DPT_STATUS");

                entity.Property(e => e.EbsDptCode)
                    .HasMaxLength(50)
                    .HasColumnName("EBS_DPT_CODE");

                entity.Property(e => e.MakerDatetime)
                    .HasColumnType("date")
                    .HasColumnName("MAKER_DATETIME");

                entity.Property(e => e.MakerId)
                    .HasMaxLength(50)
                    .HasColumnName("MAKER_ID");

                entity.Property(e => e.MakerwrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("MAKERWRKST_ID");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnType("date")
                    .HasColumnName("UPDATE_DATETIME");

                entity.Property(e => e.UpdateId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATE_ID");

                entity.Property(e => e.UpdatewrkstId)
                    .HasMaxLength(50)
                    .HasColumnName("UPDATEWRKST_ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
