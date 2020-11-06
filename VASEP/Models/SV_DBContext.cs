using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VASEP.Models
{
    public partial class SV_DBContext : DbContext
    {
        public SV_DBContext()
        {
        }

        public SV_DBContext(DbContextOptions<SV_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnonymousUsers> AnonymousUsers { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspNetSqlCacheTablesForChangeNotification> AspNetSqlCacheTablesForChangeNotification { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<Assemblies> Assemblies { get; set; }
        public virtual DbSet<AuthCookies> AuthCookies { get; set; }
        public virtual DbSet<Authentication> Authentication { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BannerStatic> BannerStatic { get; set; }
        public virtual DbSet<BannerTemplate> BannerTemplate { get; set; }
        public virtual DbSet<BannerVitri> BannerVitri { get; set; }
        public virtual DbSet<CkeSettings> CkeSettings { get; set; }
        public virtual DbSet<ContactForm> ContactForm { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<ContentItems> ContentItems { get; set; }
        public virtual DbSet<ContentItemsMetaData> ContentItemsMetaData { get; set; }
        public virtual DbSet<ContentItemsTags> ContentItemsTags { get; set; }
        public virtual DbSet<ContentTypes> ContentTypes { get; set; }
        public virtual DbSet<ContentWorkflowActions> ContentWorkflowActions { get; set; }
        public virtual DbSet<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }
        public virtual DbSet<ContentWorkflows> ContentWorkflows { get; set; }
        public virtual DbSet<ContentWorkflowSources> ContentWorkflowSources { get; set; }
        public virtual DbSet<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; }
        public virtual DbSet<ContentWorkflowStates> ContentWorkflowStates { get; set; }
        public virtual DbSet<CoreMessagingMessageAttachments> CoreMessagingMessageAttachments { get; set; }
        public virtual DbSet<CoreMessagingMessageRecipients> CoreMessagingMessageRecipients { get; set; }
        public virtual DbSet<CoreMessagingMessages> CoreMessagingMessages { get; set; }
        public virtual DbSet<CoreMessagingNotificationTypeActions> CoreMessagingNotificationTypeActions { get; set; }
        public virtual DbSet<CoreMessagingNotificationTypes> CoreMessagingNotificationTypes { get; set; }
        public virtual DbSet<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; }
        public virtual DbSet<CoreMessagingSubscriptionTypes> CoreMessagingSubscriptionTypes { get; set; }
        public virtual DbSet<CoreMessagingUserPreferences> CoreMessagingUserPreferences { get; set; }
        public virtual DbSet<DesktopModulePermission> DesktopModulePermission { get; set; }
        public virtual DbSet<DesktopModules> DesktopModules { get; set; }
        public virtual DbSet<DocCategory> DocCategory { get; set; }
        public virtual DbSet<Docs> Docs { get; set; }
        public virtual DbSet<DocsFeedback> DocsFeedback { get; set; }
        public virtual DbSet<DocsFiles> DocsFiles { get; set; }
        public virtual DbSet<DocsLike> DocsLike { get; set; }
        public virtual DbSet<EventLog> EventLog { get; set; }
        public virtual DbSet<EventLogConfig> EventLogConfig { get; set; }
        public virtual DbSet<EventLogTypes> EventLogTypes { get; set; }
        public virtual DbSet<EventQueue> EventQueue { get; set; }
        public virtual DbSet<ExceptionEvents> ExceptionEvents { get; set; }
        public virtual DbSet<Exceptions> Exceptions { get; set; }
        public virtual DbSet<ExportImportCheckpoints> ExportImportCheckpoints { get; set; }
        public virtual DbSet<ExportImportJobLogs> ExportImportJobLogs { get; set; }
        public virtual DbSet<ExportImportJobs> ExportImportJobs { get; set; }
        public virtual DbSet<ExportImportSettings> ExportImportSettings { get; set; }
        public virtual DbSet<ExtensionUrlProviderConfiguration> ExtensionUrlProviderConfiguration { get; set; }
        public virtual DbSet<ExtensionUrlProviders> ExtensionUrlProviders { get; set; }
        public virtual DbSet<ExtensionUrlProviderSetting> ExtensionUrlProviderSetting { get; set; }
        public virtual DbSet<ExtensionUrlProviderTab> ExtensionUrlProviderTab { get; set; }
        public virtual DbSet<Faq> Faq { get; set; }
        public virtual DbSet<Faqanswers> Faqanswers { get; set; }
        public virtual DbSet<Faqquestions> Faqquestions { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<FileVersions> FileVersions { get; set; }
        public virtual DbSet<FolderMappings> FolderMappings { get; set; }
        public virtual DbSet<FolderMappingsSettings> FolderMappingsSettings { get; set; }
        public virtual DbSet<FolderPermission> FolderPermission { get; set; }
        public virtual DbSet<Folders> Folders { get; set; }
        public virtual DbSet<HostSettings> HostSettings { get; set; }
        public virtual DbSet<HtmlText> HtmlText { get; set; }
        public virtual DbSet<HtmlTextLog> HtmlTextLog { get; set; }
        public virtual DbSet<HtmlTextUsers> HtmlTextUsers { get; set; }
        public virtual DbSet<Ipfilter> Ipfilter { get; set; }
        public virtual DbSet<JavaScriptLibraries> JavaScriptLibraries { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<JournalAccess> JournalAccess { get; set; }
        public virtual DbSet<JournalComments> JournalComments { get; set; }
        public virtual DbSet<JournalData> JournalData { get; set; }
        public virtual DbSet<JournalSecurity> JournalSecurity { get; set; }
        public virtual DbSet<JournalTypeFilters> JournalTypeFilters { get; set; }
        public virtual DbSet<JournalTypes> JournalTypes { get; set; }
        public virtual DbSet<LanguagePacks> LanguagePacks { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<LichLamViec> LichLamViec { get; set; }
        public virtual DbSet<Lists> Lists { get; set; }
        public virtual DbSet<MediaItem> MediaItem { get; set; }
        public virtual DbSet<MessagingMessages> MessagingMessages { get; set; }
        public virtual DbSet<MetaData> MetaData { get; set; }
        public virtual DbSet<Mi> Mi { get; set; }
        public virtual DbSet<MobilePreviewProfiles> MobilePreviewProfiles { get; set; }
        public virtual DbSet<MobileRedirectionRules> MobileRedirectionRules { get; set; }
        public virtual DbSet<MobileRedirections> MobileRedirections { get; set; }
        public virtual DbSet<ModuleControls> ModuleControls { get; set; }
        public virtual DbSet<ModuleDefinitions> ModuleDefinitions { get; set; }
        public virtual DbSet<ModulePermission> ModulePermission { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<ModuleSettings> ModuleSettings { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsByCategory> NewsByCategory { get; set; }
        public virtual DbSet<NewsByMedia> NewsByMedia { get; set; }
        public virtual DbSet<NewsByShare> NewsByShare { get; set; }
        public virtual DbSet<NewsByTags> NewsByTags { get; set; }
        public virtual DbSet<NewsByVideo> NewsByVideo { get; set; }
        public virtual DbSet<NewsByView> NewsByView { get; set; }
        public virtual DbSet<NewsCategories> NewsCategories { get; set; }
        public virtual DbSet<NewsCategoriesPermission> NewsCategoriesPermission { get; set; }
        public virtual DbSet<NewsCustomeCategories> NewsCustomeCategories { get; set; }
        public virtual DbSet<NewsFeedback> NewsFeedback { get; set; }
        public virtual DbSet<NewsKpi> NewsKpi { get; set; }
        public virtual DbSet<NewsNhuanBut> NewsNhuanBut { get; set; }
        public virtual DbSet<NewsProcess> NewsProcess { get; set; }
        public virtual DbSet<NewsSettings> NewsSettings { get; set; }
        public virtual DbSet<NewsStatus> NewsStatus { get; set; }
        public virtual DbSet<NewsUserProcess> NewsUserProcess { get; set; }
        public virtual DbSet<NewsUserWf> NewsUserWf { get; set; }
        public virtual DbSet<NewsVersion> NewsVersion { get; set; }
        public virtual DbSet<OutputCache> OutputCache { get; set; }
        public virtual DbSet<PackageDependencies> PackageDependencies { get; set; }
        public virtual DbSet<Packages> Packages { get; set; }
        public virtual DbSet<PackageTypes> PackageTypes { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistory { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PersonaBarExtensions> PersonaBarExtensions { get; set; }
        public virtual DbSet<PersonaBarMenu> PersonaBarMenu { get; set; }
        public virtual DbSet<PersonaBarMenuDefaultPermissions> PersonaBarMenuDefaultPermissions { get; set; }
        public virtual DbSet<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        public virtual DbSet<PersonaBarPermission> PersonaBarPermission { get; set; }
        public virtual DbSet<PortalAlias> PortalAlias { get; set; }
        public virtual DbSet<PortalConfigs> PortalConfigs { get; set; }
        public virtual DbSet<PortalDesktopModules> PortalDesktopModules { get; set; }
        public virtual DbSet<PortalGroups> PortalGroups { get; set; }
        public virtual DbSet<PortalLanguages> PortalLanguages { get; set; }
        public virtual DbSet<PortalLocalization> PortalLocalization { get; set; }
        public virtual DbSet<Portals> Portals { get; set; }
        public virtual DbSet<PortalSettings> PortalSettings { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; }
        public virtual DbSet<QlvpChucVu> QlvpChucVu { get; set; }
        public virtual DbSet<QlvpPhongBan> QlvpPhongBan { get; set; }
        public virtual DbSet<QlvpPhongBanChucVu> QlvpPhongBanChucVu { get; set; }
        public virtual DbSet<QlvpPhongBanDonviNguoiDung> QlvpPhongBanDonviNguoiDung { get; set; }
        public virtual DbSet<QlvpPhongBanNguoiDung> QlvpPhongBanNguoiDung { get; set; }
        public virtual DbSet<QlvpUserWf> QlvpUserWf { get; set; }
        public virtual DbSet<RedirectMessages> RedirectMessages { get; set; }
        public virtual DbSet<Relationships> Relationships { get; set; }
        public virtual DbSet<RelationshipTypes> RelationshipTypes { get; set; }
        public virtual DbSet<RoleGroups> RoleGroups { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RoleSettings> RoleSettings { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleHistory> ScheduleHistory { get; set; }
        public virtual DbSet<ScheduleItemSettings> ScheduleItemSettings { get; set; }
        public virtual DbSet<SearchCommonWords> SearchCommonWords { get; set; }
        public virtual DbSet<SearchDeletedItems> SearchDeletedItems { get; set; }
        public virtual DbSet<SearchIndexer> SearchIndexer { get; set; }
        public virtual DbSet<SearchStopWords> SearchStopWords { get; set; }
        public virtual DbSet<SearchTypes> SearchTypes { get; set; }
        public virtual DbSet<SiteLog> SiteLog { get; set; }
        public virtual DbSet<SkinControls> SkinControls { get; set; }
        public virtual DbSet<SkinPackages> SkinPackages { get; set; }
        public virtual DbSet<Skins> Skins { get; set; }
        public virtual DbSet<Sqlqueries> Sqlqueries { get; set; }
        public virtual DbSet<SynonymsGroups> SynonymsGroups { get; set; }
        public virtual DbSet<SystemMessages> SystemMessages { get; set; }
        public virtual DbSet<TabAliasSkins> TabAliasSkins { get; set; }
        public virtual DbSet<TabModules> TabModules { get; set; }
        public virtual DbSet<TabModuleSettings> TabModuleSettings { get; set; }
        public virtual DbSet<TabPermission> TabPermission { get; set; }
        public virtual DbSet<Tabs> Tabs { get; set; }
        public virtual DbSet<TabSettings> TabSettings { get; set; }
        public virtual DbSet<TabUrls> TabUrls { get; set; }
        public virtual DbSet<TabVersionDetails> TabVersionDetails { get; set; }
        public virtual DbSet<TabVersions> TabVersions { get; set; }
        public virtual DbSet<TaxonomyScopeTypes> TaxonomyScopeTypes { get; set; }
        public virtual DbSet<TaxonomyTerms> TaxonomyTerms { get; set; }
        public virtual DbSet<TaxonomyVocabularies> TaxonomyVocabularies { get; set; }
        public virtual DbSet<TaxonomyVocabularyTypes> TaxonomyVocabularyTypes { get; set; }
        public virtual DbSet<UrlLog> UrlLog { get; set; }
        public virtual DbSet<Urls> Urls { get; set; }
        public virtual DbSet<UrlTracking> UrlTracking { get; set; }
        public virtual DbSet<UserAuthentication> UserAuthentication { get; set; }
        public virtual DbSet<UserPortals> UserPortals { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserRelationshipPreferences> UserRelationshipPreferences { get; set; }
        public virtual DbSet<UserRelationships> UserRelationships { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersOnline> UsersOnline { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }
        public virtual DbSet<VideosByMedia> VideosByMedia { get; set; }
        public virtual DbSet<VideosProcess> VideosProcess { get; set; }
        public virtual DbSet<VideosUserProcess> VideosUserProcess { get; set; }
        public virtual DbSet<VsThongkeBaoCao> VsThongkeBaoCao { get; set; }
        public virtual DbSet<VsThongKeBaoCaoFiles> VsThongKeBaoCaoFiles { get; set; }
        public virtual DbSet<WebLinks> WebLinks { get; set; }
        public virtual DbSet<WebServers> WebServers { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }
        public virtual DbSet<WorkflowStates> WorkflowStates { get; set; }

        // Unable to generate entity type for table 'dbo.DanhMucVB_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DanhMucTin_Map'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.News_Feeds'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NewsByUser'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NewsView'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Visitors'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.VS_ThongKeBaoCao_Categories'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=42.112.21.232,1221;Database=VASEP_New;Persist Security Info=True;User ID=news_core;Password=12345678@a;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnonymousUsers>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PortalId });

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastActiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.AnonymousUsers)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_AnonymousUsers_Portals");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__30910331310FC4CB")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("aspnet_Applications_Index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredEmail })
                    .HasName("aspnet_Membership_index")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__08C03A61");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__09B45E9A");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion });

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspNetSqlCacheTablesForChangeNotification>(entity =>
            {
                entity.HasKey(e => e.TableName);

                entity.ToTable("AspNet_SqlCacheTablesForChangeNotification");

                entity.Property(e => e.TableName)
                    .HasColumnName("tableName")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeId).HasColumnName("changeId");

                entity.Property(e => e.NotificationCreated)
                    .HasColumnName("notificationCreated")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.HasIndex(e => new { e.ApplicationId, e.LastActivityDate })
                    .HasName("aspnet_Users_Index2");

                entity.HasIndex(e => new { e.ApplicationId, e.LoweredUserName })
                    .HasName("aspnet_Users_Index")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__7889D298");
            });

            modelBuilder.Entity<Assemblies>(entity =>
            {
                entity.HasKey(e => e.AssemblyId);

                entity.Property(e => e.AssemblyId).HasColumnName("AssemblyID");

                entity.Property(e => e.AssemblyName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Assemblies)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PackageAssemblies_PackageAssemblies");
            });

            modelBuilder.Entity<AuthCookies>(entity =>
            {
                entity.HasKey(e => e.CookieId);

                entity.HasIndex(e => e.CookieValue)
                    .IsUnique();

                entity.Property(e => e.CookieValue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiresOn).HasColumnType("datetime");

                entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<Authentication>(entity =>
            {
                entity.Property(e => e.AuthenticationId).HasColumnName("AuthenticationID");

                entity.Property(e => e.AuthenticationType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LoginControlSrc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.LogoffControlSrc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PackageId)
                    .HasColumnName("PackageID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.SettingsControlSrc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Authentication)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_Authentication_Packages");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Click).HasDefaultValueSql("((0))");

                entity.Property(e => e.Contact).HasColumnType("ntext");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Height).HasMaxLength(50);

                entity.Property(e => e.Imglink)
                    .HasColumnName("IMGLink")
                    .HasMaxLength(500);

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.SView)
                    .HasColumnName("sView")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Startdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.Width).HasMaxLength(50);
            });

            modelBuilder.Entity<BannerStatic>(entity =>
            {
                entity.ToTable("Banner_Static");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.Isclick).HasColumnName("isclick");
            });

            modelBuilder.Entity<BannerTemplate>(entity =>
            {
                entity.ToTable("Banner_Template");

                entity.Property(e => e.FilePath).HasMaxLength(50);

                entity.Property(e => e.TemplateName).HasMaxLength(500);
            });

            modelBuilder.Entity<BannerVitri>(entity =>
            {
                entity.ToTable("Banner_Vitri");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(50);

                entity.Property(e => e.Images).HasMaxLength(500);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Portalid).HasColumnName("portalid");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CkeSettings>(entity =>
            {
                entity.HasKey(e => e.SettingName);

                entity.ToTable("CKE_Settings");

                entity.Property(e => e.SettingName)
                    .HasMaxLength(300)
                    .ValueGeneratedNever();

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<ContactForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Diachi).HasMaxLength(50);

                entity.Property(e => e.DiachiIp)
                    .HasColumnName("DiachiIP")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastNam).HasMaxLength(50);

                entity.Property(e => e.Noidung).HasMaxLength(200);

                entity.Property(e => e.Sodienthoai).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName).HasMaxLength(250);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.LastName).HasMaxLength(250);

                entity.Property(e => e.Subject).HasMaxLength(250);

                entity.Property(e => e.Tel).HasMaxLength(250);
            });

            modelBuilder.Entity<ContentItems>(entity =>
            {
                entity.HasKey(e => e.ContentItemId);

                entity.HasIndex(e => e.TabId);

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.ContentKey).HasMaxLength(250);

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.ContentItems)
                    .HasForeignKey(d => d.ContentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentItems_ContentTypes");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ContentItems)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ContentItems_ContentWorkflowStates");
            });

            modelBuilder.Entity<ContentItemsMetaData>(entity =>
            {
                entity.HasKey(e => e.ContentItemMetaDataId);

                entity.ToTable("ContentItems_MetaData");

                entity.HasIndex(e => e.ContentItemId)
                    .HasName("IX_ContentItems_MetaData_ContentItemId");

                entity.Property(e => e.ContentItemMetaDataId).HasColumnName("ContentItemMetaDataID");

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.MetaDataId).HasColumnName("MetaDataID");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.ContentItemsMetaData)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_ContentItems_MetaData_ContentItems");

                entity.HasOne(d => d.MetaData)
                    .WithMany(p => p.ContentItemsMetaData)
                    .HasForeignKey(d => d.MetaDataId)
                    .HasConstraintName("FK_ContentItems_MetaDataMetaData");
            });

            modelBuilder.Entity<ContentItemsTags>(entity =>
            {
                entity.HasKey(e => e.ContentItemTagId);

                entity.ToTable("ContentItems_Tags");

                entity.HasIndex(e => e.TermId);

                entity.HasIndex(e => new { e.ContentItemId, e.TermId })
                    .HasName("IX_ContentItems_Tags")
                    .IsUnique();

                entity.Property(e => e.ContentItemTagId).HasColumnName("ContentItemTagID");

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.ContentItemsTags)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_ContentItems_Tags_ContentItems");

                entity.HasOne(d => d.Term)
                    .WithMany(p => p.ContentItemsTags)
                    .HasForeignKey(d => d.TermId)
                    .HasConstraintName("FK_ContentItems_Tags_Taxonomy_Terms");
            });

            modelBuilder.Entity<ContentTypes>(entity =>
            {
                entity.HasKey(e => e.ContentTypeId);

                entity.HasIndex(e => e.ContentType)
                    .IsUnique();

                entity.Property(e => e.ContentTypeId).HasColumnName("ContentTypeID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ContentWorkflowActions>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.HasIndex(e => new { e.ContentTypeId, e.ActionType })
                    .HasName("ContentTypeId_ActionType")
                    .IsUnique();

                entity.Property(e => e.ActionSource)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ActionType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ContentType)
                    .WithMany(p => p.ContentWorkflowActions)
                    .HasForeignKey(d => d.ContentTypeId)
                    .HasConstraintName("FK_ContentWorkflowActions_ContentTypes");
            });

            modelBuilder.Entity<ContentWorkflowLogs>(entity =>
            {
                entity.HasKey(e => e.WorkflowLogId);

                entity.HasIndex(e => e.ContentItemId)
                    .HasName("IX_ContentWorkflowLogs_ContentItemId");

                entity.Property(e => e.WorkflowLogId).HasColumnName("WorkflowLogID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Type).HasDefaultValueSql("((-1))");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.ContentWorkflowLogs)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_ContentWorkflowLogs_ContentItems");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.ContentWorkflowLogs)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_ContentWorkflowLogs_ContentWorkflows");
            });

            modelBuilder.Entity<ContentWorkflows>(entity =>
            {
                entity.HasKey(e => e.WorkflowId);

                entity.HasIndex(e => new { e.PortalId, e.WorkflowName })
                    .HasName("IX_ContentWorkflows")
                    .IsUnique();

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.StartAfterCreating)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StartAfterEditing)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowKey)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<ContentWorkflowSources>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.HasIndex(e => new { e.WorkflowId, e.SourceName })
                    .HasName("IX_ContentWorkflowSources")
                    .IsUnique();

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SourceType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.ContentWorkflowSources)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_ContentWorkflowSources_ContentWorkflows");
            });

            modelBuilder.Entity<ContentWorkflowStatePermission>(entity =>
            {
                entity.HasKey(e => e.WorkflowStatePermissionId);

                entity.HasIndex(e => new { e.StateId, e.PermissionId, e.RoleId, e.UserId })
                    .HasName("IX_ContentWorkflowStatePermission")
                    .IsUnique();

                entity.Property(e => e.WorkflowStatePermissionId).HasColumnName("WorkflowStatePermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ContentWorkflowStatePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_ContentWorkflowStatePermission_Permission");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ContentWorkflowStatePermission)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_ContentWorkflowStatePermission_ContentWorkflowStates");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContentWorkflowStatePermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ContentWorkflowStatePermission_Users");
            });

            modelBuilder.Entity<ContentWorkflowStates>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.HasIndex(e => new { e.WorkflowId, e.StateName })
                    .HasName("IX_ContentWorkflowStates")
                    .IsUnique();

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OnCompleteMessageBody)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OnCompleteMessageSubject)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OnDiscardMessageBody)
                    .IsRequired()
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OnDiscardMessageSubject)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SendNotification)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendNotificationToAdministrators)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.ContentWorkflowStates)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_ContentWorkflowStates_ContentWorkflows");
            });

            modelBuilder.Entity<CoreMessagingMessageAttachments>(entity =>
            {
                entity.HasKey(e => e.MessageAttachmentId);

                entity.ToTable("CoreMessaging_MessageAttachments");

                entity.HasIndex(e => e.MessageId);

                entity.Property(e => e.MessageAttachmentId).HasColumnName("MessageAttachmentID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.CoreMessagingMessageAttachments)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_CoreMessaging_MessageAttachments_CoreMessaging_Messages");
            });

            modelBuilder.Entity<CoreMessagingMessageRecipients>(entity =>
            {
                entity.HasKey(e => e.RecipientId);

                entity.ToTable("CoreMessaging_MessageRecipients");

                entity.HasIndex(e => new { e.UserId, e.Read, e.Archived })
                    .HasName("IX_CoreMessaging_MessageRecipients_UserID");

                entity.HasIndex(e => new { e.MessageId, e.UserId, e.Read, e.SendToast })
                    .HasName("IX_CoreMessaging_MessageRecipients_UserID_MessageID_Read_SendToast")
                    .IsUnique();

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.EmailSentDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.CoreMessagingMessageRecipients)
                    .HasForeignKey(d => d.MessageId)
                    .HasConstraintName("FK_CoreMessaging_MessageRecipients_CoreMessaging_Messages");
            });

            modelBuilder.Entity<CoreMessagingMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("CoreMessaging_Messages");

                entity.HasIndex(e => new { e.SenderUserId, e.CreatedOnDate })
                    .HasName("IX_CoreMessaging_Messages_SenderUserID");

                entity.HasIndex(e => new { e.Context, e.IncludeDismissAction, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.To, e.From, e.Subject, e.Body, e.ConversationId, e.ReplyAllAllowed, e.SenderUserId, e.MessageId, e.PortalId, e.NotificationTypeId, e.ExpirationDate })
                    .HasName("IX_CoreMessaging_Messages_Send_MessageID_PortalID_NotificationTypeID_ExpirationDate")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Body).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Context).HasMaxLength(200);

                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.From).HasMaxLength(200);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SenderUserId).HasColumnName("SenderUserID");

                entity.Property(e => e.Subject).HasMaxLength(400);

                entity.Property(e => e.To).HasMaxLength(2000);

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.CoreMessagingMessages)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreMessaging_Messages_CoreMessaging_NotificationTypes");
            });

            modelBuilder.Entity<CoreMessagingNotificationTypeActions>(entity =>
            {
                entity.HasKey(e => e.NotificationTypeActionId);

                entity.ToTable("CoreMessaging_NotificationTypeActions");

                entity.HasIndex(e => e.NotificationTypeId)
                    .HasName("IX_CoreMessaging_NotificationTypeActions");

                entity.Property(e => e.NotificationTypeActionId).HasColumnName("NotificationTypeActionID");

                entity.Property(e => e.Apicall)
                    .IsRequired()
                    .HasColumnName("APICall")
                    .HasMaxLength(500);

                entity.Property(e => e.ConfirmResourceKey).HasMaxLength(100);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DescriptionResourceKey).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.NameResourceKey)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.CoreMessagingNotificationTypeActions)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .HasConstraintName("FK_CoreMessaging_NotificationTypeActions_CoreMessaging_NotificationTypes");
            });

            modelBuilder.Entity<CoreMessagingNotificationTypes>(entity =>
            {
                entity.HasKey(e => e.NotificationTypeId);

                entity.ToTable("CoreMessaging_NotificationTypes");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_CoreMessaging_NotificationTypes")
                    .IsUnique();

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ttl).HasColumnName("TTL");

                entity.HasOne(d => d.DesktopModule)
                    .WithMany(p => p.CoreMessagingNotificationTypes)
                    .HasForeignKey(d => d.DesktopModuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreMessaging_NotificationTypes_DesktopModules");
            });

            modelBuilder.Entity<CoreMessagingSubscriptions>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("CoreMessaging_Subscriptions");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ObjectKey).HasMaxLength(255);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.CoreMessagingSubscriptions)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreMessaging_Subscriptions_Modules");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.CoreMessagingSubscriptions)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CoreMessaging_Subscriptions_Portals");

                entity.HasOne(d => d.SubscriptionType)
                    .WithMany(p => p.CoreMessagingSubscriptions)
                    .HasForeignKey(d => d.SubscriptionTypeId)
                    .HasConstraintName("FK_CoreMessaging_Subscriptions_Subscriptions_Type");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CoreMessagingSubscriptions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CoreMessaging_Subscriptions_Users");
            });

            modelBuilder.Entity<CoreMessagingSubscriptionTypes>(entity =>
            {
                entity.HasKey(e => e.SubscriptionTypeId);

                entity.ToTable("CoreMessaging_SubscriptionTypes");

                entity.HasIndex(e => e.SubscriptionName)
                    .IsUnique();

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SubscriptionName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CoreMessagingUserPreferences>(entity =>
            {
                entity.HasKey(e => e.UserPreferenceId);

                entity.ToTable("CoreMessaging_UserPreferences");
            });

            modelBuilder.Entity<DesktopModulePermission>(entity =>
            {
                entity.HasIndex(e => new { e.AllowAccess, e.RoleId, e.PortalDesktopModuleId, e.PermissionId })
                    .HasName("IX_DesktopModulePermission_Roles")
                    .IsUnique()
                    .HasFilter("([RoleID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.UserId, e.PortalDesktopModuleId, e.PermissionId })
                    .HasName("IX_DesktopModulePermission_Users")
                    .IsUnique()
                    .HasFilter("([UserID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.PortalDesktopModuleId, e.PermissionId, e.RoleId, e.UserId })
                    .HasName("IX_DesktopModulePermission_DesktopModules")
                    .IsUnique();

                entity.Property(e => e.DesktopModulePermissionId).HasColumnName("DesktopModulePermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.PortalDesktopModuleId).HasColumnName("PortalDesktopModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.DesktopModulePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_DesktopModulePermission_Permission");

                entity.HasOne(d => d.PortalDesktopModule)
                    .WithMany(p => p.DesktopModulePermission)
                    .HasForeignKey(d => d.PortalDesktopModuleId)
                    .HasConstraintName("FK_DesktopModulePermission_PortalDesktopModules");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DesktopModulePermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_DesktopModulePermission_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DesktopModulePermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DesktopModulePermission_Users");
            });

            modelBuilder.Entity<DesktopModules>(entity =>
            {
                entity.HasKey(e => e.DesktopModuleId);

                entity.HasIndex(e => e.FriendlyName);

                entity.HasIndex(e => e.ModuleName)
                    .HasName("IX_DesktopModules_ModuleName")
                    .IsUnique();

                entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");

                entity.Property(e => e.AdminPage).HasMaxLength(128);

                entity.Property(e => e.BusinessControllerClass).HasMaxLength(200);

                entity.Property(e => e.CompatibleVersions).HasMaxLength(500);

                entity.Property(e => e.ContentItemId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Dependencies).HasMaxLength(400);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.FolderName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.HostPage).HasMaxLength(128);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PackageId)
                    .HasColumnName("PackageID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Permissions).HasMaxLength(400);

                entity.Property(e => e.Version).HasMaxLength(8);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.DesktopModules)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_DesktopModules_Packages");
            });

            modelBuilder.Entity<Docs>(entity =>
            {
                entity.Property(e => e.CategoryIds).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Field).HasMaxLength(200);

                entity.Property(e => e.IssuedDate).HasColumnType("datetime");

                entity.Property(e => e.Keyword).HasMaxLength(1000);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(4000);

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.Quote).HasMaxLength(4000);

                entity.Property(e => e.Signer).HasMaxLength(200);

                entity.Property(e => e.Source).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.ValidedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocsFeedback>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Files).IsUnicode(false);

                entity.Property(e => e.FullName).HasMaxLength(255);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DocsFiles>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileExtension).HasMaxLength(10);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FileUrl).HasMaxLength(1000);
            });

            modelBuilder.Entity<DocsLike>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EventLog>(entity =>
            {
                entity.HasKey(e => e.LogEventId);

                entity.HasIndex(e => e.LogGuid);

                entity.HasIndex(e => new { e.LogConfigId, e.LogCreateDate })
                    .HasName("IX_EventLog_LogCreateDate");

                entity.HasIndex(e => new { e.LogTypeKey, e.LogPortalId })
                    .HasName("IX_EventLog_LogType");

                entity.HasIndex(e => new { e.LogEventId, e.LogConfigId, e.LogNotificationPending, e.LogCreateDate })
                    .HasName("IX_EventLog_LogConfigID");

                entity.Property(e => e.LogEventId).HasColumnName("LogEventID");

                entity.Property(e => e.ExceptionHash)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogConfigId).HasColumnName("LogConfigID");

                entity.Property(e => e.LogCreateDate).HasColumnType("datetime");

                entity.Property(e => e.LogGuid)
                    .IsRequired()
                    .HasColumnName("LogGUID")
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.LogPortalId).HasColumnName("LogPortalID");

                entity.Property(e => e.LogPortalName).HasMaxLength(100);

                entity.Property(e => e.LogProperties).HasColumnType("xml");

                entity.Property(e => e.LogServerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogTypeKey)
                    .IsRequired()
                    .HasMaxLength(35);

                entity.Property(e => e.LogUserId).HasColumnName("LogUserID");

                entity.Property(e => e.LogUserName).HasMaxLength(50);

                entity.HasOne(d => d.LogConfig)
                    .WithMany(p => p.EventLog)
                    .HasForeignKey(d => d.LogConfigId)
                    .HasConstraintName("FK_EventLog_EventLogConfig");

                entity.HasOne(d => d.LogTypeKeyNavigation)
                    .WithMany(p => p.EventLog)
                    .HasForeignKey(d => d.LogTypeKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventLog_EventLogTypes");
            });

            modelBuilder.Entity<EventLogConfig>(entity =>
            {
                entity.HasIndex(e => new { e.LogTypeKey, e.LogTypePortalId })
                    .HasName("IX_LogTypeKey_LogTypePortalID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LogTypeKey).HasMaxLength(35);

                entity.Property(e => e.LogTypePortalId).HasColumnName("LogTypePortalID");

                entity.Property(e => e.MailFromAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MailToAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.LogTypeKeyNavigation)
                    .WithMany(p => p.EventLogConfig)
                    .HasForeignKey(d => d.LogTypeKey)
                    .HasConstraintName("FK_EventLogConfig_EventLogTypes");
            });

            modelBuilder.Entity<EventLogTypes>(entity =>
            {
                entity.HasKey(e => e.LogTypeKey);

                entity.Property(e => e.LogTypeKey)
                    .HasMaxLength(35)
                    .ValueGeneratedNever();

                entity.Property(e => e.LogTypeCssclass)
                    .IsRequired()
                    .HasColumnName("LogTypeCSSClass")
                    .HasMaxLength(40);

                entity.Property(e => e.LogTypeDescription)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LogTypeFriendlyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogTypeOwner)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EventQueue>(entity =>
            {
                entity.HasKey(e => e.EventMessageId);

                entity.Property(e => e.EventMessageId).HasColumnName("EventMessageID");

                entity.Property(e => e.Attributes)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.AuthorizedRoles)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ExceptionMessage)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessorCommand)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ProcessorType)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Sender)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.SentDate).HasColumnType("datetime");

                entity.Property(e => e.Subscriber)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ExceptionEvents>(entity =>
            {
                entity.HasKey(e => e.LogEventId);

                entity.Property(e => e.LogEventId)
                    .HasColumnName("LogEventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssemblyVersion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RawUrl).HasMaxLength(260);

                entity.Property(e => e.Referrer).HasMaxLength(260);

                entity.Property(e => e.UserAgent).HasMaxLength(260);

                entity.HasOne(d => d.LogEvent)
                    .WithOne(p => p.ExceptionEvents)
                    .HasForeignKey<ExceptionEvents>(d => d.LogEventId)
                    .HasConstraintName("FK_ExceptionEvents_LogEventId");
            });

            modelBuilder.Entity<Exceptions>(entity =>
            {
                entity.HasKey(e => e.ExceptionHash);

                entity.Property(e => e.ExceptionHash)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.InnerMessage).HasMaxLength(500);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Source).HasMaxLength(500);
            });

            modelBuilder.Entity<ExportImportCheckpoints>(entity =>
            {
                entity.HasKey(e => e.CheckpointId);

                entity.HasIndex(e => e.Category);

                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => new { e.Category, e.AssemblyName, e.JobId })
                    .HasName("IX_ExportImportCheckpoints_Composite")
                    .IsUnique();

                entity.Property(e => e.AssemblyName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Completed).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.ExportImportCheckpoints)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_ExportImportCheckpoints_JobId");
            });

            modelBuilder.Entity<ExportImportJobLogs>(entity =>
            {
                entity.HasKey(e => e.JobLogId);

                entity.HasIndex(e => e.JobId);

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.ExportImportJobLogs)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_ExportImportJobLogs_JobId");
            });

            modelBuilder.Entity<ExportImportJobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.HasIndex(e => e.CreatedOnDate)
                    .HasName("IX_ExportImportJobs_CreatedOn");

                entity.HasIndex(e => e.JobStatus);

                entity.HasIndex(e => e.JobType);

                entity.Property(e => e.CompletedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Directory).HasMaxLength(100);

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ExportImportSettings>(entity =>
            {
                entity.HasKey(e => e.SettingName);

                entity.Property(e => e.SettingName)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<ExtensionUrlProviderConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId });

                entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");
            });

            modelBuilder.Entity<ExtensionUrlProviders>(entity =>
            {
                entity.HasKey(e => e.ExtensionUrlProviderId);

                entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");

                entity.Property(e => e.ProviderName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ProviderType)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.SettingsControlSrc).HasMaxLength(1000);
            });

            modelBuilder.Entity<ExtensionUrlProviderSetting>(entity =>
            {
                entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId, e.SettingName });

                entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SettingName).HasMaxLength(100);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<ExtensionUrlProviderTab>(entity =>
            {
                entity.HasKey(e => new { e.ExtensionUrlProviderId, e.PortalId, e.TabId });

                entity.Property(e => e.ExtensionUrlProviderId).HasColumnName("ExtensionUrlProviderID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.TabId).HasColumnName("TabID");
            });

            modelBuilder.Entity<Faq>(entity =>
            {
                entity.ToTable("FAQ");

                entity.Property(e => e.AnswerUserId).HasMaxLength(500);

                entity.Property(e => e.AnswerUsername).HasMaxLength(1000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultAnswerImage).HasMaxLength(200);

                entity.Property(e => e.DefaultAnswerName).HasMaxLength(500);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Faqanswers>(entity =>
            {
                entity.ToTable("FAQAnswers");

                entity.Property(e => e.AnswerImage).HasMaxLength(200);

                entity.Property(e => e.AnswerName).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Faqquestions>(entity =>
            {
                entity.ToTable("FAQQuestions");

                entity.Property(e => e.Adress).HasMaxLength(300);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Faqid).HasColumnName("FAQID");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.HasIndex(e => e.UniqueId)
                    .HasName("IX_Files_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => new { e.FileId, e.FileName, e.FolderId, e.PublishedVersion, e.ContentItemId })
                    .HasName("IX_Files_ContentID")
                    .HasFilter("([ContentItemId] IS NOT NULL)");

                entity.HasIndex(e => new { e.FileId, e.PublishedVersion, e.PortalId, e.FolderId, e.FileName })
                    .HasName("IX_Files_PortalID")
                    .IsUnique();

                entity.HasIndex(e => new { e.PortalId, e.FileName, e.FolderId, e.PublishedVersion, e.FileId })
                    .HasName("IX_Files_FileID")
                    .HasFilter("([ContentItemId] IS NOT NULL)");

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(246);

                entity.Property(e => e.Folder)
                    .HasMaxLength(246)
                    .HasComputedColumnSql("([dbo].[GetFileFolderFunc]([FolderID]))");

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.HasBeenPublished)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastModificationTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PublishedVersion).HasDefaultValueSql("((1))");

                entity.Property(e => e.Sha1hash)
                    .HasColumnName("SHA1Hash")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title).HasMaxLength(256);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_Files_ContentItems");

                entity.HasOne(d => d.FolderNavigation)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.FolderId)
                    .HasConstraintName("FK_Files_Folders");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Files)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_Files_Portals");
            });

            modelBuilder.Entity<FileVersions>(entity =>
            {
                entity.HasKey(e => new { e.FileId, e.Version });

                entity.Property(e => e.Content).HasColumnType("image");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(246);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Sha1hash)
                    .HasColumnName("SHA1Hash")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.FileVersions)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_FileVersions_Files");
            });

            modelBuilder.Entity<FolderMappings>(entity =>
            {
                entity.HasKey(e => e.FolderMappingId);

                entity.HasIndex(e => new { e.PortalId, e.MappingName })
                    .HasName("IX_FolderMappings")
                    .IsUnique();

                entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.FolderProviderType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.MappingName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.FolderMappings)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FolderMappings_Portals");
            });

            modelBuilder.Entity<FolderMappingsSettings>(entity =>
            {
                entity.HasKey(e => new { e.FolderMappingId, e.SettingName });

                entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.FolderMapping)
                    .WithMany(p => p.FolderMappingsSettings)
                    .HasForeignKey(d => d.FolderMappingId)
                    .HasConstraintName("FK_FolderMappingsSettings_FolderMappings");
            });

            modelBuilder.Entity<FolderPermission>(entity =>
            {
                entity.HasIndex(e => e.FolderId)
                    .HasName("IX_FolderPermission_Modules");

                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_FolderPermission_Permission");

                entity.HasIndex(e => new { e.AllowAccess, e.RoleId, e.FolderId, e.PermissionId })
                    .HasName("IX_FolderPermission_Roles")
                    .IsUnique()
                    .HasFilter("([RoleID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.UserId, e.FolderId, e.PermissionId })
                    .HasName("IX_FolderPermission_Users")
                    .IsUnique()
                    .HasFilter("([UserID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.FolderId, e.PermissionId, e.RoleId, e.UserId })
                    .HasName("IX_FolderPermission_Folders")
                    .IsUnique();

                entity.Property(e => e.FolderPermissionId).HasColumnName("FolderPermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.FolderPermission)
                    .HasForeignKey(d => d.FolderId)
                    .HasConstraintName("FK_FolderPermission_Folders");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.FolderPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_FolderPermission_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FolderPermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_FolderPermission_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FolderPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_FolderPermission_Users");
            });

            modelBuilder.Entity<Folders>(entity =>
            {
                entity.HasKey(e => e.FolderId);

                entity.HasIndex(e => e.UniqueId)
                    .HasName("IX_Folders_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => new { e.PortalId, e.FolderPath })
                    .HasName("IX_FolderPath")
                    .IsUnique();

                entity.HasIndex(e => new { e.FolderId, e.PortalId, e.ParentId, e.FolderPath })
                    .HasName("IX_Folders_ParentID");

                entity.HasIndex(e => new { e.PortalId, e.FolderPath, e.StorageLocation, e.IsCached, e.FolderMappingId, e.FolderId })
                    .HasName("IX_Folders_FolderID")
                    .IsUnique();

                entity.Property(e => e.FolderId).HasColumnName("FolderID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.FolderMappingId).HasColumnName("FolderMappingID");

                entity.Property(e => e.FolderPath)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.Property(e => e.MappedPath).HasMaxLength(300);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.FolderMapping)
                    .WithMany(p => p.Folders)
                    .HasForeignKey(d => d.FolderMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Folders_FolderMappings");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Folders)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Folders_Portals");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.Folders)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Folders_ContentWorkflows");
            });

            modelBuilder.Entity<HostSettings>(entity =>
            {
                entity.HasKey(e => e.SettingName);

                entity.Property(e => e.SettingName)
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<HtmlText>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => new { e.ModuleId, e.Version });

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Summary).HasColumnType("ntext");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.HtmlText)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_HtmlText_Modules");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.HtmlText)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_HtmlText_WorkflowStates");
            });

            modelBuilder.Entity<HtmlTextLog>(entity =>
            {
                entity.HasIndex(e => new { e.HtmlTextLogId, e.ItemId })
                    .HasName("IX_HtmlTextLog_ItemID");

                entity.Property(e => e.HtmlTextLogId).HasColumnName("HtmlTextLogID");

                entity.Property(e => e.Comment).HasMaxLength(4000);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.HtmlTextLog)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_HtmlTextLog_HtmlText");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.HtmlTextLog)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HtmlTextLog_WorkflowStates");
            });

            modelBuilder.Entity<HtmlTextUsers>(entity =>
            {
                entity.HasKey(e => e.HtmlTextUserId);

                entity.Property(e => e.HtmlTextUserId).HasColumnName("HtmlTextUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.HtmlTextUsers)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_HtmlTextUsers_HtmlText");
            });

            modelBuilder.Entity<Ipfilter>(entity =>
            {
                entity.ToTable("IPFilter");

                entity.Property(e => e.IpfilterId).HasColumnName("IPFilterID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SubnetMask).HasMaxLength(50);
            });

            modelBuilder.Entity<JavaScriptLibraries>(entity =>
            {
                entity.HasKey(e => e.JavaScriptLibraryId);

                entity.Property(e => e.JavaScriptLibraryId).HasColumnName("JavaScriptLibraryID");

                entity.Property(e => e.Cdnpath)
                    .IsRequired()
                    .HasColumnName("CDNPath")
                    .HasMaxLength(250);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LibraryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.JavaScriptLibraries)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_JavaScriptLibrariesPackages");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.HasIndex(e => new { e.GroupId, e.ContentItemId })
                    .HasName("IX_Journal_ContentItemId");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(255);

                entity.Property(e => e.ItemData).HasMaxLength(2000);

                entity.Property(e => e.ObjectKey).HasMaxLength(255);

                entity.Property(e => e.ProfileId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Summary).HasMaxLength(2000);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.JournalType)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.JournalTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Journal_JournalTypes");
            });

            modelBuilder.Entity<JournalAccess>(entity =>
            {
                entity.ToTable("Journal_Access");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JournalComments>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("Journal_Comments");

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CommentXml)
                    .HasColumnName("CommentXML")
                    .HasColumnType("xml");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.JournalComments)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_JournalComments_Journal");
            });

            modelBuilder.Entity<JournalData>(entity =>
            {
                entity.ToTable("Journal_Data");

                entity.Property(e => e.JournalXml)
                    .IsRequired()
                    .HasColumnName("JournalXML")
                    .HasColumnType("xml");

                entity.HasOne(d => d.Journal)
                    .WithMany(p => p.JournalData)
                    .HasForeignKey(d => d.JournalId)
                    .HasConstraintName("FK_Journal_Data_Journal");
            });

            modelBuilder.Entity<JournalSecurity>(entity =>
            {
                entity.ToTable("Journal_Security");

                entity.HasIndex(e => new { e.JournalId, e.SecurityKey })
                    .HasName("IX_Journal_Security")
                    .IsUnique();

                entity.Property(e => e.SecurityKey)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JournalTypeFilters>(entity =>
            {
                entity.HasKey(e => e.JournalTypeFilterId);

                entity.ToTable("Journal_TypeFilters");
            });

            modelBuilder.Entity<JournalTypes>(entity =>
            {
                entity.HasKey(e => e.JournalTypeId);

                entity.ToTable("Journal_Types");

                entity.Property(e => e.JournalTypeId).ValueGeneratedNever();

                entity.Property(e => e.AppliesToGroup)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AppliesToProfile)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AppliesToStream)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EnableComments)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Icon)
                    .HasColumnName("icon")
                    .HasMaxLength(25);

                entity.Property(e => e.IsEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JournalType).HasMaxLength(25);

                entity.Property(e => e.PortalId).HasDefaultValueSql("((-1))");
            });

            modelBuilder.Entity<LanguagePacks>(entity =>
            {
                entity.HasKey(e => e.LanguagePackId);

                entity.HasIndex(e => new { e.LanguageId, e.PackageId })
                    .HasName("IX_LanguagePacks")
                    .IsUnique();

                entity.Property(e => e.LanguagePackId).HasColumnName("LanguagePackID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DependentPackageId).HasColumnName("DependentPackageID");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.LanguagePacks)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_LanguagePacks_Packages");
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.HasIndex(e => e.CultureCode)
                    .HasName("IX_Languages")
                    .IsUnique();

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CultureName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FallbackCulture).HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LichLamViec>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Files).HasMaxLength(255);

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTitle).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Lists>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.HasIndex(e => new { e.ListName, e.ParentId });

                entity.HasIndex(e => new { e.ListName, e.Value, e.Text, e.ParentId })
                    .HasName("IX_Lists_ListName_Value_Text_ParentID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Text, e.SortOrder, e.DefinitionId, e.ParentId, e.ListName, e.Value })
                    .HasName("IX_Lists_ParentID")
                    .IsUnique();

                entity.HasIndex(e => new { e.Value, e.Text, e.DefinitionId, e.PortalId, e.ParentId, e.ListName, e.SortOrder })
                    .HasName("IX_Lists_SortOrder");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DefinitionId).HasColumnName("DefinitionID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PortalId)
                    .HasColumnName("PortalID")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MediaItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extension)
                    .HasColumnName("extension")
                    .HasMaxLength(50);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(200);

                entity.Property(e => e.Forder)
                    .HasColumnName("forder")
                    .HasMaxLength(200);

                entity.Property(e => e.MediaUrl).HasMaxLength(500);

                entity.Property(e => e.Portalid).HasColumnName("portalid");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(500);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<MessagingMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("Messaging_Messages");

                entity.HasIndex(e => new { e.FromUserId, e.Status, e.Date })
                    .HasName("IX_Messaging_Messages_FromUserID_Status");

                entity.HasIndex(e => new { e.EmailSent, e.EmailSchedulerInstance, e.Status, e.Date })
                    .HasName("IX_Messaging_Messages_EmailSent_EmailSchedulerInstance_Status");

                entity.HasIndex(e => new { e.ToUserId, e.Status, e.SkipPortal, e.Date })
                    .HasName("IX_Messaging_Messages_ToUserID_Status_SkipPortal");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmailSentDate).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.FromUserName).HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.ToRoleId).HasColumnName("ToRoleID");

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");

                entity.Property(e => e.ToUserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MetaData>(entity =>
            {
                entity.HasIndex(e => e.MetaDataName)
                    .IsUnique();

                entity.Property(e => e.MetaDataId).HasColumnName("MetaDataID");

                entity.Property(e => e.MetaDataDescription).HasMaxLength(2500);

                entity.Property(e => e.MetaDataName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Mi>(entity =>
            {
                entity.ToTable("MI");

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.AvatarUrl).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(250);

                entity.Property(e => e.CompanyName).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Eucode)
                    .HasColumnName("EUCode")
                    .HasMaxLength(500);

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ExportMarket).HasMaxLength(500);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Field).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Products).HasMaxLength(4000);

                entity.Property(e => e.ProfileUrl).HasMaxLength(200);

                entity.Property(e => e.Quality).HasMaxLength(4000);

                entity.Property(e => e.Recommender).HasMaxLength(50);

                entity.Property(e => e.ScopeOfWork).HasMaxLength(500);

                entity.Property(e => e.ShortName).HasMaxLength(255);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.TradeNames).HasMaxLength(500);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfBusiness).HasMaxLength(500);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Website).HasMaxLength(250);
            });

            modelBuilder.Entity<MobilePreviewProfiles>(entity =>
            {
                entity.ToTable("Mobile_PreviewProfiles");

                entity.HasIndex(e => e.SortOrder);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.MobilePreviewProfiles)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_Mobile_PreviewProfiles_Portals");
            });

            modelBuilder.Entity<MobileRedirectionRules>(entity =>
            {
                entity.ToTable("Mobile_RedirectionRules");

                entity.Property(e => e.Capability)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Expression)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Redirection)
                    .WithMany(p => p.MobileRedirectionRules)
                    .HasForeignKey(d => d.RedirectionId)
                    .HasConstraintName("FK_Mobile_RedirectionRules_Mobile_Redirections");
            });

            modelBuilder.Entity<MobileRedirections>(entity =>
            {
                entity.ToTable("Mobile_Redirections");

                entity.HasIndex(e => e.SortOrder);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TargetValue)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.MobileRedirections)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_Mobile_Redirections_Portals");
            });

            modelBuilder.Entity<ModuleControls>(entity =>
            {
                entity.HasKey(e => e.ModuleControlId);

                entity.HasIndex(e => new { e.ControlKey, e.ViewOrder });

                entity.HasIndex(e => new { e.ModuleDefId, e.ControlKey, e.ControlSrc })
                    .HasName("IX_ModuleControls")
                    .IsUnique();

                entity.Property(e => e.ModuleControlId).HasColumnName("ModuleControlID");

                entity.Property(e => e.ControlKey).HasMaxLength(50);

                entity.Property(e => e.ControlSrc).HasMaxLength(256);

                entity.Property(e => e.ControlTitle).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.HelpUrl).HasMaxLength(200);

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

                entity.HasOne(d => d.ModuleDef)
                    .WithMany(p => p.ModuleControls)
                    .HasForeignKey(d => d.ModuleDefId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ModuleControls_ModuleDefinitions");
            });

            modelBuilder.Entity<ModuleDefinitions>(entity =>
            {
                entity.HasKey(e => e.ModuleDefId);

                entity.HasIndex(e => e.DefinitionName)
                    .HasName("IX_ModuleDefinitions")
                    .IsUnique();

                entity.HasIndex(e => e.DesktopModuleId)
                    .HasName("IX_ModuleDefinitions_1");

                entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DefinitionName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.HasOne(d => d.DesktopModule)
                    .WithMany(p => p.ModuleDefinitions)
                    .HasForeignKey(d => d.DesktopModuleId)
                    .HasConstraintName("FK_ModuleDefinitions_DesktopModules");
            });

            modelBuilder.Entity<ModulePermission>(entity =>
            {
                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_ModulePermission_Permission");

                entity.HasIndex(e => new { e.AllowAccess, e.RoleId, e.ModuleId, e.PermissionId, e.PortalId })
                    .HasName("IX_ModulePermission_Roles")
                    .IsUnique()
                    .HasFilter("([RoleID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.UserId, e.ModuleId, e.PermissionId, e.PortalId })
                    .HasName("IX_ModulePermission_Users")
                    .IsUnique()
                    .HasFilter("([UserID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.ModuleId, e.PermissionId, e.PortalId, e.RoleId, e.UserId })
                    .HasName("IX_ModulePermission_Modules")
                    .IsUnique();

                entity.Property(e => e.ModulePermissionId).HasColumnName("ModulePermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_ModulePermission_Modules");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_ModulePermission_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ModulePermission_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ModulePermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ModulePermission_Users");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.HasIndex(e => e.PortalId)
                    .HasName("IX_Modules_PortalId");

                entity.HasIndex(e => new { e.AllTabs, e.InheritViewPermissions, e.StartDate, e.EndDate, e.PortalId, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.LastContentModifiedOnDate, e.IsShareable, e.IsShareableViewOnly, e.ModuleDefId, e.ModuleId })
                    .HasName("IX_Modules_ModuleDefId");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsShareable)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShareableViewOnly)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastContentModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_Modules_ContentItems");

                entity.HasOne(d => d.ModuleDef)
                    .WithMany(p => p.Modules)
                    .HasForeignKey(d => d.ModuleDefId)
                    .HasConstraintName("FK_Modules_ModuleDefinitions");
            });

            modelBuilder.Entity<ModuleSettings>(entity =>
            {
                entity.HasKey(e => new { e.ModuleId, e.SettingName });

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ModuleSettings)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_ModuleSettings_Modules");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasKey(e => e.NewId);

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovalRequestDate).HasColumnType("datetime");

                entity.Property(e => e.ArchivedDate).HasColumnType("datetime");

                entity.Property(e => e.AttachedFiles).HasMaxLength(1000);

                entity.Property(e => e.ButDanh).HasMaxLength(50);

                entity.Property(e => e.CancelPublishDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.Createdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Credit).HasDefaultValueSql("((0))");

                entity.Property(e => e.EditedTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.Hotcat).HasDefaultValueSql("((0))");

                entity.Property(e => e.Hotsite).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImagePath).HasMaxLength(250);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsAmp).HasColumnName("IsAMP");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEdited).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsImage).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPhoto).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPr)
                    .HasColumnName("IsPR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsVideo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Keyword)
                    .HasColumnName("keyword")
                    .HasMaxLength(100);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.Links).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.Permission).HasMaxLength(255);

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceText).HasMaxLength(200);

                entity.Property(e => e.Status).HasDefaultValueSql("((0))");

                entity.Property(e => e.StorageFolder).HasMaxLength(200);

                entity.Property(e => e.Summary).HasColumnType("ntext");

                entity.Property(e => e.Tacgia).HasMaxLength(50);

                entity.Property(e => e.Tags).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(1000);

                entity.Property(e => e.TypeUrl).HasMaxLength(200);

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.VoteCount).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsByMedia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdted)
                    .HasColumnName("createdted")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mediaid).HasColumnName("mediaid");

                entity.Property(e => e.Newid).HasColumnName("newid");

                entity.Property(e => e.Portalid).HasColumnName("portalid");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<NewsByShare>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LinkShare).HasMaxLength(500);
            });

            modelBuilder.Entity<NewsByTags>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Tags).HasMaxLength(50);

                entity.Property(e => e.TagsTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<NewsByVideo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<NewsByView>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(400);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EnglishName).HasMaxLength(200);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.ParentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.TabIdm).HasColumnName("TabIDM");
            });

            modelBuilder.Entity<NewsCustomeCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<NewsFeedback>(entity =>
            {
                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Iptrack)
                    .HasColumnName("IPTrack")
                    .HasMaxLength(50);

                entity.Property(e => e.OLike).HasColumnName("oLike");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<NewsKpi>(entity =>
            {
                entity.ToTable("News_KPI");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Pvcreateddate)
                    .HasColumnName("PVCreateddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pvsobai).HasColumnName("PVSobai");

                entity.Property(e => e.Pvsoview).HasColumnName("PVSoview");

                entity.Property(e => e.PvuserId).HasColumnName("PVUserId");

                entity.Property(e => e.Thang)
                    .HasColumnName("thang")
                    .HasMaxLength(6);

                entity.Property(e => e.Thangfull)
                    .HasColumnName("thangfull")
                    .HasColumnType("datetime");

                entity.Property(e => e.YeuCaucreateddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<NewsNhuanBut>(entity =>
            {
                entity.ToTable("News_NhuanBut");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdate).HasColumnType("datetime");

                entity.Property(e => e.UserChamNhuanButDate).HasColumnType("datetime");

                entity.Property(e => e.XuatBan).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NewsProcess>(entity =>
            {
                entity.ToTable("News_Process");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Iptrack)
                    .HasColumnName("IPTrack")
                    .HasMaxLength(50);

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.ProcessName).HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<NewsSettings>(entity =>
            {
                entity.ToTable("News_Settings");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<NewsStatus>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NewsUserProcess>(entity =>
            {
                entity.ToTable("News_UserProcess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NewsUserWf>(entity =>
            {
                entity.ToTable("News_UserWF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IconLarge).HasMaxLength(250);

                entity.Property(e => e.IconSmall).HasMaxLength(250);

                entity.Property(e => e.LanguageId).HasMaxLength(50);

                entity.Property(e => e.LoaiWf).HasColumnName("LoaiWF");

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.NguoiNhan).HasMaxLength(500);

                entity.Property(e => e.TenLuong)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<NewsVersion>(entity =>
            {
                entity.ToTable("News_Version");

                entity.Property(e => e.AttachedFiles).HasMaxLength(1000);

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.ImagePath).HasMaxLength(250);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Links).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(200);

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.StorageFolder).HasMaxLength(200);

                entity.Property(e => e.Summary).HasColumnType("ntext");

                entity.Property(e => e.Tags)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TypeUrl).HasMaxLength(200);
            });

            modelBuilder.Entity<OutputCache>(entity =>
            {
                entity.HasKey(e => e.CacheKey);

                entity.Property(e => e.CacheKey)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Expiration).HasColumnType("datetime");
            });

            modelBuilder.Entity<PackageDependencies>(entity =>
            {
                entity.HasKey(e => e.PackageDependencyId);

                entity.Property(e => e.PackageDependencyId).HasColumnName("PackageDependencyID");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PackageName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageDependencies)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_PackageDependencies_Packages");
            });

            modelBuilder.Entity<Packages>(entity =>
            {
                entity.HasKey(e => e.PackageId);

                entity.HasIndex(e => new { e.Owner, e.Name, e.PackageType, e.PortalId, e.Version })
                    .HasName("IX_Packages")
                    .IsUnique();

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FolderName).HasMaxLength(128);

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.License).HasColumnType("ntext");

                entity.Property(e => e.Manifest).HasColumnType("ntext");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Organization).HasMaxLength(100);

                entity.Property(e => e.Owner).HasMaxLength(100);

                entity.Property(e => e.PackageType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.ReleaseNotes).HasColumnType("ntext");

                entity.Property(e => e.Url).HasMaxLength(250);

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PackageTypeNavigation)
                    .WithMany(p => p.Packages)
                    .HasForeignKey(d => d.PackageType)
                    .HasConstraintName("FK_Packages_PackageTypes");
            });

            modelBuilder.Entity<PackageTypes>(entity =>
            {
                entity.HasKey(e => e.PackageType);

                entity.Property(e => e.PackageType)
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.EditorControlSrc).HasMaxLength(250);
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.Property(e => e.PasswordHistoryId).HasColumnName("PasswordHistoryID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PasswordHistory)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_PasswordHistory_Users");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasIndex(e => new { e.PermissionCode, e.ModuleDefId, e.PermissionKey })
                    .HasName("IX_Permission")
                    .IsUnique();

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

                entity.Property(e => e.PermissionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewOrder).HasDefaultValueSql("((9999))");
            });

            modelBuilder.Entity<PersonaBarExtensions>(entity =>
            {
                entity.HasKey(e => e.ExtensionId);

                entity.HasIndex(e => e.Identifier)
                    .HasName("IX_PersonaBarExtensions")
                    .IsUnique();

                entity.Property(e => e.Container)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Controller).HasMaxLength(260);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FolderName).HasMaxLength(50);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.PersonaBarExtensions)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_PersonaBarExtensions_MenuId");
            });

            modelBuilder.Entity<PersonaBarMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.HasIndex(e => e.Identifier)
                    .HasName("IX_PersonaBarMenu")
                    .IsUnique();

                entity.Property(e => e.Controller).HasMaxLength(260);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CssClass).HasMaxLength(50);

                entity.Property(e => e.FolderName).HasMaxLength(50);

                entity.Property(e => e.IconFile).HasMaxLength(260);

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Link).HasMaxLength(260);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(260);

                entity.Property(e => e.ResourceKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_PersonaBarMenu_ParentId");
            });

            modelBuilder.Entity<PersonaBarMenuDefaultPermissions>(entity =>
            {
                entity.HasIndex(e => e.MenuId)
                    .HasName("IX_PersonaBarMenuDefaultPermissions")
                    .IsUnique();

                entity.Property(e => e.RoleNames)
                    .IsRequired()
                    .HasMaxLength(1024);

                entity.HasOne(d => d.Menu)
                    .WithOne(p => p.PersonaBarMenuDefaultPermissions)
                    .HasForeignKey<PersonaBarMenuDefaultPermissions>(d => d.MenuId)
                    .HasConstraintName("FK_PersonaBarMenuDefaultPermissions_MenuId");
            });

            modelBuilder.Entity<PersonaBarMenuPermission>(entity =>
            {
                entity.HasKey(e => e.MenuPermissionId);

                entity.HasIndex(e => new { e.PortalId, e.MenuId, e.PermissionId, e.UserId, e.RoleId })
                    .HasName("IX_PersonaBarMenuPermission")
                    .IsUnique();

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.PersonaBarMenuPermission)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_PersonaBarMenuPermission_MenuId");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PersonaBarMenuPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_PersonaBarMenuPermission_Permission");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PersonaBarMenuPermission)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PersonaBarMenuPermission_Portals");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PersonaBarMenuPermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_PersonaBarMenuPermission_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PersonaBarMenuPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PersonaBarMenuPermission_Users");
            });

            modelBuilder.Entity<PersonaBarPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.HasIndex(e => new { e.MenuId, e.PermissionKey })
                    .HasName("IX_PersonaBarPermissionScope")
                    .IsUnique();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ViewOrder).HasDefaultValueSql("((9999))");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.PersonaBarPermission)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_PersonaBarPermission_MenuId");
            });

            modelBuilder.Entity<PortalAlias>(entity =>
            {
                entity.HasIndex(e => e.Httpalias)
                    .HasName("IX_PortalAlias")
                    .IsUnique();

                entity.Property(e => e.PortalAliasId).HasColumnName("PortalAliasID");

                entity.Property(e => e.BrowserType).HasMaxLength(10);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(10);

                entity.Property(e => e.Httpalias)
                    .HasColumnName("HTTPAlias")
                    .HasMaxLength(200);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.Skin).HasMaxLength(100);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalAlias)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_PortalAlias_Portals");
            });

            modelBuilder.Entity<PortalConfigs>(entity =>
            {
                entity.Property(e => e.BannerFooter).HasMaxLength(500);

                entity.Property(e => e.BannerLeft).HasMaxLength(500);

                entity.Property(e => e.BannerRight).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PortalDesktopModules>(entity =>
            {
                entity.HasKey(e => e.PortalDesktopModuleId);

                entity.HasIndex(e => new { e.PortalId, e.DesktopModuleId })
                    .HasName("IX_PortalDesktopModules")
                    .IsUnique();

                entity.Property(e => e.PortalDesktopModuleId).HasColumnName("PortalDesktopModuleID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DesktopModuleId).HasColumnName("DesktopModuleID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.HasOne(d => d.DesktopModule)
                    .WithMany(p => p.PortalDesktopModules)
                    .HasForeignKey(d => d.DesktopModuleId)
                    .HasConstraintName("FK_PortalDesktopModules_DesktopModules");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalDesktopModules)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_PortalDesktopModules_Portals");
            });

            modelBuilder.Entity<PortalGroups>(entity =>
            {
                entity.HasKey(e => e.PortalGroupId);

                entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");

                entity.Property(e => e.AuthenticationDomain).HasMaxLength(200);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.MasterPortalId).HasColumnName("MasterPortalID");

                entity.Property(e => e.PortalGroupDescription).HasMaxLength(2000);

                entity.Property(e => e.PortalGroupName).HasMaxLength(100);
            });

            modelBuilder.Entity<PortalLanguages>(entity =>
            {
                entity.HasKey(e => e.PortalLanguageId);

                entity.HasIndex(e => new { e.PortalId, e.LanguageId })
                    .HasName("IX_PortalLanguages")
                    .IsUnique();

                entity.Property(e => e.PortalLanguageId).HasColumnName("PortalLanguageID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LanguageId).HasColumnName("LanguageID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.PortalLanguages)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_PortalLanguages_PortalLanguages");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalLanguages)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_PortalLanguages_Portals");
            });

            modelBuilder.Entity<PortalLocalization>(entity =>
            {
                entity.HasKey(e => new { e.PortalId, e.CultureCode });

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.CultureCode).HasMaxLength(10);

                entity.Property(e => e.BackgroundFile).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FooterText).HasMaxLength(100);

                entity.Property(e => e.KeyWords).HasMaxLength(500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LogoFile).HasMaxLength(50);

                entity.Property(e => e.PortalName)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalLocalization)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_PortalLocalization_Portals");
            });

            modelBuilder.Entity<Portals>(entity =>
            {
                entity.HasKey(e => e.PortalId);

                entity.HasIndex(e => e.AdministratorId);

                entity.HasIndex(e => e.DefaultLanguage);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultLanguage)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('en-US')");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HomeDirectory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HostFee).HasColumnType("money");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentProcessor).HasMaxLength(50);

                entity.Property(e => e.PortalGroupId).HasColumnName("PortalGroupID");

                entity.Property(e => e.ProcessorPassword).HasMaxLength(100);

                entity.Property(e => e.ProcessorUserId).HasMaxLength(50);

                entity.Property(e => e.TimezoneOffset).HasDefaultValueSql("((-8))");
            });

            modelBuilder.Entity<PortalSettings>(entity =>
            {
                entity.HasKey(e => e.PortalSettingId)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.PortalId, e.CultureCode, e.SettingName })
                    .HasName("IX_PortalSettings")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.PortalSettingId).HasColumnName("PortalSettingID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(10);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.PortalSettings)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_PortalSettings_Portals");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.PortalId })
                    .HasName("IX_Profile")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProfileData)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_Profile_Portals");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Profile)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Profile_Users");
            });

            modelBuilder.Entity<ProfilePropertyDefinition>(entity =>
            {
                entity.HasKey(e => e.PropertyDefinitionId);

                entity.HasIndex(e => e.PropertyName);

                entity.HasIndex(e => new { e.PortalId, e.ModuleDefId, e.PropertyName })
                    .HasName("IX_ProfilePropertyDefinition")
                    .IsUnique();

                entity.Property(e => e.PropertyDefinitionId).HasColumnName("PropertyDefinitionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue).HasColumnType("ntext");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ModuleDefId).HasColumnName("ModuleDefID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.PropertyCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ValidationExpression).HasMaxLength(2000);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.ProfilePropertyDefinition)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProfilePropertyDefinition_Portals");
            });

            modelBuilder.Entity<QlvpChucVu>(entity =>
            {
                entity.ToTable("QLVP_ChucVu");

                entity.Property(e => e.ChucVu)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageId).HasMaxLength(50);

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<QlvpPhongBan>(entity =>
            {
                entity.ToTable("QLVP_PhongBan");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LanguageId).HasMaxLength(50);

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.ParentId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowonMenu).HasDefaultValueSql("((0))");

                entity.Property(e => e.TabId).HasDefaultValueSql("((-1))");

                entity.Property(e => e.TenPhongBan)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TenVietTat).HasMaxLength(50);
            });

            modelBuilder.Entity<QlvpPhongBanChucVu>(entity =>
            {
                entity.ToTable("QLVP_PhongBan_ChucVu");
            });

            modelBuilder.Entity<QlvpPhongBanDonviNguoiDung>(entity =>
            {
                entity.ToTable("QLVP_PhongBan_Donvi_NguoiDung");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<QlvpPhongBanNguoiDung>(entity =>
            {
                entity.ToTable("QLVP_PhongBan_NguoiDung");

                entity.Property(e => e.LaNguoiNhanVb).HasColumnName("LaNguoiNhanVB");
            });

            modelBuilder.Entity<QlvpUserWf>(entity =>
            {
                entity.ToTable("QLVP_UserWF");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IconLarge).HasMaxLength(250);

                entity.Property(e => e.IconSmall).HasMaxLength(250);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.LanguageId).HasMaxLength(50);

                entity.Property(e => e.LoaiWf).HasColumnName("LoaiWF");

                entity.Property(e => e.MoTa).HasMaxLength(500);

                entity.Property(e => e.NgayTao)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NguoiNhan).HasMaxLength(500);

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.TenLuong)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<RedirectMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.HasIndex(e => e.CreatedOnDate);

                entity.Property(e => e.MessageId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageText).IsRequired();
            });

            modelBuilder.Entity<Relationships>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Relationships_Portals");

                entity.HasOne(d => d.RelationshipType)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.RelationshipTypeId)
                    .HasConstraintName("FK_Relationships_RelationshipTypes");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Relationships)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Relationships_Users");
            });

            modelBuilder.Entity<RelationshipTypes>(entity =>
            {
                entity.HasKey(e => e.RelationshipTypeId);

                entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RoleGroups>(entity =>
            {
                entity.HasKey(e => e.RoleGroupId);

                entity.HasIndex(e => new { e.PortalId, e.RoleGroupName })
                    .HasName("IX_RoleGroupName")
                    .IsUnique();

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RoleGroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.RoleGroups)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_RoleGroups_Portals");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.HasIndex(e => e.BillingFrequency)
                    .HasName("IX_Roles");

                entity.HasIndex(e => new { e.PortalId, e.RoleName })
                    .HasName("IX_RoleName")
                    .IsUnique();

                entity.HasIndex(e => new { e.RoleId, e.PortalId, e.RoleName })
                    .HasName("IX_Roles_RoleName")
                    .IsUnique();

                entity.HasIndex(e => new { e.RoleId, e.RoleGroupId, e.RoleName })
                    .HasName("IX_Roles_RoleGroup");

                entity.HasIndex(e => new { e.SecurityMode, e.PortalId, e.RoleName, e.Description, e.ServiceFee, e.BillingFrequency, e.TrialPeriod, e.TrialFrequency, e.BillingPeriod, e.TrialFee, e.IsPublic, e.AutoAssignment, e.RoleGroupId, e.Rsvpcode, e.IconFile, e.RoleId, e.Status })
                    .HasName("IX_Roles_RoleID_Status")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.BillingFrequency)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rsvpcode)
                    .HasColumnName("RSVPCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceFee)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.TrialFee).HasColumnType("money");

                entity.Property(e => e.TrialFrequency)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Roles_Portals");

                entity.HasOne(d => d.RoleGroup)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.RoleGroupId)
                    .HasConstraintName("FK_Roles_RoleGroups");
            });

            modelBuilder.Entity<RoleSettings>(entity =>
            {
                entity.HasKey(e => e.RoleSettingId);

                entity.Property(e => e.RoleSettingId).HasColumnName("RoleSettingID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.AttachToEvent)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.FriendlyName).HasMaxLength(200);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.ObjectDependencies)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RetryTimeLapseMeasurement)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleStartDate).HasColumnType("datetime");

                entity.Property(e => e.Servers).HasMaxLength(2000);

                entity.Property(e => e.TimeLapseMeasurement)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TypeFullName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScheduleHistory>(entity =>
            {
                entity.HasIndex(e => new { e.ScheduleId, e.NextStart })
                    .HasName("IX_ScheduleHistory_NextStart");

                entity.HasIndex(e => new { e.ScheduleId, e.StartDate })
                    .HasName("IX_ScheduleHistory_StartDate");

                entity.Property(e => e.ScheduleHistoryId).HasColumnName("ScheduleHistoryID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LogNotes).HasColumnType("ntext");

                entity.Property(e => e.NextStart).HasColumnType("datetime");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Server).HasMaxLength(150);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleHistory)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleHistory_Schedule");
            });

            modelBuilder.Entity<ScheduleItemSettings>(entity =>
            {
                entity.HasKey(e => new { e.ScheduleId, e.SettingName });

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.ScheduleItemSettings)
                    .HasForeignKey(d => d.ScheduleId)
                    .HasConstraintName("FK_ScheduleItemSettings_Schedule");
            });

            modelBuilder.Entity<SearchCommonWords>(entity =>
            {
                entity.HasKey(e => e.CommonWordId);

                entity.Property(e => e.CommonWordId).HasColumnName("CommonWordID");

                entity.Property(e => e.CommonWord)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Locale).HasMaxLength(10);
            });

            modelBuilder.Entity<SearchDeletedItems>(entity =>
            {
                entity.HasIndex(e => e.DateCreated);

                entity.Property(e => e.SearchDeletedItemsId).HasColumnName("SearchDeletedItemsID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");
            });

            modelBuilder.Entity<SearchIndexer>(entity =>
            {
                entity.Property(e => e.SearchIndexerId).HasColumnName("SearchIndexerID");

                entity.Property(e => e.SearchIndexerAssemblyQualifiedName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SearchStopWords>(entity =>
            {
                entity.HasKey(e => e.StopWordsId);

                entity.Property(e => e.StopWordsId).HasColumnName("StopWordsID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.StopWords).IsRequired();
            });

            modelBuilder.Entity<SearchTypes>(entity =>
            {
                entity.HasKey(e => e.SearchTypeId);

                entity.Property(e => e.IsPrivate).HasDefaultValueSql("((0))");

                entity.Property(e => e.SearchResultClass)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SearchTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SiteLog>(entity =>
            {
                entity.HasIndex(e => e.PortalId)
                    .HasName("IX_SiteLog");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Referrer).HasMaxLength(255);

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.Property(e => e.UserAgent).HasMaxLength(255);

                entity.Property(e => e.UserHostAddress).HasMaxLength(255);

                entity.Property(e => e.UserHostName).HasMaxLength(255);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.SiteLog)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_SiteLog_Portals");
            });

            modelBuilder.Entity<SkinControls>(entity =>
            {
                entity.HasKey(e => e.SkinControlId);

                entity.Property(e => e.SkinControlId).HasColumnName("SkinControlID");

                entity.Property(e => e.ControlKey).HasMaxLength(50);

                entity.Property(e => e.ControlSrc).HasMaxLength(256);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.HelpUrl).HasMaxLength(200);

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId)
                    .HasColumnName("PackageID")
                    .HasDefaultValueSql("((-1))");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.SkinControls)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_SkinControls_Packages");
            });

            modelBuilder.Entity<SkinPackages>(entity =>
            {
                entity.HasKey(e => e.SkinPackageId);

                entity.Property(e => e.SkinPackageId).HasColumnName("SkinPackageID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PackageId).HasColumnName("PackageID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SkinName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SkinType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.SkinPackages)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("FK_SkinPackages_Packages");
            });

            modelBuilder.Entity<Skins>(entity =>
            {
                entity.HasKey(e => e.SkinId);

                entity.Property(e => e.SkinId).HasColumnName("SkinID");

                entity.Property(e => e.SkinPackageId).HasColumnName("SkinPackageID");

                entity.Property(e => e.SkinSrc)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.SkinPackage)
                    .WithMany(p => p.Skins)
                    .HasForeignKey(d => d.SkinPackageId)
                    .HasConstraintName("FK_Skins_SkinPackages");
            });

            modelBuilder.Entity<Sqlqueries>(entity =>
            {
                entity.HasKey(e => e.QueryId);

                entity.ToTable("SQLQueries");

                entity.Property(e => e.ConnectionStringName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Query).IsRequired();
            });

            modelBuilder.Entity<SynonymsGroups>(entity =>
            {
                entity.HasKey(e => e.SynonymsGroupId);

                entity.Property(e => e.SynonymsGroupId).HasColumnName("SynonymsGroupID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SynonymsTags).IsRequired();
            });

            modelBuilder.Entity<SystemMessages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.HasIndex(e => new { e.MessageName, e.PortalId })
                    .HasName("IX_SystemMessages")
                    .IsUnique();

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MessageValue)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.SystemMessages)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SystemMessages_Portals");
            });

            modelBuilder.Entity<TabAliasSkins>(entity =>
            {
                entity.HasKey(e => e.TabAliasSkinId);

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SkinSrc)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TabModules>(entity =>
            {
                entity.HasKey(e => e.TabModuleId);

                entity.HasIndex(e => e.UniqueId)
                    .HasName("IX_TabModules_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => new { e.IsDeleted, e.ModuleTitle, e.CultureCode, e.TabId, e.ModuleId })
                    .HasName("IX_TabModules_TabID")
                    .IsUnique();

                entity.HasIndex(e => new { e.TabModuleId, e.PaneName, e.ModuleOrder, e.CacheTime, e.Alignment, e.Color, e.Border, e.IconFile, e.Visibility, e.ContainerSrc, e.DisplayTitle, e.DisplayPrint, e.DisplaySyndicate, e.IsWebSlice, e.WebSliceTitle, e.WebSliceExpiryDate, e.WebSliceTtl, e.IsDeleted, e.CacheMethod, e.ModuleTitle, e.Header, e.Footer, e.CultureCode, e.UniqueId, e.VersionGuid, e.DefaultLanguageGuid, e.LocalizedVersionGuid, e.ModuleId, e.TabId })
                    .HasName("IX_TabModules_ModuleID");

                entity.HasIndex(e => new { e.ModuleId, e.TabModuleId, e.CacheTime, e.Alignment, e.Color, e.Border, e.IconFile, e.Visibility, e.ContainerSrc, e.DisplayTitle, e.DisplayPrint, e.DisplaySyndicate, e.IsWebSlice, e.WebSliceTitle, e.WebSliceExpiryDate, e.WebSliceTtl, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.IsDeleted, e.CacheMethod, e.ModuleTitle, e.Header, e.Footer, e.CultureCode, e.UniqueId, e.VersionGuid, e.DefaultLanguageGuid, e.LocalizedVersionGuid, e.TabId, e.PaneName, e.ModuleOrder })
                    .HasName("IX_TabModules_ModuleOrder");

                entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");

                entity.Property(e => e.Alignment).HasMaxLength(10);

                entity.Property(e => e.Border).HasMaxLength(1);

                entity.Property(e => e.CacheMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.ContainerSrc).HasMaxLength(200);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CultureCode).HasMaxLength(10);

                entity.Property(e => e.DisplayPrint)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplaySyndicate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayTitle)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Footer).HasColumnType("nvarchar(max)");

                entity.Property(e => e.Header).HasColumnType("nvarchar(max)");

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.ModuleTitle).HasMaxLength(256);

                entity.Property(e => e.PaneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.WebSliceExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.WebSliceTitle).HasMaxLength(256);

                entity.Property(e => e.WebSliceTtl).HasColumnName("WebSliceTTL");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.TabModules)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_TabModules_Modules");

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.TabModules)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_TabModules_Tabs");
            });

            modelBuilder.Entity<TabModuleSettings>(entity =>
            {
                entity.HasKey(e => new { e.TabModuleId, e.SettingName });

                entity.Property(e => e.TabModuleId).HasColumnName("TabModuleID");

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.TabModule)
                    .WithMany(p => p.TabModuleSettings)
                    .HasForeignKey(d => d.TabModuleId)
                    .HasConstraintName("FK_TabModuleSettings_TabModules");
            });

            modelBuilder.Entity<TabPermission>(entity =>
            {
                entity.HasIndex(e => e.PermissionId)
                    .HasName("IX_TabPermission_Permission");

                entity.HasIndex(e => new { e.AllowAccess, e.RoleId, e.TabId, e.PermissionId })
                    .HasName("IX_TabPermission_Roles")
                    .IsUnique()
                    .HasFilter("([RoleID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.UserId, e.TabId, e.PermissionId })
                    .HasName("IX_TabPermission_Users")
                    .IsUnique()
                    .HasFilter("([UserID] IS NOT NULL)");

                entity.HasIndex(e => new { e.AllowAccess, e.TabId, e.PermissionId, e.RoleId, e.UserId })
                    .HasName("IX_TabPermission_Tabs")
                    .IsUnique();

                entity.Property(e => e.TabPermissionId).HasColumnName("TabPermissionID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.TabPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .HasConstraintName("FK_TabPermission_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TabPermission)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_TabPermission_Roles");

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.TabPermission)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_TabPermission_Tabs");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TabPermission)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TabPermission_Users");
            });

            modelBuilder.Entity<Tabs>(entity =>
            {
                entity.HasKey(e => e.TabId);

                entity.HasIndex(e => e.UniqueId)
                    .HasName("IX_Tabs_UniqueId")
                    .IsUnique();

                entity.HasIndex(e => new { e.CreatedOnDate, e.ParentId, e.IsDeleted })
                    .HasName("IX_Tabs_ParentId_IsDeleted");

                entity.HasIndex(e => new { e.UniqueId, e.TabId, e.TabName, e.IsVisible, e.Title, e.IsDeleted, e.CultureCode, e.ContentItemId })
                    .HasName("IX_Tabs_ContentID")
                    .HasFilter("([ContentItemId] IS NOT NULL)");

                entity.HasIndex(e => new { e.TabName, e.IsVisible, e.IconFile, e.DisableLink, e.Title, e.Description, e.KeyWords, e.TabPath, e.TabId, e.Url, e.SkinSrc, e.ContainerSrc, e.StartDate, e.EndDate, e.RefreshInterval, e.PageHeadText, e.IsSecure, e.PermanentRedirect, e.SiteMapPriority, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.IconFileLarge, e.CultureCode, e.ContentItemId, e.UniqueId, e.VersionGuid, e.DefaultLanguageGuid, e.LocalizedVersionGuid, e.PortalId, e.Level, e.ParentId, e.TabOrder, e.IsDeleted })
                    .HasName("IX_Tabs_PortalLevelParentOrder");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.ContainerSrc).HasMaxLength(200);

                entity.Property(e => e.ContentItemId).HasColumnName("ContentItemID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IconFile).HasMaxLength(255);

                entity.Property(e => e.IconFileLarge).HasMaxLength(255);

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.KeyWords).HasMaxLength(500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LocalizedVersionGuid).HasDefaultValueSql("(newid())");

                entity.Property(e => e.PageHeadText).HasColumnType("nvarchar(max)");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.SiteMapPriority).HasDefaultValueSql("((0.5))");

                entity.Property(e => e.SkinSrc).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TabName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TabPath)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Url).HasMaxLength(255);

                entity.Property(e => e.VersionGuid).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.ContentItem)
                    .WithMany(p => p.Tabs)
                    .HasForeignKey(d => d.ContentItemId)
                    .HasConstraintName("FK_Tabs_ContentItems");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Tabs_Tabs");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Tabs)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Tabs_Portals");
            });

            modelBuilder.Entity<TabSettings>(entity =>
            {
                entity.HasKey(e => new { e.TabId, e.SettingName })
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.TabId, e.SettingName })
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.TabSettings)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_TabSettings_Tabs");
            });

            modelBuilder.Entity<TabUrls>(entity =>
            {
                entity.HasKey(e => new { e.TabId, e.SeqNum });

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.CultureCode).HasMaxLength(50);

                entity.Property(e => e.HttpStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.QueryString).HasMaxLength(200);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.TabUrls)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_TabUrls_Tabs");
            });

            modelBuilder.Entity<TabVersionDetails>(entity =>
            {
                entity.HasKey(e => e.TabVersionDetailId);

                entity.HasIndex(e => e.TabVersionId);

                entity.HasIndex(e => new { e.TabVersionId, e.ModuleId })
                    .HasName("IX_TabVersionDetails_Unique(TabVersionId_ModuleId)")
                    .IsUnique();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.PaneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TabVersion)
                    .WithMany(p => p.TabVersionDetails)
                    .HasForeignKey(d => d.TabVersionId)
                    .HasConstraintName("FK_TabVersionDetails_TabVersionId");
            });

            modelBuilder.Entity<TabVersions>(entity =>
            {
                entity.HasKey(e => e.TabVersionId);

                entity.HasIndex(e => e.TabId);

                entity.HasIndex(e => new { e.TabId, e.Version })
                    .HasName("IX_TabVersions")
                    .IsUnique();

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.TabVersions)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK_TabVersions_TabId");
            });

            modelBuilder.Entity<TaxonomyScopeTypes>(entity =>
            {
                entity.HasKey(e => e.ScopeTypeId);

                entity.ToTable("Taxonomy_ScopeTypes");

                entity.Property(e => e.ScopeTypeId).HasColumnName("ScopeTypeID");

                entity.Property(e => e.ScopeType).HasMaxLength(250);
            });

            modelBuilder.Entity<TaxonomyTerms>(entity =>
            {
                entity.HasKey(e => e.TermId);

                entity.ToTable("Taxonomy_Terms");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ParentTermId).HasColumnName("ParentTermID");

                entity.Property(e => e.VocabularyId).HasColumnName("VocabularyID");

                entity.HasOne(d => d.ParentTerm)
                    .WithMany(p => p.InverseParentTerm)
                    .HasForeignKey(d => d.ParentTermId)
                    .HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Terms");

                entity.HasOne(d => d.Vocabulary)
                    .WithMany(p => p.TaxonomyTerms)
                    .HasForeignKey(d => d.VocabularyId)
                    .HasConstraintName("FK_Taxonomy_Terms_Taxonomy_Vocabularies");
            });

            modelBuilder.Entity<TaxonomyVocabularies>(entity =>
            {
                entity.HasKey(e => e.VocabularyId);

                entity.ToTable("Taxonomy_Vocabularies");

                entity.Property(e => e.VocabularyId).HasColumnName("VocabularyID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2500);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ScopeTypeId).HasColumnName("ScopeTypeID");

                entity.Property(e => e.VocabularyTypeId).HasColumnName("VocabularyTypeID");

                entity.HasOne(d => d.ScopeType)
                    .WithMany(p => p.TaxonomyVocabularies)
                    .HasForeignKey(d => d.ScopeTypeId)
                    .HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_ScopeTypes");

                entity.HasOne(d => d.VocabularyType)
                    .WithMany(p => p.TaxonomyVocabularies)
                    .HasForeignKey(d => d.VocabularyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Taxonomy_Vocabularies_Taxonomy_VocabularyTypes");
            });

            modelBuilder.Entity<TaxonomyVocabularyTypes>(entity =>
            {
                entity.HasKey(e => e.VocabularyTypeId);

                entity.ToTable("Taxonomy_VocabularyTypes");

                entity.Property(e => e.VocabularyTypeId).HasColumnName("VocabularyTypeID");

                entity.Property(e => e.VocabularyType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UrlLog>(entity =>
            {
                entity.Property(e => e.UrlLogId).HasColumnName("UrlLogID");

                entity.Property(e => e.ClickDate).HasColumnType("datetime");

                entity.Property(e => e.UrlTrackingId).HasColumnName("UrlTrackingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.UrlTracking)
                    .WithMany(p => p.UrlLog)
                    .HasForeignKey(d => d.UrlTrackingId)
                    .HasConstraintName("FK_UrlLog_UrlTracking");
            });

            modelBuilder.Entity<Urls>(entity =>
            {
                entity.HasKey(e => e.UrlId);

                entity.HasIndex(e => new { e.Url, e.PortalId })
                    .HasName("IX_Urls")
                    .IsUnique();

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.Urls)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Urls_Portals");
            });

            modelBuilder.Entity<UrlTracking>(entity =>
            {
                entity.HasIndex(e => e.ModuleId);

                entity.HasIndex(e => new { e.PortalId, e.Url, e.ModuleId })
                    .HasName("IX_UrlTracking")
                    .IsUnique();

                entity.HasIndex(e => new { e.NewWindow, e.TrackClicks, e.Url, e.ModuleId })
                    .HasName("IX_UrlTracking_Url_ModuleId");

                entity.Property(e => e.UrlTrackingId).HasColumnName("UrlTrackingID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastClick).HasColumnType("datetime");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.TrackClicks)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UrlType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.UrlTracking)
                    .HasForeignKey(d => d.PortalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UrlTracking_Portals");
            });

            modelBuilder.Entity<UserAuthentication>(entity =>
            {
                entity.HasIndex(e => new { e.UserId, e.AuthenticationType })
                    .HasName("IX_UserAuthentication")
                    .IsUnique();

                entity.Property(e => e.UserAuthenticationId).HasColumnName("UserAuthenticationID");

                entity.Property(e => e.AuthenticationToken)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.AuthenticationType)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAuthentication)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserAuthentication_Users");
            });

            modelBuilder.Entity<UserPortals>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PortalId });

                entity.HasIndex(e => e.PortalId)
                    .HasName("IX_UserPortals");

                entity.HasIndex(e => new { e.UserId, e.PortalId, e.VanityUrl })
                    .HasName("IX_UserPortals_VanityUrl");

                entity.HasIndex(e => new { e.PortalId, e.IsDeleted, e.Authorised, e.UserId })
                    .HasName("IX_UserPortals_PortalId_IsDeleted")
                    .IsUnique();

                entity.Property(e => e.Authorised)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserPortalId).ValueGeneratedOnAdd();

                entity.Property(e => e.VanityUrl).HasMaxLength(100);

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.UserPortals)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_UserPortals_Portals");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPortals)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserPortals_Users");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserProfile");

                entity.HasIndex(e => new { e.UserId, e.LastUpdatedDate })
                    .HasName("IX_UserProfile_LastUpdatedDate");

                entity.HasIndex(e => new { e.UserId, e.PropertyDefinitionId });

                entity.HasIndex(e => new { e.ProfileId, e.UserId, e.PropertyValue, e.PropertyDefinitionId })
                    .HasName("IX_UserProfile_PropertyDefinitionID");

                entity.HasIndex(e => new { e.PropertyDefinitionId, e.PropertyValue, e.PropertyText, e.Visibility, e.LastUpdatedDate, e.ExtendedVisibility, e.UserId, e.ProfileId })
                    .HasName("IX_UserProfile_Visibility");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ExtendedVisibility)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyDefinitionId).HasColumnName("PropertyDefinitionID");

                entity.Property(e => e.PropertyText).HasColumnType("nvarchar(max)");

                entity.Property(e => e.PropertyValue).HasMaxLength(3750);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.PropertyDefinition)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.PropertyDefinitionId)
                    .HasConstraintName("FK_UserProfile_ProfilePropertyDefinition");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserProfile_Users");
            });

            modelBuilder.Entity<UserRelationshipPreferences>(entity =>
            {
                entity.HasKey(e => new { e.PreferenceId, e.RelationshipId });

                entity.Property(e => e.PreferenceId)
                    .HasColumnName("PreferenceID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.UserRelationshipPreferences)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_UserRelationshipPreferences_Relationships");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRelationshipPreferences)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRelationshipPreferences_Users");
            });

            modelBuilder.Entity<UserRelationships>(entity =>
            {
                entity.HasKey(e => e.UserRelationshipId);

                entity.HasIndex(e => e.RelatedUserId);

                entity.HasIndex(e => e.UserId);

                entity.HasIndex(e => new { e.UserId, e.RelatedUserId, e.RelationshipId })
                    .IsUnique();

                entity.Property(e => e.UserRelationshipId).HasColumnName("UserRelationshipID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RelatedUserId).HasColumnName("RelatedUserID");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.RelatedUser)
                    .WithMany(p => p.UserRelationshipsRelatedUser)
                    .HasForeignKey(d => d.RelatedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRelationships_Users_OnRelatedUser");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.UserRelationships)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_UserRelationships_Relationships");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRelationshipsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRelationships_Users");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.HasIndex(e => new { e.RoleId, e.UserId })
                    .HasName("IX_UserRoles_RoleUser")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserId, e.RoleId })
                    .HasName("IX_UserRoles_UserRole")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserRoleId, e.ExpiryDate, e.IsTrialUsed, e.EffectiveDate, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.Status, e.IsOwner, e.RoleId, e.UserId })
                    .HasName("IX_UserRoles_RoleID_UserID")
                    .IsUnique();

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRoles_Users");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => e.Username)
                    .HasName("IX_Users")
                    .IsUnique();

                entity.HasIndex(e => new { e.UserId, e.IsSuperUser, e.LastModifiedOnDate })
                    .HasName("IX_Users_LastModifiedOnDate");

                entity.HasIndex(e => new { e.UserId, e.DisplayName, e.IsSuperUser, e.IsDeleted })
                    .HasName("IX_Users_DisplayName");

                entity.HasIndex(e => new { e.UserId, e.FirstName, e.IsSuperUser, e.IsDeleted })
                    .HasName("IX_Users_FirstName")
                    .HasFilter("([FirstName] IS NOT NULL AND [FirstName]<>N'')");

                entity.HasIndex(e => new { e.UserId, e.LastName, e.IsSuperUser, e.IsDeleted })
                    .HasName("IX_Users_LastName")
                    .HasFilter("([LastName] IS NOT NULL AND [LastName]<>N'')");

                entity.HasIndex(e => new { e.UserId, e.IsSuperUser, e.Email, e.IsDeleted, e.DisplayName })
                    .HasName("IX_Users_IsDeleted_DisplayName");

                entity.HasIndex(e => new { e.UserId, e.FirstName, e.LastName, e.Email, e.DisplayName, e.IsDeleted, e.LastModifiedOnDate, e.IsSuperUser, e.Username })
                    .HasName("IX_Users_IsSuperuser")
                    .IsUnique()
                    .HasFilter("([IsSuperUser]=(1))");

                entity.HasIndex(e => new { e.FirstName, e.LastName, e.IsSuperUser, e.AffiliateId, e.Email, e.DisplayName, e.UpdatePassword, e.LastIpaddress, e.IsDeleted, e.CreatedByUserId, e.CreatedOnDate, e.LastModifiedByUserId, e.LastModifiedOnDate, e.PasswordResetToken, e.PasswordResetExpiration, e.Username, e.UserId })
                    .HasName("IX_Users_UserName_UserID")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedOnDate).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastIpaddress)
                    .HasColumnName("LastIPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.LastModifiedOnDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PasswordResetExpiration).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UsersOnline>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PortalId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastActiveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.HasOne(d => d.Portal)
                    .WithMany(p => p.UsersOnline)
                    .HasForeignKey(d => d.PortalId)
                    .HasConstraintName("FK_UsersOnline_Portals");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersOnline)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersOnline_Users");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasIndex(e => new { e.Major, e.Minor, e.Build, e.Increment })
                    .HasName("IX_Version")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Videos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApproveDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Avatar)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Butdanh)
                    .HasColumnName("butdanh")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EditedTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsEdited).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsHot).HasColumnName("IsHOT");

                entity.Property(e => e.IsHotcat).HasColumnName("IsHOTCat");

                entity.Property(e => e.IsTruyenHinh)
                    .HasColumnName("isTruyenHinh")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LinkVideos)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Linknguon).HasMaxLength(500);

                entity.Property(e => e.PublicDate).HasColumnType("datetime");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(500);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(e => e.Tomtat).HasMaxLength(200);
            });

            modelBuilder.Entity<VideosByMedia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Createdted)
                    .HasColumnName("createdted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mediaid).HasColumnName("mediaid");

                entity.Property(e => e.Portalid).HasColumnName("portalid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Videoid).HasColumnName("videoid");
            });

            modelBuilder.Entity<VideosProcess>(entity =>
            {
                entity.ToTable("Videos_Process");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Iptrack)
                    .HasColumnName("IPTrack")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessName).HasMaxLength(500);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");
            });

            modelBuilder.Entity<VideosUserProcess>(entity =>
            {
                entity.ToTable("Videos_UserProcess");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VideoId).HasColumnName("VideoID");
            });

            modelBuilder.Entity<VsThongkeBaoCao>(entity =>
            {
                entity.ToTable("VS_ThongkeBaoCao");

                entity.Property(e => e.Avatar).HasMaxLength(500);

                entity.Property(e => e.Contents).HasColumnType("ntext");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.LanguageId).HasMaxLength(10);

                entity.Property(e => e.PublishedDate).HasColumnType("datetime");

                entity.Property(e => e.ShortTitle).HasMaxLength(100);

                entity.Property(e => e.Source).HasMaxLength(255);

                entity.Property(e => e.Tags).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnType("date");
            });

            modelBuilder.Entity<VsThongKeBaoCaoFiles>(entity =>
            {
                entity.ToTable("VS_ThongKeBaoCao_Files");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FileExtension).HasMaxLength(10);

                entity.Property(e => e.FileName).HasMaxLength(1000);

                entity.Property(e => e.FileUrl).HasMaxLength(1000);
            });

            modelBuilder.Entity<WebLinks>(entity =>
            {
                entity.Property(e => e.Accounts).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Image).HasMaxLength(255);

                entity.Property(e => e.LanguageId).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Url).HasMaxLength(150);

                entity.Property(e => e.ViewType).HasMaxLength(100);
            });

            modelBuilder.Entity<WebServers>(entity =>
            {
                entity.HasKey(e => e.ServerId);

                entity.HasIndex(e => new { e.ServerName, e.IisappName })
                    .HasName("IX_WebServers_ServerName")
                    .IsUnique();

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IisappName)
                    .IsRequired()
                    .HasColumnName("IISAppName")
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.ServerGroup).HasMaxLength(200);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UniqueId).HasMaxLength(200);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasIndex(e => new { e.PortalId, e.WorkflowName })
                    .HasName("IX_Workflow")
                    .IsUnique();

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.PortalId).HasColumnName("PortalID");

                entity.Property(e => e.WorkflowName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowStates>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.HasIndex(e => new { e.WorkflowId, e.StateName })
                    .HasName("IX_WorkflowStates")
                    .IsUnique();

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.WorkflowStates)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_WorkflowStates_Workflow");
            });
        }
    }
}
