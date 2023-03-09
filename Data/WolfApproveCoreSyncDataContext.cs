using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class WolfApproveCoreSyncDataContext : DbContext
    {
        public WolfApproveCoreSyncDataContext()
        {
        }

        public WolfApproveCoreSyncDataContext(DbContextOptions<WolfApproveCoreSyncDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MSTAccount> MSTAccounts { get; set; }
        public virtual DbSet<MSTApprovalMatrix> MSTApprovalMatrices { get; set; }
        public virtual DbSet<MSTApprovalMatrixItem> MSTApprovalMatricesItem { get; set; }
        public virtual DbSet<MSTAuthorizedMenu> MSTAuthorizedMenus { get; set; }
        public virtual DbSet<MSTChecklist> MSTChecklists { get; set; }
        public virtual DbSet<MSTCompany> MSTCompanies { get; set; }
        public virtual DbSet<MSTDepartment> MSTDepartments { get; set; }
        public virtual DbSet<MSTDivision> MSTDivisions { get; set; }
        public virtual DbSet<MSTEmailTemplate> MSTEmailTemplates { get; set; }
        public virtual DbSet<MSTEmployee> MSTEmployees { get; set; }
        public virtual DbSet<MSTIO> MSTIOs { get; set; }
        public virtual DbSet<MSTMasterDatum> MSTMasterData { get; set; }
        public virtual DbSet<MSTPermission> MSTPermissions { get; set; }
        public virtual DbSet<MSTPosition> MSTPositions { get; set; }
        public virtual DbSet<MSTPositionLevel> MSTPositionLevels { get; set; }
        public virtual DbSet<MSTProject> MSTProjects { get; set; }
        public virtual DbSet<MSTProvince> MSTProvinces { get; set; }
        public virtual DbSet<MSTReleasedDocumentTemplate> MSTReleasedDocumentTemplates { get; set; }
        public virtual DbSet<MSTReportTemplate> MSTReportTemplates { get; set; }
        public virtual DbSet<MSTRole> MSTRoles { get; set; }
        public virtual DbSet<MSTRolePermission> MSTRolePermissions { get; set; }
        public virtual DbSet<MSTTemLineApprove> MSTTemLineApproves { get; set; }
        public virtual DbSet<MSTTemSpecificApprover> MSTTemSpecificApprovers { get; set; }
        public virtual DbSet<MSTTemplate> MSTTemplates { get; set; }
        public virtual DbSet<MSTTemplateLogic> MSTTemplateLogics { get; set; }
        public virtual DbSet<MSTUserPermission> MSTUserPermissions { get; set; }
        public virtual DbSet<TRNActionHistory> TRNActionHistories { get; set; }
        public virtual DbSet<TRNAttachFile> TRNAttachFiles { get; set; }
        public virtual DbSet<TRNControlRunning> TRNControlRunnings { get; set; }
        public virtual DbSet<TRNDelegate> TRNDelegates { get; set; }
        public virtual DbSet<TRNDelegateDetail> TRNDelegateDetails { get; set; }
        public virtual DbSet<TRNEDocumentQueue> TRNEDocumentQueues { get; set; }
        public virtual DbSet<TRNLineApprove> TRNLineApproves { get; set; }
        public virtual DbSet<TRNMemo> TRNMemos { get; set; }
        public virtual DbSet<TRNReferenceDoc> TRNReferenceDocs { get; set; }
        public virtual DbSet<TRNReleasedDocument> TRNReleasedDocuments { get; set; }
        public virtual DbSet<TRNUsageLog> TRNUsageLogs { get; set; }
        public virtual DbSet<TRNUserParticipate> TRNUserParticipates { get; set; }
        public virtual DbSet<TRNUserTransaction> TRNUserTransactions { get; set; }
        public virtual DbSet<ViewApprovalMatrix> ViewApprovalMatrices { get; set; }
        public virtual DbSet<ViewDelegate> ViewDelegates { get; set; }
        public virtual DbSet<ViewEmployee> ViewEmployees { get; set; }
        public virtual DbSet<ViewMasterApproveType> ViewMasterApproveTypes { get; set; }
        public virtual DbSet<ViewPosition> ViewPositions { get; set; }
        public virtual DbSet<ViewReleasedDocument> ViewReleasedDocuments { get; set; }
        public virtual DbSet<ViewReport> ViewReports { get; set; }
        public virtual DbSet<ViewRole> ViewRoles { get; set; }
        public virtual DbSet<ViewRolePermission> ViewRolePermissions { get; set; }
        public virtual DbSet<__MigrationHistory> __MigrationHistories { get; set; }
        public virtual DbSet<v_TRNParticipateList> v_TRNParticipateLists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-EHONBJI\SQLEXPRESS;Initial Catalog=WolfApproveCore.SyncData;Persist Security Info=True;User ID=sa;Password=pass@word1");
            }
        }
      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CI_AS");

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.Page).HasMaxLength(100);

                entity.Property(e => e.Platform).HasMaxLength(50);

                entity.Property(e => e.PostedBy).HasMaxLength(100);

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.Site).HasMaxLength(100);
            });

            modelBuilder.Entity<MSTAccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTAccount");

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountId).ValueGeneratedOnAdd();

                entity.Property(e => e.AccountName).HasMaxLength(250);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.LogoPic).HasMaxLength(500);

                entity.Property(e => e.MSLicence).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.ThemeColor).HasMaxLength(10);
            });

            modelBuilder.Entity<MSTApprovalMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTApprovalMatrix");

                entity.Property(e => e.ApproveMatrixId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTApprovalMatrixItem>(entity =>
            {
                entity.HasKey(e => e.ApproveMatrixItemId);

                entity.ToTable("MSTApprovalMatrixItem");

                entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MSTAuthorizedMenu>(entity =>
            {
                entity.HasKey(e => e.AuMenuID)
                    .HasName("PK_dbo.MSTAuthorizedMenu");

                entity.ToTable("MSTAuthorizedMenu");

                entity.Property(e => e.CreatedBy).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GroupMenu).HasMaxLength(100);

                entity.Property(e => e.ItemMenu).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Process).HasMaxLength(3);

                entity.Property(e => e.RolesID).HasMaxLength(1000);

                entity.Property(e => e.SubMenu).HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<MSTChecklist>(entity =>
            {
                entity.ToTable("MSTChecklist");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Org).HasMaxLength(50);

                entity.Property(e => e.Standards).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<MSTCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId)
                    .HasName("PK__MSTCompa__2D971CAC767A0F1A");

                entity.ToTable("MSTCompany");

                entity.Property(e => e.BUCode).HasMaxLength(50);

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Fax).HasMaxLength(100);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.Tel).HasMaxLength(100);

                entity.Property(e => e.UrlWeb).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK__MSTDepar__B2079BEDE01B75A9");

                entity.ToTable("MSTDepartment");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentCode).HasMaxLength(20);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTDivision>(entity =>
            {
                entity.HasKey(e => e.DivisionId)
                    .HasName("PK__MSTDivis__20EFC6A8638EE3E9");

                entity.ToTable("MSTDivision");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DivisionCode).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId);

                entity.ToTable("MSTEmailTemplate");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailBody).IsUnicode(false);

                entity.Property(e => e.EmailCC)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FormState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MSTEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK__MSTEmplo__7AD04F1108B3D923");

                entity.ToTable("MSTEmployee");

                entity.Property(e => e.ADTitle).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EMPL_RCD).HasMaxLength(500);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmpLevel).HasMaxLength(10);

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.ReportToEmpCode).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<MSTIO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTIO");

                entity.Property(e => e.CostCenter).HasMaxLength(50);

                entity.Property(e => e.IO).HasMaxLength(50);
            });

            modelBuilder.Entity<MSTMasterDatum>(entity =>
            {
                entity.HasKey(e => e.MasterId);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MasterType).HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MSTPermission>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__MSTPermi__C99ED2305562B93D");

                entity.ToTable("MSTPermission");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuDescription).HasMaxLength(1000);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTPosition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PK__MSTPosit__60BB9A795FC1AE90");

                entity.ToTable("MSTPosition");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTPositionLevel>(entity =>
            {
                entity.HasKey(e => e.PositionLevelId)
                    .HasName("PK__MSTPosit__5622C997D46D3B94");

                entity.ToTable("MSTPositionLevel");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionLevel).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<MSTProject>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__MSTProje__761ABEF0229C0ACB");

                entity.ToTable("MSTProject");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode).HasMaxLength(50);

                entity.Property(e => e.ProjectName).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTProvince");

                entity.Property(e => e.Districtthai).HasMaxLength(50);

                entity.Property(e => e.Provincethai)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Tambonthai).HasMaxLength(50);
            });

            modelBuilder.Entity<MSTReleasedDocumentTemplate>(entity =>
            {
                entity.HasKey(e => e.ReportTemplateId);

                entity.ToTable("MSTReleasedDocumentTemplate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportName).HasMaxLength(500);

                entity.Property(e => e.TemplateId).HasMaxLength(100);
            });

            modelBuilder.Entity<MSTReportTemplate>(entity =>
            {
                entity.HasKey(e => e.ReportTemplateId)
                    .HasName("PK__MSTRepor__C7EA280656C828D8");

                entity.ToTable("MSTReportTemplate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReportName).HasMaxLength(500);

                entity.Property(e => e.TemplateId).HasMaxLength(100);
            });

            modelBuilder.Entity<MSTRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__MSTRole__8AFACE1AF107DAA0");

                entity.ToTable("MSTRole");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.RoleDescription).HasMaxLength(1000);
            });

            modelBuilder.Entity<MSTRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.MenuId, e.AccountId });

                entity.ToTable("MSTRolePermission");
            });

            modelBuilder.Entity<MSTTemLineApprove>(entity =>
            {
                entity.HasKey(e => e.TemLineId)
                    .HasName("PK__TRNTemLi__982EA6C15523E293");

                entity.ToTable("MSTTemLineApprove");

                entity.Property(e => e.Conditions).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MSTTemSpecificApprover>(entity =>
            {
                entity.HasKey(e => e.TemSpecificId)
                    .HasName("PK__MSTTemSp__73D3754C6B879388");

                entity.ToTable("MSTTemSpecificApprover");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MSTTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MSTTemplate");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CcId).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateId).ValueGeneratedOnAdd();

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.ToId).HasMaxLength(500);
            });

            modelBuilder.Entity<MSTTemplateLogic>(entity =>
            {
                entity.HasKey(e => e.logicid)
                    .HasName("PK__MSTTempl__7B235661149B9A56");

                entity.ToTable("MSTTemplateLogic");

                entity.Property(e => e.logicid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.jsonvalue).IsUnicode(false);

                entity.Property(e => e.logictype).HasMaxLength(20);
            });

            modelBuilder.Entity<MSTUserPermission>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.RoleId });

                entity.ToTable("MSTUserPermission");
            });

            modelBuilder.Entity<TRNActionHistory>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK__TRNActio__FFE3F4D97C5024D2");

                entity.ToTable("TRNActionHistory");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionProcess).HasMaxLength(100);

                entity.Property(e => e.ActionStatus).HasMaxLength(100);

                entity.Property(e => e.ActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorName).HasMaxLength(500);

                entity.Property(e => e.ActorNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DelegateActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.DelegateActorNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorNameTh).HasMaxLength(500);

                entity.Property(e => e.DelegateActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.DelegateActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.IPAddress).HasMaxLength(500);

                entity.Property(e => e.NextApproverName).HasMaxLength(500);

                entity.Property(e => e.Platform).HasMaxLength(100);

                entity.Property(e => e.SignPicPath).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TRNAttachFile>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("PK__TRNAttac__F517C3F5F00FFEA5");

                entity.ToTable("TRNAttachFile");

                entity.Property(e => e.ActorName).HasMaxLength(500);

                entity.Property(e => e.AttachFile).HasMaxLength(500);

                entity.Property(e => e.AttachedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.FilePath).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TRNControlRunning>(entity =>
            {
                entity.HasKey(e => e.ControlRunningOrder);

                entity.ToTable("TRNControlRunning");

                entity.Property(e => e.CreateBy)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RunningNumber).HasMaxLength(255);
            });

            modelBuilder.Entity<TRNDelegate>(entity =>
            {
                entity.HasKey(e => e.DelegateId)
                    .HasName("PK__TRNDeleg__013A45ABA4295E70");

                entity.ToTable("TRNDelegate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("ntext");
            });

            modelBuilder.Entity<TRNDelegateDetail>(entity =>
            {
                entity.HasKey(e => e.DelegateDetialId)
                    .HasName("PK__TRNDeleg__00BB1BB2F93CCBBB");

                entity.ToTable("TRNDelegateDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TRNEDocumentQueue>(entity =>
            {
                entity.HasKey(e => e.QueueId)
                    .HasName("PK__TRNEDocu__8324E715609364C2");

                entity.ToTable("TRNEDocumentQueue");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GenaratedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TRNLineApprove>(entity =>
            {
                entity.HasKey(e => e.LineApproveId)
                    .HasName("PK__TRNLineA__401DC2E7CC5EB03F");

                entity.ToTable("TRNLineApprove");

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionEN).HasMaxLength(500);

                entity.Property(e => e.PositionTH).HasMaxLength(500);

                entity.Property(e => e.SignatureEn).HasMaxLength(500);

                entity.Property(e => e.SignatureTh).HasMaxLength(500);
            });

            modelBuilder.Entity<TRNMemo>(entity =>
            {
                entity.HasKey(e => e.MemoId)
                    .HasName("PK__TRNMemo__8D6CC126A41C6C93");

                entity.ToTable("TRNMemo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.CDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.CDivisionEn).HasMaxLength(500);

                entity.Property(e => e.CDivisionTh).HasMaxLength(500);

                entity.Property(e => e.CNameEn).HasMaxLength(500);

                entity.Property(e => e.CNameTh).HasMaxLength(500);

                entity.Property(e => e.CPositionEn).HasMaxLength(500);

                entity.Property(e => e.CPositionTh).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(400);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.LastActionBy).HasMaxLength(500);

                entity.Property(e => e.LastStatusName).HasMaxLength(500);

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonWaiting).HasMaxLength(500);

                entity.Property(e => e.ProjectName).HasMaxLength(400);

                entity.Property(e => e.RDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.RDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.RDivisionEn).HasMaxLength(500);

                entity.Property(e => e.RDivisionTh).HasMaxLength(500);

                entity.Property(e => e.RNameEn).HasMaxLength(500);

                entity.Property(e => e.RNameTh).HasMaxLength(500);

                entity.Property(e => e.RPositionEn).HasMaxLength(500);

                entity.Property(e => e.RPositionTh).HasMaxLength(500);

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SLACompletedDate).HasColumnType("datetime");

                entity.Property(e => e.SLAStartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.TemplateApproveId).HasMaxLength(10);

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.TemplateType).HasMaxLength(100);
            });

            modelBuilder.Entity<TRNReferenceDoc>(entity =>
            {
                entity.HasKey(e => e.RefDocID);

                entity.ToTable("TRNReferenceDoc");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ShowColumn).HasMaxLength(50);

                entity.Property(e => e.TemplateName).HasMaxLength(500);
            });

            modelBuilder.Entity<TRNReleasedDocument>(entity =>
            {
                entity.HasKey(e => e.ReleasedDocumentId);

                entity.Property(e => e.ReleasedDocumentId).ValueGeneratedNever();

                entity.Property(e => e.ReleasedDocumentStatus).HasMaxLength(50);
            });

            modelBuilder.Entity<TRNUsageLog>(entity =>
            {
                entity.HasKey(e => e.UsageLogId);

                entity.ToTable("TRNUsageLog");

                entity.Property(e => e.ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionProcess).HasMaxLength(100);

                entity.Property(e => e.ActionStatus).HasMaxLength(100);

                entity.Property(e => e.ActorDepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorDepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorNameTh).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameEn).HasMaxLength(500);

                entity.Property(e => e.ActorPositionNameTh).HasMaxLength(500);

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.IPAddress).HasMaxLength(500);

                entity.Property(e => e.Note01).HasColumnType("ntext");

                entity.Property(e => e.Note02).HasColumnType("ntext");

                entity.Property(e => e.Note03).HasColumnType("ntext");

                entity.Property(e => e.Note04).HasColumnType("ntext");

                entity.Property(e => e.Note05).HasColumnType("ntext");

                entity.Property(e => e.Platform).HasMaxLength(100);
            });

            modelBuilder.Entity<TRNUserParticipate>(entity =>
            {
                entity.HasKey(e => e.UPID);

                entity.ToTable("TRNUserParticipate");

                entity.Property(e => e.ActionName).HasMaxLength(100);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.UserParticipateName).HasMaxLength(500);
            });

            modelBuilder.Entity<TRNUserTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__TRNUserT__55433A6B6FC6506B");

                entity.ToTable("TRNUserTransaction");

                entity.Property(e => e.AccessDate).HasColumnType("datetime");

                entity.Property(e => e.Channel).HasMaxLength(10);

                entity.Property(e => e.DeviceToken).HasMaxLength(256);
            });

            modelBuilder.Entity<ViewApprovalMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewApprovalMatrix");

                entity.Property(e => e.AmountFrom).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountTo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewDelegate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewDelegate");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasColumnType("ntext");

                entity.Property(e => e.Template)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewEmployee");

                entity.Property(e => e.ADTitle).HasMaxLength(500);

                entity.Property(e => e.AccountCode).HasMaxLength(10);

                entity.Property(e => e.AccountName).HasMaxLength(250);

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultLang).HasMaxLength(2);

                entity.Property(e => e.DepartmentNameEn).HasMaxLength(500);

                entity.Property(e => e.DepartmentNameTh).HasMaxLength(500);

                entity.Property(e => e.DivisionNameEn).HasMaxLength(500);

                entity.Property(e => e.DivisionNameTh).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Lang).HasMaxLength(2);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionNameEn).HasMaxLength(500);

                entity.Property(e => e.PositionNameTh).HasMaxLength(500);

                entity.Property(e => e.RegisteredDate).HasColumnType("datetime");

                entity.Property(e => e.ReportToEmpCode).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewMasterApproveType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewMasterApproveType");
            });

            modelBuilder.Entity<ViewPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewPosition");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);

                entity.Property(e => e.PositionLevelNameEn).HasMaxLength(500);

                entity.Property(e => e.PositionLevelNameTh).HasMaxLength(500);

                entity.Property(e => e.PosotionLevel).HasColumnType("decimal(18, 1)");
            });

            modelBuilder.Entity<ViewReleasedDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewReleasedDocuments");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.CDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.CDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.CDivisionEn).HasMaxLength(500);

                entity.Property(e => e.CDivisionTh).HasMaxLength(500);

                entity.Property(e => e.CNameEn).HasMaxLength(500);

                entity.Property(e => e.CNameTh).HasMaxLength(500);

                entity.Property(e => e.CPositionEn).HasMaxLength(500);

                entity.Property(e => e.CPositionTh).HasMaxLength(500);

                entity.Property(e => e.CompanyName).HasMaxLength(400);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentCode).HasMaxLength(50);

                entity.Property(e => e.DocumentNo).HasMaxLength(50);

                entity.Property(e => e.GroupTemplateName).HasMaxLength(500);

                entity.Property(e => e.LastActionBy).HasMaxLength(500);

                entity.Property(e => e.LastStatusName).HasMaxLength(500);

                entity.Property(e => e.MemoSubject).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PersonWaiting).HasMaxLength(500);

                entity.Property(e => e.ProjectName).HasMaxLength(400);

                entity.Property(e => e.RDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.RDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.RDivisionEn).HasMaxLength(500);

                entity.Property(e => e.RDivisionTh).HasMaxLength(500);

                entity.Property(e => e.RNameEn).HasMaxLength(500);

                entity.Property(e => e.RNameTh).HasMaxLength(500);

                entity.Property(e => e.RPositionEn).HasMaxLength(500);

                entity.Property(e => e.RPositionTh).HasMaxLength(500);

                entity.Property(e => e.ReleasedDocumentStatus).HasMaxLength(50);

                entity.Property(e => e.ReportLang).HasMaxLength(2);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.SLACompletedDate).HasColumnType("datetime");

                entity.Property(e => e.SLAStartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusName).HasMaxLength(500);

                entity.Property(e => e.TemplateApproveId).HasMaxLength(10);

                entity.Property(e => e.TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.TemplateType).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewReport");

                entity.Property(e => e.ActionHistoryNextApproverName).HasMaxLength(500);

                entity.Property(e => e.ActionHistory_ActionDate).HasColumnType("datetime");

                entity.Property(e => e.ActionHistory_ActionProcess).HasMaxLength(100);

                entity.Property(e => e.ActionHistory_ActionStatus).HasMaxLength(100);

                entity.Property(e => e.ActionHistory_ActorName).HasMaxLength(500);

                entity.Property(e => e.ActionHistory_Comment).HasColumnType("ntext");

                entity.Property(e => e.ActionHistory_CreatedBy).HasMaxLength(500);

                entity.Property(e => e.ActionHistory_CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ActionHistory_SignPicPath).HasMaxLength(500);

                entity.Property(e => e.ActionHistory_StartDate).HasColumnType("datetime");

                entity.Property(e => e.AttachFile_ActorName).HasMaxLength(500);

                entity.Property(e => e.AttachFile_AttachFile).HasMaxLength(500);

                entity.Property(e => e.AttachFile_AttachedDate).HasColumnType("datetime");

                entity.Property(e => e.AttachFile_CreatedBy).HasMaxLength(500);

                entity.Property(e => e.AttachFile_CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.AttachFile_FileName).HasMaxLength(500);

                entity.Property(e => e.AttachFile_FilePath).HasMaxLength(500);

                entity.Property(e => e.AttachFile_ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.AttachFile_ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.LineApprove_EmployeeCode).HasMaxLength(10);

                entity.Property(e => e.LineApprove_NameEn).HasMaxLength(500);

                entity.Property(e => e.LineApprove_NameTh).HasMaxLength(500);

                entity.Property(e => e.LineApprove_PositionEN).HasMaxLength(500);

                entity.Property(e => e.LineApprove_PositionTH).HasMaxLength(500);

                entity.Property(e => e.LineApprove_SignatureEn).HasMaxLength(500);

                entity.Property(e => e.LineApprove_SignatureTh).HasMaxLength(500);

                entity.Property(e => e.Memo_Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Memo_AutoApproveWhen).HasMaxLength(2);

                entity.Property(e => e.Memo_CDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.Memo_CDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.Memo_CDivisionEn).HasMaxLength(500);

                entity.Property(e => e.Memo_CDivisionTh).HasMaxLength(500);

                entity.Property(e => e.Memo_CNameEn).HasMaxLength(500);

                entity.Property(e => e.Memo_CNameTh).HasMaxLength(500);

                entity.Property(e => e.Memo_CPositionEn).HasMaxLength(500);

                entity.Property(e => e.Memo_CPositionTh).HasMaxLength(500);

                entity.Property(e => e.Memo_CompanyName).HasMaxLength(400);

                entity.Property(e => e.Memo_CreatedBy).HasMaxLength(500);

                entity.Property(e => e.Memo_CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Memo_DocumentCode).HasMaxLength(50);

                entity.Property(e => e.Memo_DocumentNo).HasMaxLength(50);

                entity.Property(e => e.Memo_LastActionBy).HasMaxLength(500);

                entity.Property(e => e.Memo_LastStatusName).HasMaxLength(500);

                entity.Property(e => e.Memo_MemoSubject).HasMaxLength(500);

                entity.Property(e => e.Memo_ModifiedBy).HasMaxLength(500);

                entity.Property(e => e.Memo_ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Memo_PersonWaiting).HasMaxLength(500);

                entity.Property(e => e.Memo_RDepartmentEn).HasMaxLength(500);

                entity.Property(e => e.Memo_RDepartmentTh).HasMaxLength(500);

                entity.Property(e => e.Memo_RDivisionEn).HasMaxLength(500);

                entity.Property(e => e.Memo_RDivisionTh).HasMaxLength(500);

                entity.Property(e => e.Memo_RNameEn).HasMaxLength(500);

                entity.Property(e => e.Memo_RNameTh).HasMaxLength(500);

                entity.Property(e => e.Memo_RPositionEn).HasMaxLength(500);

                entity.Property(e => e.Memo_RPositionTh).HasMaxLength(500);

                entity.Property(e => e.Memo_ReportLang).HasMaxLength(2);

                entity.Property(e => e.Memo_RequestDate).HasColumnType("datetime");

                entity.Property(e => e.Memo_RequesterCode).HasMaxLength(10);

                entity.Property(e => e.Memo_StatusName).HasMaxLength(500);

                entity.Property(e => e.Memo_TemplateDetail).HasMaxLength(500);

                entity.Property(e => e.Memo_TemplateName).HasMaxLength(500);

                entity.Property(e => e.Memo_TemplateSubject).HasMaxLength(500);

                entity.Property(e => e.Memo_TemplateType).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewRole");

                entity.Property(e => e.EmpNameEn).HasMaxLength(500);

                entity.Property(e => e.EmpNameTh).HasMaxLength(500);

                entity.Property(e => e.RoleNameEn).HasMaxLength(500);

                entity.Property(e => e.RoleNameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<ViewRolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ViewRolePermission");

                entity.Property(e => e.MenuDescription).HasMaxLength(1000);

                entity.Property(e => e.NameEn).HasMaxLength(500);

                entity.Property(e => e.NameTh).HasMaxLength(500);
            });

            modelBuilder.Entity<__MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<v_TRNParticipateList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("v_TRNParticipateList");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
