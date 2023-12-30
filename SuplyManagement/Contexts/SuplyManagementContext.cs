using Microsoft.EntityFrameworkCore;
using SuplyManagement.Models;

namespace SuplyManagement.Contexts;

public partial class SuplyManagementContext : DbContext
{
    public SuplyManagementContext()
    {
    }

    public SuplyManagementContext(DbContextOptions<SuplyManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbApprovalHistory> TbApprovalHistories { get; set; }

    public virtual DbSet<TbBusinessField> TbBusinessFields { get; set; }

    public virtual DbSet<TbCompaniesType> TbCompaniesTypes { get; set; }

    public virtual DbSet<TbCompany> TbCompanies { get; set; }

    public virtual DbSet<TbProject> TbProjects { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbVendorDetail> TbVendorDetails { get; set; }

    public virtual DbSet<TbVendorProject> TbVendorProjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=ConnectionStrings:Database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.30-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<TbApprovalHistory>(entity =>
        {
            entity.HasKey(e => e.ApprovalId).HasName("PRIMARY");

            entity.ToTable("tb_approval_histories");

            entity.HasIndex(e => e.ApproverUserId, "approver_user_id");

            entity.HasIndex(e => e.VendorId, "vendor_id");

            entity.Property(e => e.ApprovalId)
                .HasMaxLength(36)
                .HasColumnName("approval_id");
            entity.Property(e => e.ApprovalDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("approval_date");
            entity.Property(e => e.ApprovalStatus)
                .HasColumnType("enum('Approved','Rejected')")
                .HasColumnName("approval_status");
            entity.Property(e => e.ApproverUserId)
                .HasMaxLength(36)
                .HasColumnName("approver_user_id");
            entity.Property(e => e.VendorId)
                .HasMaxLength(36)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.ApproverUser).WithMany(p => p.TbApprovalHistories)
                .HasForeignKey(d => d.ApproverUserId)
                .HasConstraintName("tb_approval_histories_ibfk_2");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TbApprovalHistories)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("tb_approval_histories_ibfk_1");
        });

        modelBuilder.Entity<TbBusinessField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tb_business_fields");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TbCompaniesType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tb_companies_types");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<TbCompany>(entity =>
        {
            entity.HasKey(e => e.CompanyId).HasName("PRIMARY");

            entity.ToTable("tb_companies");

            entity.HasIndex(e => e.UserId, "user_id").IsUnique();

            entity.Property(e => e.CompanyId)
                .HasMaxLength(36)
                .HasColumnName("company_id");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(30)
                .HasColumnName("company_name");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(13)
                .HasColumnName("phone_number");
            entity.Property(e => e.Photo)
                .HasMaxLength(255)
                .HasColumnName("photo");
            entity.Property(e => e.RegistrationStatus)
                .HasColumnType("enum('Pending','Approved','Rejected')")
                .HasColumnName("registration_status");
            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithOne(p => p.TbCompany)
                .HasForeignKey<TbCompany>(d => d.UserId)
                .HasConstraintName("tb_companies_ibfk_1");
        });

        modelBuilder.Entity<TbProject>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PRIMARY");

            entity.ToTable("tb_projects");

            entity.Property(e => e.ProjectId)
                .HasMaxLength(36)
                .HasColumnName("project_id");
            entity.Property(e => e.ProjectDescription)
                .HasColumnType("text")
                .HasColumnName("project_description");
            entity.Property(e => e.ProjectName)
                .HasMaxLength(50)
                .HasColumnName("project_name");
            entity.Property(e => e.SubmissionStatus)
                .HasColumnType("enum('Open','Closed')")
                .HasColumnName("submission_status");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.ToTable("tb_users");

            entity.Property(e => e.UserId)
                .HasMaxLength(36)
                .HasColumnName("user_id");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasColumnType("enum('Admin','ManagerLogistic','Vendor')")
                .HasColumnName("role");
        });

        modelBuilder.Entity<TbVendorDetail>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("PRIMARY");

            entity.ToTable("tb_vendor_details");

            entity.HasIndex(e => e.BusinessField, "business_field");

            entity.HasIndex(e => e.CompanyType, "company_type");

            entity.Property(e => e.VendorId)
                .HasMaxLength(36)
                .HasColumnName("vendor_id");
            entity.Property(e => e.ApprovalStatus)
                .HasColumnType("enum('Pending','Approved','Rejected')")
                .HasColumnName("approval_status");
            entity.Property(e => e.BusinessField).HasColumnName("business_field");
            entity.Property(e => e.CompanyType).HasColumnName("company_type");

            entity.HasOne(d => d.BusinessFieldNavigation).WithMany(p => p.TbVendorDetails)
                .HasForeignKey(d => d.BusinessField)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_vendor_details_ibfk_2");

            entity.HasOne(d => d.CompanyTypeNavigation).WithMany(p => p.TbVendorDetails)
                .HasForeignKey(d => d.CompanyType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_vendor_details_ibfk_3");

            entity.HasOne(d => d.Vendor).WithOne(p => p.TbVendorDetail)
                .HasForeignKey<TbVendorDetail>(d => d.VendorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tb_vendor_details_ibfk_1");
        });

        modelBuilder.Entity<TbVendorProject>(entity =>
        {
            entity.HasKey(e => e.VendorProjectId).HasName("PRIMARY");

            entity.ToTable("tb_vendor_projects");

            entity.HasIndex(e => e.ProjectId, "project_id");

            entity.HasIndex(e => e.VendorId, "vendor_id");

            entity.Property(e => e.VendorProjectId)
                .HasMaxLength(36)
                .HasColumnName("vendor_project_id");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(36)
                .HasColumnName("project_id");
            entity.Property(e => e.SubmissionStatus)
                .HasColumnType("enum('Pending','Approved','Rejected')")
                .HasColumnName("submission_status");
            entity.Property(e => e.VendorId)
                .HasMaxLength(36)
                .HasColumnName("vendor_id");

            entity.HasOne(d => d.Project).WithMany(p => p.TbVendorProjects)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("tb_vendor_projects_ibfk_2");

            entity.HasOne(d => d.Vendor).WithMany(p => p.TbVendorProjects)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("tb_vendor_projects_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
