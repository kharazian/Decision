namespace Decision.DataLayer.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Decision.DomainClasses.Entities.Employee;

    public partial class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
            : base("name=EmployeeDbContext")
        {
        }

        public virtual DbSet<AccessPost> AccessPost { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Bank> Bank { get; set; }
        public virtual DbSet<BankShahrDisk> BankShahrDisk { get; set; }
        public virtual DbSet<BasePay> BasePay { get; set; }
        public virtual DbSet<BonKargary> BonKargary { get; set; }
        public virtual DbSet<BranchBank> BranchBank { get; set; }
        public virtual DbSet<CodeFile> CodeFile { get; set; }
        public virtual DbSet<CodeFileMaster> CodeFileMaster { get; set; }
        public virtual DbSet<ContiDeduct> ContiDeduct { get; set; }
        public virtual DbSet<ContiPay> ContiPay { get; set; }
        public virtual DbSet<ControlInfo> ControlInfo { get; set; }
        public virtual DbSet<Deduct> Deduct { get; set; }
        public virtual DbSet<DegreeTashvigh> DegreeTashvigh { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<Eblagh> Eblagh { get; set; }
        public virtual DbSet<EmpDegree> EmpDegree { get; set; }
        public virtual DbSet<EmpForeignLang> EmpForeignLang { get; set; }
        public virtual DbSet<EmpImage> EmpImage { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmpRelative> EmpRelative { get; set; }
        public virtual DbSet<EmpWriting> EmpWriting { get; set; }
        public virtual DbSet<Evaluation> Evaluation { get; set; }
        public virtual DbSet<ExePostNumber> ExePostNumber { get; set; }
        public virtual DbSet<Experience> Experience { get; set; }
        public virtual DbSet<FinClass> FinClass { get; set; }
        public virtual DbSet<FinGrp> FinGrp { get; set; }
        public virtual DbSet<FinGrpAccess> FinGrpAccess { get; set; }
        public virtual DbSet<FinGrpMem> FinGrpMem { get; set; }
        public virtual DbSet<Finobject> Finobject { get; set; }
        public virtual DbSet<Finuser> Finuser { get; set; }
        public virtual DbSet<FinUsrAccess> FinUsrAccess { get; set; }
        public virtual DbSet<Gharardad> Gharardad { get; set; }
        public virtual DbSet<GharardadSaaty> GharardadSaaty { get; set; }
        public virtual DbSet<HokmDirector> HokmDirector { get; set; }
        public virtual DbSet<HokmKargary> HokmKargary { get; set; }
        public virtual DbSet<HokmLaw> HokmLaw { get; set; }
        public virtual DbSet<HokmNoHokmRel> HokmNoHokmRel { get; set; }
        public virtual DbSet<HokmPayItemsLaw> HokmPayItemsLaw { get; set; }
        public virtual DbSet<HokmPaysGharardad> HokmPaysGharardad { get; set; }
        public virtual DbSet<HokmPaysKargary> HokmPaysKargary { get; set; }
        public virtual DbSet<HokmPaysRasmy> HokmPaysRasmy { get; set; }
        public virtual DbSet<HokmRasmy> HokmRasmy { get; set; }
        public virtual DbSet<HourMamoriat> HourMamoriat { get; set; }
        public virtual DbSet<HourMorakhasi> HourMorakhasi { get; set; }
        public virtual DbSet<InfoMonKind> InfoMonKind { get; set; }
        public virtual DbSet<InsLaw> InsLaw { get; set; }
        public virtual DbSet<ItemsDsc> ItemsDsc { get; set; }
        public virtual DbSet<ItemsLaw> ItemsLaw { get; set; }
        public virtual DbSet<ItemTit> ItemTit { get; set; }
        public virtual DbSet<JobDsc> JobDsc { get; set; }
        public virtual DbSet<JobMajor> JobMajor { get; set; }
        public virtual DbSet<KaraSaving> KaraSaving { get; set; }
        public virtual DbSet<Karkerd> Karkerd { get; set; }
        public virtual DbSet<Karkerd_Sherkaty> Karkerd_Sherkaty { get; set; }
        public virtual DbSet<LevelChart> LevelChart { get; set; }
        public virtual DbSet<LimitNight> LimitNight { get; set; }
        public virtual DbSet<LimitSum> LimitSum { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }
        public virtual DbSet<LoaSavRel> LoaSavRel { get; set; }
        public virtual DbSet<Major> Major { get; set; }
        public virtual DbSet<Mamoriat> Mamoriat { get; set; }
        public virtual DbSet<Mamorin> Mamorin { get; set; }
        public virtual DbSet<MamorPlace> MamorPlace { get; set; }
        public virtual DbSet<Management> Management { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<MilitaryService> MilitaryService { get; set; }
        public virtual DbSet<MontlyDeductBoss> MontlyDeductBoss { get; set; }
        public virtual DbSet<MontlyResult> MontlyResult { get; set; }
        public virtual DbSet<Morakhasi> Morakhasi { get; set; }
        public virtual DbSet<MorControl> MorControl { get; set; }
        public virtual DbSet<MREM> MREM { get; set; }
        public virtual DbSet<NewInfo> NewInfo { get; set; }
        public virtual DbSet<NumberHokm> NumberHokm { get; set; }
        public virtual DbSet<OperationCurrentDate> OperationCurrentDate { get; set; }
        public virtual DbSet<OrganPost> OrganPost { get; set; }
        public virtual DbSet<OrganUnit> OrganUnit { get; set; }
        public virtual DbSet<OtherBime> OtherBime { get; set; }
        public virtual DbSet<OtherBimePrice> OtherBimePrice { get; set; }
        public virtual DbSet<Padash> Padash { get; set; }
        public virtual DbSet<Pay> Pay { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<PlaceEmp> PlaceEmp { get; set; }
        public virtual DbSet<PostEnshaee> PostEnshaee { get; set; }
        public virtual DbSet<PostHokm> PostHokm { get; set; }
        public virtual DbSet<PostNumbers> PostNumbers { get; set; }
        public virtual DbSet<PRFBackItems> PRFBackItems { get; set; }
        public virtual DbSet<PRFBackMaster> PRFBackMaster { get; set; }
        public virtual DbSet<PRFItems> PRFItems { get; set; }
        public virtual DbSet<PRFMaster> PRFMaster { get; set; }
        public virtual DbSet<Refahi> Refahi { get; set; }
        public virtual DbSet<RefahiLaw> RefahiLaw { get; set; }
        public virtual DbSet<RefahiType> RefahiType { get; set; }
        public virtual DbSet<RfCodeFile> RfCodeFile { get; set; }
        public virtual DbSet<RfCodeFile0> RfCodeFile0 { get; set; }
        public virtual DbSet<Sal> Sal { get; set; }
        public virtual DbSet<Saving> Saving { get; set; }
        public virtual DbSet<ShahdarPay> ShahdarPay { get; set; }
        public virtual DbSet<SibaDisk> SibaDisk { get; set; }
        public virtual DbSet<SpecialItem> SpecialItem { get; set; }
        public virtual DbSet<SumPayDeduct> SumPayDeduct { get; set; }
        public virtual DbSet<SumPayList> SumPayList { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<t_Log> t_Log { get; set; }
        public virtual DbSet<t_LogStatus> t_LogStatus { get; set; }
        public virtual DbSet<Tashvigh> Tashvigh { get; set; }
        public virtual DbSet<TaxLaw> TaxLaw { get; set; }
        public virtual DbSet<TitleSumPayDeduct> TitleSumPayDeduct { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<University> University { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        public virtual DbSet<ChartRelPost> ChartRelPost { get; set; }
        public virtual DbSet<CodeFileMasterTax> CodeFileMasterTax { get; set; }
        public virtual DbSet<CodeFileTax> CodeFileTax { get; set; }
        public virtual DbSet<Eidy> Eidy { get; set; }
        public virtual DbSet<LimitKara> LimitKara { get; set; }
        public virtual DbSet<OrganUnitParent> OrganUnitParent { get; set; }
        public virtual DbSet<SarJam_Maliati> SarJam_Maliati { get; set; }
        public virtual DbSet<TaxDisk> TaxDisk { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasKey(e => e.Empno);
            modelBuilder.Entity<Employee>().HasOptional(e => e.EmpImage).WithRequired().WillCascadeOnDelete(true);
            modelBuilder.Entity<Employee>().HasRequired(e => e.BirthCity).WithMany().HasForeignKey(e => e.BirthCityCod).WillCascadeOnDelete(false);
            modelBuilder.Entity<Employee>().HasRequired(e => e.IssueCity).WithMany().HasForeignKey(e => e.IssueCityCod).WillCascadeOnDelete(false);
            modelBuilder.Entity<Employee>().HasRequired(e => e.Religion).WithMany().HasForeignKey(e => e.ReligionCod).WillCascadeOnDelete(false);
            
            modelBuilder.Entity<Bank>()
                .HasMany(e => e.BranchBank)
                .WithRequired(e => e.Bank)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bank>()
                .HasMany(e => e.MontlyResult)
                .WithOptional(e => e.Bank)
                .HasForeignKey(e => e.BankCod);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.SibaYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.SibaMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.OrganCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BankShahrDisk>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.Grooh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.BaseRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BasePay>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.Season)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BonKargary>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.BankNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.BrnchNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.BranchNam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.Addr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.TelNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.FaxNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BranchBank>()
                .HasMany(e => e.MontlyResult)
                .WithOptional(e => e.BranchBank)
                .HasForeignKey(e => new { e.BankCod, e.BranchCod });

            modelBuilder.Entity<CodeFile>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFile>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFile>()
                .Property(e => e.Tag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFile>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.BasePay)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.DegreeTashvigh)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.MadrakCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpForeignLang)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.LangCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpForeignLang1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.LevelCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative)
                .WithOptional(e => e.CodeFile)
                .HasForeignKey(e => e.DegreeCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative1)
                .WithOptional(e => e.CodeFile1)
                .HasForeignKey(e => e.HealthCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative2)
                .WithOptional(e => e.CodeFile2)
                .HasForeignKey(e => e.MarriCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative3)
                .WithRequired(e => e.CodeFile3)
                .HasForeignKey(e => e.ReltypeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative4)
                .WithOptional(e => e.CodeFile4)
                .HasForeignKey(e => e.Sections);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative5)
                .WithRequired(e => e.CodeFile5)
                .HasForeignKey(e => e.SexCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.EmpRelative6)
                .WithOptional(e => e.CodeFile6)
                .HasForeignKey(e => e.WarRelCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.Gharardad)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.DegreeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.Gharardad1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.MarriCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmDirector)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmDirector1)
                .WithOptional(e => e.CodeFile1)
                .HasForeignKey(e => e.EmpTypeDirector);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmKargary)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.DegreeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmKargary1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.MarriCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmLaw)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmNoHokmRel)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmPayItemsLaw)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmRasmy)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.DegreeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmRasmy1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.MarriCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.HokmRasmy2)
                .WithRequired(e => e.CodeFile2)
                .HasForeignKey(e => e.RastehCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.InsLaw)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.InsLaw1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.InsType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.Mamoriat)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.MamTypeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.Mamoriat1)
                .WithOptional(e => e.CodeFile1)
                .HasForeignKey(e => e.VehicleCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.MilitaryService)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.MontlyResult)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.MontlyResult1)
                .WithOptional(e => e.CodeFile1)
                .HasForeignKey(e => e.MamorCod);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.Morakhasi)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.MorakhasiCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.NumberHokm)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.OtherBime)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.BimeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.OtherBime1)
                .WithRequired(e => e.CodeFile1)
                .HasForeignKey(e => e.RelTypeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.PlaceEmp)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.PostNumbers)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.SpecialItem)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFile>()
                .HasMany(e => e.TaxLaw)
                .WithRequired(e => e.CodeFile)
                .HasForeignKey(e => e.EmpType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeFileMaster>()
                .Property(e => e.MainCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileMaster>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.StartMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.DeductCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.EndYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.EndMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiDeduct>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.StartMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.EndYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.EndMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.CalckOld)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContiPay>()
                .Property(e => e.permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.Months)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.Padash_Pay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.Padash_Rem)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlInfo>()
                .Property(e => e.Limit_Padash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Deduct>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Deduct>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Deduct>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Deduct>()
                .Property(e => e.DeductCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Deduct>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DegreeTashvigh>()
                .Property(e => e.DegreeDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DegreeTashvigh>()
                .Property(e => e.MadrakCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DegreeTashvigh>()
                .Property(e => e.DegreePrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DegreeTashvigh>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.RealPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.SematCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.SetadiCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eblagh>()
                .Property(e => e.EblType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.DegreeDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.MinorDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.CntyCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.SchoolOldNam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.Gpa2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpDegree>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpForeignLang>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpForeignLang>()
                .Property(e => e.LangCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpForeignLang>()
                .Property(e => e.LevelCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpForeignLang>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpImage>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpImage>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);


            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.ReltypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.RelSequence)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.IdNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.TakafolStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.RelNam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.Family)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.SexCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.BirthDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.MelliCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.FatherNam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.HealthCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.jobDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.RelDeg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.MarriCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.WarRelCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.ChildDatMarrid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.Sections)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.ChildDatDie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.RefahiState)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpRelative>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpWriting>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpWriting>()
                .Property(e => e.WriteDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpWriting>()
                .Property(e => e.Title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpWriting>()
                .Property(e => e.Dsc)
                .IsUnicode(false);

            modelBuilder.Entity<EmpWriting>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.EvaluationYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.EvaluationMon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.EvaluationGroup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.UpCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.EvaluationDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.TashvighGroup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.TashvighDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Evaluation>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.SematCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.PostCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.POstDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.KargarPostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.KargarDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ExePostNumber>()
                .Property(e => e.EvalPost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.PlcDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.JobCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.BazType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.ResonChange)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.OkCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.OkCod2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.HokmNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.IssueDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Experience>()
                .Property(e => e.JobDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinClass>()
                .Property(e => e.ClassNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinClass>()
                .Property(e => e.ClassName)
                .IsUnicode(false);

            modelBuilder.Entity<FinClass>()
                .HasMany(e => e.FinGrpAccess)
                .WithRequired(e => e.FinClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinClass>()
                .HasMany(e => e.FinUsrAccess)
                .WithRequired(e => e.FinClass)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinClass>()
                .HasMany(e => e.Finobject)
                .WithMany(e => e.FinClass)
                .Map(m => m.ToTable("FinRelClassObj").MapLeftKey("ClassNo").MapRightKey("ObjNo"));

            modelBuilder.Entity<FinGrp>()
                .Property(e => e.GrpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinGrp>()
                .Property(e => e.GrpName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinGrp>()
                .HasMany(e => e.FinGrpAccess)
                .WithRequired(e => e.FinGrp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinGrp>()
                .HasMany(e => e.FinGrpMem)
                .WithRequired(e => e.FinGrp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinGrpAccess>()
                .Property(e => e.GrpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinGrpAccess>()
                .Property(e => e.ClassNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinGrpMem>()
                .Property(e => e.GrpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinGrpMem>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finobject>()
                .Property(e => e.ObjNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finobject>()
                .Property(e => e.ObjName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finobject>()
                .Property(e => e.ObjForm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.Zonecod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.UserId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Finuser>()
                .Property(e => e.UserName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.UserFamil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.LevelNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.PostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.Postname)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.userStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.userTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.OprCod1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.useStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .Property(e => e.EblEmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Finuser>()
                .HasMany(e => e.Finuser1)
                .WithOptional(e => e.Finuser2)
                .HasForeignKey(e => e.OprCod1);

            modelBuilder.Entity<Finuser>()
                .HasMany(e => e.FinUsrAccess)
                .WithRequired(e => e.Finuser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinUsrAccess>()
                .Property(e => e.oprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FinUsrAccess>()
                .Property(e => e.ClassNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.HokmType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.GharardadType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.Tabagheh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.MarriCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.FDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.FirstHokm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.FamilyProtector)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.PartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .Property(e => e.PostNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gharardad>()
                .HasMany(e => e.HokmPaysGharardad)
                .WithRequired(e => e.Gharardad)
                .HasForeignKey(e => new { e.HokmYear, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.HokmType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.BasePay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.TaxTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.InsTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.EachHourPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.EachDayMamPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.PartTimeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.FDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.FirstHokm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.BaseTag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.Tarabary)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GharardadSaaty>()
                .Property(e => e.DscBase)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.DateDirector)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.EmpTypeDirector)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.PostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmDirector>()
                .HasMany(e => e.Gharardad)
                .WithRequired(e => e.HokmDirector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HokmDirector>()
                .HasMany(e => e.HokmKargary)
                .WithRequired(e => e.HokmDirector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HokmDirector>()
                .HasMany(e => e.HokmRasmy)
                .WithRequired(e => e.HokmDirector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HokmDirector>()
                .HasMany(e => e.Mamoriat)
                .WithRequired(e => e.HokmDirector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.Grooh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.HokmType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.CalcBackPayOld)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.MarriCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.FDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.FirstHokm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.PartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.PostNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .Property(e => e.GroupUp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmKargary>()
                .HasMany(e => e.HokmPaysKargary)
                .WithRequired(e => e.HokmKargary)
                .HasForeignKey(e => new { e.HokmYear, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HokmLaw>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmLaw>()
                .Property(e => e.HokmType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmLaw>()
                .Property(e => e.FDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmLaw>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.NoHokmCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.HokmPayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmNoHokmRel>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.AmountMarrid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.AmountSingle)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.FixTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.VarTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.Insurance)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.Mogharary)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.Tarmim)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.Bazneshastegy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.BasePay)
                .HasPrecision(5, 2);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.DayOrMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.Maximum)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPayItemsLaw>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysGharardad>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysGharardad>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysGharardad>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmPaysKargary>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysKargary>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysKargary>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmPaysRasmy>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysRasmy>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmPaysRasmy>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.HokmType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.RastehCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.ReshtehCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.DegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.MajorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.Grooh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.Tabagheh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.CityPlcCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.VillPlcDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.PartPlcDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.CalcBackPayOld)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.FirstHokm)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.MarriCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.FamilyProtector)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.FDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.EmpState)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.PartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.PostNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.GroupTashvighy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.GTatbigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.BTatbigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HokmRasmy>()
                .HasMany(e => e.HokmPaysRasmy)
                .WithRequired(e => e.HokmRasmy)
                .HasForeignKey(e => new { e.HokmYear, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.StartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.PlaceMam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.SubjectMam)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.EndTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMamoriat>()
                .Property(e => e.DirectorEmp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.StartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.EndTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.DirectorEmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HourMorakhasi>()
                .Property(e => e.Permanet)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InfoMonKind>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.InsType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.Limit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.PriceOrPercent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<InsLaw>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.CheckStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.titNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.EmpTypeItem)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.BankNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.BrnchNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.Manageable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.Activity)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.Code)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.ContiDeduct)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.DeductCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.ContiPay)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.Gharardad)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.HokmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmKargary)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.HokmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmLaw)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.HokmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmNoHokmRel)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.HokmPayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmNoHokmRel1)
                .WithRequired(e => e.ItemsDsc1)
                .HasForeignKey(e => e.NoHokmCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmPayItemsLaw)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmPaysGharardad)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmPaysKargary)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmPaysRasmy)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmRasmy)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.HokmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.HokmRasmy1)
                .WithRequired(e => e.ItemsDsc1)
                .HasForeignKey(e => e.HokmType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.Loan)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.LoantypCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasOptional(e => e.LoaSavRel)
                .WithRequired(e => e.ItemsDsc);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.LoaSavRel1)
                .WithRequired(e => e.ItemsDsc1)
                .HasForeignKey(e => e.LoanTypeCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.MontlyDeductBoss)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.DeductCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.Pay)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.PayCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsDsc>()
                .HasMany(e => e.Saving)
                .WithRequired(e => e.ItemsDsc)
                .HasForeignKey(e => e.GharsCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.FixTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.VarTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.Insurance)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.Bazneshastegy)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.CalcUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.KarkerdRelated)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemsLaw>()
                .Property(e => e.EmployerTax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.Itemcode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.Emptype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.TitkNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.Titmno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.titTno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.TitjNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.crtitkNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.crtitmNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.crTitTNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.BankNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ItemTit>()
                .Property(e => e.BrnchNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobDsc>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobDsc>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobDsc>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobDsc>()
                .HasMany(e => e.HokmRasmy)
                .WithRequired(e => e.JobDsc)
                .HasForeignKey(e => e.ReshtehCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobMajor>()
                .Property(e => e.RstCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobMajor>()
                .Property(e => e.JobMajorCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobMajor>()
                .Property(e => e.IdOrgan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobMajor>()
                .Property(e => e.JobMajorName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobMajor>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<JobMajor>()
                .HasMany(e => e.PostHokm)
                .WithRequired(e => e.JobMajor)
                .HasForeignKey(e => new { e.RstCode, e.JobMajorCode })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.Mont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.Manage1No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.Manage2No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.FileName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KaraSaving>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.Sal)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.Month)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.EmpNo)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MorTime)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MorEst3Day)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MorEst3Day1)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.Takhir)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.Taghil)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.HozorGMAR)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.HozorMA)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.AHozorMA)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.KasrKar)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.KolHozor)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MamoriyatB)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MamoriyatNB)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MamoriyatSaat)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.TatilKari)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.EzafeKar)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MorNotPay)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd>()
                .Property(e => e.MorZayman)
                .IsFixedLength();

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.Months)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.MamorType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.MamorPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.EzafeKar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.Takhir)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.Confirmed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Karkerd_Sherkaty>()
                .Property(e => e.ZoneNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.Id)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.ChartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.Dsc)
                .IsFixedLength();

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.FatherId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.LevelCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LevelChart>()
                .HasMany(e => e.JobMajor)
                .WithRequired(e => e.LevelChart)
                .HasForeignKey(e => e.IdOrgan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LevelChart>()
                .HasMany(e => e.OrganPost)
                .WithRequired(e => e.LevelChart)
                .HasForeignKey(e => e.IdOrgan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LevelChart>()
                .HasMany(e => e.PostHokm)
                .WithRequired(e => e.LevelChart)
                .HasForeignKey(e => e.IdOrgan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LimitNight>()
                .Property(e => e.Zone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitNight>()
                .Property(e => e.Dsc)
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.Mont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.ManagNo2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.ZoneName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.UnitName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.NamManagement)
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.Moaven)
                .IsUnicode(false);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.Karaee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.OfferKaraee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.MidEzafehKar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.OfferEzafehKar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.RemEzafehKar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.KaraPer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.RemKaraee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.RemCurrentEzafehKar)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LimitSum>()
                .Property(e => e.RemCurrentKaraee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.LoantypCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.LoanYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.LoanMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.NextAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Reminder)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.AmountCurr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaSavRel>()
                .Property(e => e.GharsCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaSavRel>()
                .Property(e => e.LoanTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LoaSavRel>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.DscMajor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Major>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.SequenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.MamTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.InOutCountryCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.Target)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.Subject)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.VehicleCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.VehicleDes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.MamorDes)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.CalcBackPayOld)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamoriat>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.Startdate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.Enddate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.MamorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.PlaceCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mamorin>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.RadKNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.RadMNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.RadTNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.RadJNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.TitKNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.TitMNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.TitTNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MamorPlace>()
                .Property(e => e.TitJNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.Manage1No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.Manage2No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.NamManagement)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.TelNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.RadkNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.RadMno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.RadtNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.RadjNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.UnitCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.Enable)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.SematCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.PostCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Management>()
                .HasMany(e => e.OrganUnit)
                .WithRequired(e => e.Management)
                .HasForeignKey(e => new { e.Manage1No, e.Manage2No })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.FormName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Messages>()
                .Property(e => e.Dscr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.PlcDsc)
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.LetNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.Groups)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MilitaryService>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyDeductBoss>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyDeductBoss>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyDeductBoss>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyDeductBoss>()
                .Property(e => e.DeductCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyDeductBoss>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.MamorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.BazTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.InsTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.FixTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.VarTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.SumDeduct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.SumPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.EmpState)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.PartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.HokmNoHokmRelDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.ItemsLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.InsLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.FixTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.VarTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.EmployerTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.EmployerTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.SibaPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.OrganCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.OrganCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.AccNoSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.BankCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .Property(e => e.BranchCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MontlyResult>()
                .HasMany(e => e.Deduct)
                .WithRequired(e => e.MontlyResult)
                .HasForeignKey(e => new { e.Empno, e.ResultYear, e.ResultMonth, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MontlyResult>()
                .HasMany(e => e.MontlyDeductBoss)
                .WithRequired(e => e.MontlyResult)
                .HasForeignKey(e => new { e.Empno, e.ResultYear, e.ResultMonth, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MontlyResult>()
                .HasMany(e => e.Pay)
                .WithRequired(e => e.MontlyResult)
                .HasForeignKey(e => new { e.Empno, e.ResultYear, e.ResultMonth, e.Seq })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.MorakhasiCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.DirectorEmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.EndDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.CalcBackPayOld)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Morakhasi>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.ManageNo1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.ManageNo2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.StartMont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.EndYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MorControl>()
                .Property(e => e.EndMont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.Y)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.EmpTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.empTypDsc)
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.ZoneCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.EmpNam)
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<MREM>()
                .Property(e => e.UnitDesc)
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Mont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.SematCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.LDegreeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.LPostNoEblagh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Ehraz)
                .HasPrecision(5, 2);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.JobGroup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.NewBasePay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.SpecialJob)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.SumBasePayJob)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.SumItemHokm)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Difference)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Old3555)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.New3555)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Old3556)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.New3556)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.New3004)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.OLd3004)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Emptype)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.backup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Activate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Karaee301203)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayCode3001)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayCode3002)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayCode300102)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayCode300103)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.PayCode3003)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.MangKara3029)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Karaee3012)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Karaee301202)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.Aele)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NewInfo>()
                .Property(e => e.unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.CodeType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.IssueDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.BasePayLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.HokmPayItemsLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.SpecialItemLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.HokmLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.DabirNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.DabirDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.Eblagh)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.Gharardad)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.HokmKargary)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.HokmRasmy)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.Mamoriat)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.Morakhasi)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<NumberHokm>()
                .HasOptional(e => e.PlaceEmp)
                .WithRequired(e => e.NumberHokm);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.OpCurYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.OpCurMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.PayTag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperationCurrentDate>()
                .Property(e => e.EmpTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganPost>()
                .Property(e => e.CodePost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganPost>()
                .Property(e => e.IdOrgan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganPost>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganPost>()
                .Property(e => e.PostCodeId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganPost>()
                .Property(e => e.OprCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.Manage1No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.Manage2No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.NamOrganUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.TelNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.Addr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.Active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .Property(e => e.ManageOk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnit>()
                .HasMany(e => e.MontlyResult)
                .WithRequired(e => e.OrganUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrganUnit>()
                .HasMany(e => e.PlaceEmp)
                .WithRequired(e => e.OrganUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.RelTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.RelSequence)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.BimeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.StartMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.EndYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.EndMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.InsNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBime>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.ReltypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.RelSequence)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.BimeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.EmpAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.BossAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OtherBimePrice>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.PadashYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.SixMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.Famil)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.Janbaz)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.Zone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Padash>()
                .Property(e => e.UnitCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.PayCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pay>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Place>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.DscPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.UpdtTag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Place>()
                .HasMany(e => e.HokmRasmy)
                .WithRequired(e => e.Place)
                .HasForeignKey(e => e.CityPlcCod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.PostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.TypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PlaceEmp>()
                .Property(e => e.RealPlace)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostEnshaee>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostEnshaee>()
                .Property(e => e.PostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostEnshaee>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostEnshaee>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.PostCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.IdOrgan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.RstCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.JobMajorCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.PostDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostHokm>()
                .HasMany(e => e.OrganPost)
                .WithOptional(e => e.PostHokm)
                .HasForeignKey(e => e.PostCodeId);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.PostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.TypOfPost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.KargarPostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .Property(e => e.KargarDesc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PostNumbers>()
                .HasMany(e => e.Tashvigh)
                .WithOptional(e => e.PostNumbers)
                .HasForeignKey(e => new { e.DirectorEmpType, e.DirectorPostNo });

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackItems>()
                .Property(e => e.ItemDsc)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.BankNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.BankNam)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.NamOrganUnit)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.ItemTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.EmpTypDesc)
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFBackMaster>()
                .Property(e => e.ZoneDesc)
                .IsUnicode(false);

            modelBuilder.Entity<PRFItems>()
                .Property(e => e.empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFItems>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFItems>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFItems>()
                .Property(e => e.ItemCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFItems>()
                .Property(e => e.ItemDsc)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.BankNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.BankNam)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.NamOrganUnit)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.ItemTyp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.EmpTypDesc)
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PRFMaster>()
                .Property(e => e.ZoneDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.SDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.EDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.MainCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.SubCode1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.SubCode2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.ManSahm)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.PersonSahm)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.PermitNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.PermitDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.LicenceNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.LicenceDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.Permanent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.SabtDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Refahi>()
                .Property(e => e.DelDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefahiLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength();

            modelBuilder.Entity<RefahiLaw>()
                .Property(e => e.MainCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefahiLaw>()
                .Property(e => e.SubCode1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefahiLaw>()
                .Property(e => e.SubCode2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefahiLaw>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RefahiType>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.MainCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.SubCode1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.SubCode2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.Title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.ParentCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile>()
                .Property(e => e.RfDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.MainCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.SubCode1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.SubCode2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.Title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RfCodeFile0>()
                .Property(e => e.ParentCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.GharsCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.StartYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.StartMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.SumHokm)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Saving>()
                .Property(e => e.AmountSave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Saving>()
                .Property(e => e.EndYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.EndMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.AmountCurr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Saving>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.OrgAccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Saving>()
                .Property(e => e.OrgAmountSave)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Saving>()
                .Property(e => e.Reminder)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.ResultYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.ResultMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BasePay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.AfzSanavat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FoghJob)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FoghJazb)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Aeleh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Olad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Maskan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Sepordeh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FoghTalash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FoghVijeh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FoghOmran)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Karaneh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EzafeKar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.HokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.MamorCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.Calck)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BazTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.InsTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FixTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.VarTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.AccNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.SumDeduct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.SumPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EmpState)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.StopStat)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.PartTime)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.HokmNoHokmRelDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.ItemsLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.InsLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.FixTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.VarTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EmployerTaxTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.EmployerTaxLawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.SibaPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.OrganCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.OrganCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.AccNoSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BankCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ShahdarPay>()
                .Property(e => e.BranchCodSh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.SibaYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.SibaMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.OrganCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.PayType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SibaDisk>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.LawDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.MinPayMnth)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SpecialItem>()
                .Property(e => e.TrainingReward)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.ZoneCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.YearPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.MonThPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.ListType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.KindUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.SumAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayDeduct>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.FinYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.FinMonth)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Hoghogh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Shoghl)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Jazb)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Place)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.AelehOlad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Masheghat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Tatbigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Nobatkari)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.TashvighDgr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Naghdi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Maskan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Jebheh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Tarmim)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.EzafeKar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.TatilKari)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Padash)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.PadashNet)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Karaneh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Sarparasti)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Mamoriat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Jalaseh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Sham)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.CashKasr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Traffick)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Karaie)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Mosaedat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.ShabKari)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.ZohrKari)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Shir)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.TarmimHoghogh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.HazinehMaskan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.FoghVisheh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.OtherPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Vabasteh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Dolati)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.GharsLoan)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Bime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeBossSpec)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeBossSpecEmployeer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Mogharari)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Darmani1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Darmani2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Darmani3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.DarmaniBoss1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.DarmaniBoss2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.DarmaniBoss3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeLife)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeLifeBoss)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Saving)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Takhir)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.FixSaving)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Khazaneh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.OtherBime)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.OtherKasr)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.TaxBoss)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeBoss1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeBossEmployeer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeBoss2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Etebar)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.FixPasandaz)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.KaranehManage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.HaghAlZahmeh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.Keshik)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.HazinehTel)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.BimeKarfarma4P)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.PayList)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SumPayList>()
                .Property(e => e.RunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_Log>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<t_Log>()
                .Property(e => e.LogStatusClientIpAddress)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.Type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.TashvighDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.DirectorEmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.DirectorPostNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.DirectorEmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.PostDsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.ComiteeType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tashvigh>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.StartDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.TaxTypeCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.TaxMin)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.TaxMax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.TaxPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.CalcBackPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxLaw>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.DscSum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.crtitkNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.crtitmNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.crTitTNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.TitkNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.Titmno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.titTno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TitleSumPayDeduct>()
                .Property(e => e.TitjNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Training>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.ZoneType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.City)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.KargahSerial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.OrganCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.OrganCod1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.BankCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .Property(e => e.BranchCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.BonKargary)
                .WithRequired(e => e.Zone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.Finuser)
                .WithRequired(e => e.Zone)
                .HasForeignKey(e => e.Zonecod)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.OperationCurrentDate)
                .WithRequired(e => e.Zone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.Padash)
                .WithRequired(e => e.Zone1)
                .HasForeignKey(e => e.Zone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zone>()
                .HasMany(e => e.Eidy)
                .WithOptional(e => e.Zone1)
                .HasForeignKey(e => e.Zone);

            modelBuilder.Entity<ChartRelPost>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChartRelPost>()
                .Property(e => e.ExePostCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChartRelPost>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ChartRelPost>()
                .Property(e => e.SematCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileMasterTax>()
                .Property(e => e.MainCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileMasterTax>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileTax>()
                .Property(e => e.Code)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileTax>()
                .Property(e => e.Dsc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileTax>()
                .Property(e => e.Tag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CodeFileTax>()
                .Property(e => e.OprCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.EmpNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.EidyYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.Family)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.Zone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Eidy>()
                .Property(e => e.UnitCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Empno)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Years)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Mont)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.LHokmYear)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.LRunDate)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Family)
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.EmpType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.NamOrganUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.NamManagement)
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Moaven)
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Manage1No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Manage2No)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Mabna)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Sanavat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Shoghl)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.GetempType)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.emptypdsc)
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.backup)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.SetadiCod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Tatbigh)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LimitKara>()
                .Property(e => e.KaraPer)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OrganUnitParent>()
                .Property(e => e.Unit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnitParent>()
                .Property(e => e.Parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OrganUnitParent>()
                .Property(e => e.NamOrganUnit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Dossier_NUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Year_SH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Mahe_SH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Total_Salary_Pay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Total_Pay_Under_TAX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Total_Tax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Tax_Penalty_anunce)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Tax_Penalty_Pay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Rest_Tax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Total_Salary)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Totality_ALL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Total_TAX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Total_Penarty_anunce)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Total_Penalty_Pay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.YET_Rest_Tax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Icorprate_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Total_Person)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Total_Forin_Person)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Pay_Method)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Check_Serial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Check_Date)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Bank_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.BRanche_Name)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Bank_ACC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Pay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SarJam_Maliati>()
                .Property(e => e.Zone_CODE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.ZoneCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.TaxNoDossier)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.ElementryPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.SecondryPay)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.CompanyName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.EcononicCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.PostalCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Tel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Personal1Permit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Man1Permit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Personal2Permit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaxDisk>()
                .Property(e => e.Man2Permit)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
