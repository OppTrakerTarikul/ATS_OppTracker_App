using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace operationalTracker.Entities.Models
{
    public partial class TEST_DBContext : DbContext
    {
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Esa> Esa { get; set; }
        public virtual DbSet<Leave> Leave { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<ResourceAssignmentMap> ResourceAssignmentMap { get; set; }
        public virtual DbSet<ResourceRate> ResourceRate { get; set; }
        public virtual DbSet<Sow> Sow { get; set; }
        public virtual DbSet<Subcategory> Subcategory { get; set; }
        public virtual DbSet<TableResource> TableResource { get; set; }
        public virtual DbSet<TestData> TestData { get; set; }

        #region Constructor
        public TEST_DBContext(DbContextOptions<TEST_DBContext> options) : base(options)
        { }
        #endregion
        // Unable to generate entity type for table 'dbo.Allfiles_Query'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Allfiles_Query$'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=USADCPDM90;Initial Catalog=TEST_DB;User ID=rpdw_migration_jdbc;Password=rpdwjdbc");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.HasKey(e => e.AttendaceId);

                entity.Property(e => e.AttendaceId).HasColumnName("AttendaceID");

                entity.Property(e => e.AttendaceState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("CATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Esa>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("ESA", "OPEARATIONAL_TRACKER");

                entity.HasIndex(e => e.EsaProjectId)
                    .HasName("UQ__ESA__FF23E805B9D226FD")
                    .IsUnique();

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.EsaProjectId).HasColumnName("ESA_PROJECT_ID");

                entity.Property(e => e.EsaProjectName)
                    .HasColumnName("ESA_PROJECT_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.EsaProjectType)
                    .HasColumnName("ESA_PROJECT_TYPE")
                    .HasMaxLength(56);

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("LEAVE", "OPEARATIONAL_TRACKER");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveDesc)
                    .HasColumnName("LEAVE_DESC")
                    .HasMaxLength(200);

                entity.Property(e => e.LeaveType)
                    .HasColumnName("LEAVE_TYPE")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.ToTable("PRODUCTS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("Image_URL")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("RESOURCE", "OPEARATIONAL_TRACKER");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");

                entity.Property(e => e.ResourceLocationType)
                    .HasColumnName("RESOURCE_LOCATION_TYPE")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceName)
                    .HasColumnName("RESOURCE_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceOrgRole)
                    .HasColumnName("RESOURCE_ORG_ROLE")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceRateId).HasColumnName("RESOURCE_RATE_ID");

                entity.Property(e => e.ResourceServiceLine)
                    .HasColumnName("RESOURCE_SERVICE_LINE")
                    .HasMaxLength(156);

                entity.Property(e => e.ResourceTechnologyGroup)
                    .HasColumnName("RESOURCE_TECHNOLOGY_GROUP")
                    .HasMaxLength(56);
            });

            modelBuilder.Entity<ResourceAssignmentMap>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("RESOURCE_ASSIGNMENT_MAP", "OPEARATIONAL_TRACKER");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.AllocationPercentage)
                    .HasColumnName("ALLOCATION_PERCENTAGE")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.EsaEndDate)
                    .HasColumnName("ESA_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EsaId).HasColumnName("ESA_ID");

                entity.Property(e => e.EsaStartDate)
                    .HasColumnName("ESA_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.IsBillable)
                    .HasColumnName("IS_BILLABLE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Manager)
                    .HasColumnName("MANAGER")
                    .HasMaxLength(56);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");

                entity.Property(e => e.SowId).HasColumnName("SOW_ID");

                entity.Property(e => e.Svp)
                    .HasColumnName("SVP")
                    .HasMaxLength(156);

                entity.Property(e => e.Vp)
                    .HasColumnName("VP")
                    .HasMaxLength(56);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.ResourceAssignmentMap)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESOURCE_ASSIGNMENT");

                entity.HasOne(d => d.Sow)
                    .WithMany(p => p.ResourceAssignmentMap)
                    .HasForeignKey(d => d.SowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RESOURCE_SOW_ASSIGNMENT");
            });

            modelBuilder.Entity<ResourceRate>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("RESOURCE_RATE", "OPEARATIONAL_TRACKER");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.Grade)
                    .HasColumnName("GRADE")
                    .HasMaxLength(5);

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(40);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<Sow>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("SOW", "OPEARATIONAL_TRACKER");

                entity.Property(e => e.RowId).HasColumnName("ROW_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.EndDate)
                    .HasColumnName("END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.EsaId).HasColumnName("ESA_ID");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.OnsiteOwner)
                    .HasColumnName("ONSITE_OWNER")
                    .HasMaxLength(200);

                entity.Property(e => e.PoDate)
                    .HasColumnName("PO_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ProjectName)
                    .HasColumnName("PROJECT_NAME")
                    .HasMaxLength(400);

                entity.Property(e => e.SowComments)
                    .HasColumnName("SOW_COMMENTS")
                    .IsUnicode(false);

                entity.Property(e => e.SowContactValue)
                    .HasColumnName("SOW_CONTACT_VALUE")
                    .HasMaxLength(56);

                entity.Property(e => e.SowId).HasColumnName("SOW_ID");

                entity.Property(e => e.SowPoNumber)
                    .HasColumnName("SOW_PO_NUMBER")
                    .HasMaxLength(56);

                entity.Property(e => e.SowProjectStatus)
                    .HasColumnName("SOW_PROJECT_STATUS")
                    .HasMaxLength(56);

                entity.Property(e => e.SowStackHolder)
                    .HasColumnName("SOW_STACK_HOLDER")
                    .HasMaxLength(56);

                entity.Property(e => e.SowStatus)
                    .HasColumnName("SOW_STATUS")
                    .HasMaxLength(56);

                entity.Property(e => e.SowType)
                    .HasColumnName("SOW_TYPE")
                    .HasMaxLength(56);

                entity.Property(e => e.StartDate)
                    .HasColumnName("START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.SubmitedDate)
                    .HasColumnName("SUBMITED_DATE")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Subcategory>(entity =>
            {
                entity.ToTable("SUBCATEGORY");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TableResource>(entity =>
            {
                entity.HasKey(e => e.Rowid);

                entity.ToTable("TABLE_RESOURCE");

                entity.Property(e => e.Rowid).HasColumnName("ROWID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("CREATED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.LastUpdateDate)
                    .HasColumnName("LAST_UPDATE_DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("MODIFIED_BY")
                    .HasMaxLength(240);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("MODIFIED_ON")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceAccountRoleId).HasColumnName("RESOURCE_ACCOUNT_ROLE_ID");

                entity.Property(e => e.ResourceAllocationPercentage)
                    .HasColumnName("RESOURCE_ALLOCATION_PERCENTAGE")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceApplicationGroup)
                    .HasColumnName("RESOURCE_APPLICATION_GROUP")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceCoreTechnology)
                    .HasColumnName("RESOURCE_CORE_TECHNOLOGY")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceEndDate)
                    .HasColumnName("RESOURCE_END_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceId).HasColumnName("RESOURCE_ID");

                entity.Property(e => e.ResourceIsbillable)
                    .HasColumnName("RESOURCE_ISBILLABLE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ResourceLocationDesc)
                    .HasColumnName("RESOURCE_LOCATION_DESC")
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceLocationType)
                    .HasColumnName("RESOURCE_LOCATION_TYPE")
                    .HasMaxLength(56);

                entity.Property(e => e.ResourceName)
                    .HasColumnName("RESOURCE_NAME")
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceOrgRoleId).HasColumnName("RESOURCE_ORG_ROLE_ID");

                entity.Property(e => e.ResourcePracticeId).HasColumnName("RESOURCE_PRACTICE_ID");

                entity.Property(e => e.ResourceStartDate)
                    .HasColumnName("RESOURCE_START_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ResourceTechnologyGroup)
                    .HasColumnName("RESOURCE_TECHNOLOGY_GROUP")
                    .HasMaxLength(56);
            });

            modelBuilder.Entity<TestData>(entity =>
            {
                entity.ToTable("Test_Data");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnName("DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
