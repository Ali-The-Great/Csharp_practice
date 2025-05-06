using Microsoft.EntityFrameworkCore;
using revision.Models;

namespace revision.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<A> As { get; set; }

    public virtual DbSet<Abc> Abcs { get; set; }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Actorsbackup2017> Actorsbackup2017s { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<AffiliatedWith> AffiliatedWiths { get; set; }

    public virtual DbSet<Agentview> Agentviews { get; set; }

    public virtual DbSet<Ahmed> Ahmeds { get; set; }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<AsstRefereeMast> AsstRefereeMasts { get; set; }

    public virtual DbSet<Bh> Bhs { get; set; }

    public virtual DbSet<Bitch> Bitches { get; set; }

    public virtual DbSet<Blah> Blahs { get; set; }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<Casino> Casinos { get; set; }

    public virtual DbSet<CoachMast> CoachMasts { get; set; }

    public virtual DbSet<Col1> Col1s { get; set; }

    public virtual DbSet<CompanyMast> CompanyMasts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerBackup> CustomerBackups { get; set; }

    public virtual DbSet<CustomerId> CustomerIds { get; set; }

    public virtual DbSet<CustomerId123> CustomerId123s { get; set; }

    public virtual DbSet<Customergradelevel> Customergradelevels { get; set; }

    public virtual DbSet<Customergradelevels2> Customergradelevels2s { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Department1> Departments1 { get; set; }

    public virtual DbSet<DepartmentDetail> DepartmentDetails { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Duplicate> Duplicates { get; set; }

    public virtual DbSet<Elephant> Elephants { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    public virtual DbSet<EmpDepartment> EmpDepartments { get; set; }

    public virtual DbSet<EmpDetail> EmpDetails { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<Ff> Ffs { get; set; }

    public virtual DbSet<Fg> Fgs { get; set; }

    public virtual DbSet<GameScore> GameScores { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<GoalDetail> GoalDetails { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Grade1> Grades1 { get; set; }

    public virtual DbSet<GradeCustomer> GradeCustomers { get; set; }

    public virtual DbSet<GradeCustomer1> GradeCustomer1s { get; set; }

    public virtual DbSet<Hello> Hellos { get; set; }

    public virtual DbSet<Hello11122> Hello11122s { get; set; }

    public virtual DbSet<Hello112> Hello112s { get; set; }

    public virtual DbSet<Hello12> Hello12s { get; set; }

    public virtual DbSet<ItemMast> ItemMasts { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobGrade> JobGrades { get; set; }

    public virtual DbSet<JobHistory> JobHistories { get; set; }

    public virtual DbSet<Kk> Kks { get; set; }

    public virtual DbSet<Kkk> Kkks { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Londoncustomer> Londoncustomers { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<MatchCaptain> MatchCaptains { get; set; }

    public virtual DbSet<MatchDetail> MatchDetails { get; set; }

    public virtual DbSet<MatchMast> MatchMasts { get; set; }

    public virtual DbSet<Maxim00> Maxim00s { get; set; }

    public virtual DbSet<Maximum> Maximums { get; set; }

    public virtual DbSet<Maximum00> Maximum00s { get; set; }

    public virtual DbSet<Maximum899> Maximum899s { get; set; }

    public virtual DbSet<Medication> Medications { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<MovieCast> MovieCasts { get; set; }

    public virtual DbSet<MovieDirection> MovieDirections { get; set; }

    public virtual DbSet<MovieGenre> MovieGenres { get; set; }

    public virtual DbSet<My> Mies { get; set; }

    public virtual DbSet<Mytemptable> Mytemptables { get; set; }

    public virtual DbSet<Mytest> Mytests { get; set; }

    public virtual DbSet<Mytest1> Mytest1s { get; set; }

    public virtual DbSet<Myworkstuff> Myworkstuffs { get; set; }

    public virtual DbSet<Myworkstuff1> Myworkstuffs1 { get; set; }

    public virtual DbSet<New> News { get; set; }

    public virtual DbSet<New123> New123s { get; set; }

    public virtual DbSet<NewTable1> NewTables { get; set; }

    public virtual DbSet<Newsalesman> Newsalesmen { get; set; }

    public virtual DbSet<Newtab> Newtabs { get; set; }

    public virtual DbSet<Newtable> Newtables { get; set; }

    public virtual DbSet<Newyorksalesman> Newyorksalesmen { get; set; }

    public virtual DbSet<Newyorksalesman2> Newyorksalesman2s { get; set; }

    public virtual DbSet<Newyorksalesman3> Newyorksalesman3s { get; set; }

    public virtual DbSet<Newyorkstaff> Newyorkstaffs { get; set; }

    public virtual DbSet<NobelWin> NobelWins { get; set; }

    public virtual DbSet<Norder> Norders { get; set; }

    public virtual DbSet<Nro> Nros { get; set; }

    public virtual DbSet<Nuevo> Nuevos { get; set; }

    public virtual DbSet<Number> Numbers { get; set; }

    public virtual DbSet<Numeri> Numeris { get; set; }

    public virtual DbSet<Numero> Numeros { get; set; }

    public virtual DbSet<Nurse> Nurses { get; set; }

    public virtual DbSet<Odr> Odrs { get; set; }

    public virtual DbSet<Oi> Ois { get; set; }

    public virtual DbSet<OnCall> OnCalls { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Ordersview> Ordersviews { get; set; }

    public virtual DbSet<Orozco> Orozcos { get; set; }

    public virtual DbSet<Partest1> Partest1s { get; set; }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Participant1> Participants1 { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PenaltyGk> PenaltyGks { get; set; }

    public virtual DbSet<PenaltyShootout> PenaltyShootouts { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Physician> Physicians { get; set; }

    public virtual DbSet<PlayerBooked> PlayerBookeds { get; set; }

    public virtual DbSet<PlayerInOut> PlayerInOuts { get; set; }

    public virtual DbSet<PlayerMast> PlayerMasts { get; set; }

    public virtual DbSet<PlayingPosition> PlayingPositions { get; set; }

    public virtual DbSet<Prescribe> Prescribes { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<RefereeMast> RefereeMasts { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Related> Relateds { get; set; }

    public virtual DbSet<Reviewer> Reviewers { get; set; }

    public virtual DbSet<Rightjoin> Rightjoins { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Salesdetail> Salesdetails { get; set; }

    public virtual DbSet<Salesman> Salesmen { get; set; }

    public virtual DbSet<SalesmanDetail1> SalesmanDetails { get; set; }

    public virtual DbSet<SalesmanDo1304> SalesmanDo1304s { get; set; }

    public virtual DbSet<SalesmanExample> SalesmanExamples { get; set; }

    public virtual DbSet<SalesmanNy> SalesmanNies { get; set; }

    public virtual DbSet<Salesmandetail> Salesmandetails { get; set; }

    public virtual DbSet<Salesown> Salesowns { get; set; }

    public virtual DbSet<SampleTable> SampleTables { get; set; }

    public virtual DbSet<Score> Scores { get; set; }

    public virtual DbSet<SoccerCity> SoccerCities { get; set; }

    public virtual DbSet<SoccerCountry> SoccerCountries { get; set; }

    public virtual DbSet<SoccerTeam> SoccerTeams { get; set; }

    public virtual DbSet<SoccerVenue> SoccerVenues { get; set; }

    public virtual DbSet<Statement> Statements { get; set; }

    public virtual DbSet<Stay> Stays { get; set; }

    public virtual DbSet<revision.Models.String> Strings { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Student1> Student1s { get; set; }

    public virtual DbSet<Sybba> Sybbas { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<TeamCoach> TeamCoaches { get; set; }

    public virtual DbSet<Temp> Temps { get; set; }

    public virtual DbSet<Tempa> Tempas { get; set; }

    public virtual DbSet<Tempcustomer> Tempcustomers { get; set; }

    public virtual DbSet<Temphi> Temphis { get; set; }

    public virtual DbSet<Tempp> Tempps { get; set; }

    public virtual DbSet<Tempp11> Tempp11s { get; set; }

    public virtual DbSet<Tempsalesman> Tempsalesmen { get; set; }

    public virtual DbSet<Test> Tests { get; set; }

    public virtual DbSet<Teste> Testes { get; set; }

    public virtual DbSet<Testtable> Testtables { get; set; }

    public virtual DbSet<Testtesing> Testtesings { get; set; }

    public virtual DbSet<Testtest> Testtests { get; set; }

    public virtual DbSet<TrainedIn> TrainedIns { get; set; }

    public virtual DbSet<Trentum> Trenta { get; set; }

    public virtual DbSet<Tt> Tts { get; set; }

    public virtual DbSet<Undergo> Undergoes { get; set; }

    public virtual DbSet<V1> V1s { get; set; }

    public virtual DbSet<View> Views { get; set; }

    public virtual DbSet<Vowl> Vowls { get; set; }

    public virtual DbSet<Zebra> Zebras { get; set; }

    public virtual DbSet<Zz> Zzs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=sqlex;Username=meow;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<A>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("a");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Abc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abc");

            entity.Property(e => e.EmpDept).HasColumnName("emp_dept");
            entity.Property(e => e.EmpIdno).HasColumnName("emp_idno");
            entity.Property(e => e.Rnk2).HasColumnName("rnk2");
        });

        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.ActId).HasName("actor_pkey");

            entity.ToTable("actor");

            entity.Property(e => e.ActId)
                .ValueGeneratedNever()
                .HasColumnName("act_id");
            entity.Property(e => e.ActFname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("act_fname");
            entity.Property(e => e.ActGender)
                .HasMaxLength(1)
                .HasColumnName("act_gender");
            entity.Property(e => e.ActLname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("act_lname");
        });

        modelBuilder.Entity<Actorsbackup2017>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("actorsbackup2017");

            entity.Property(e => e.ActFname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("act_fname");
            entity.Property(e => e.ActLname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("act_lname");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("address");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<AffiliatedWith>(entity =>
        {
            entity.HasKey(e => new { e.Physician, e.Department }).HasName("affiliated_with_pkey");

            entity.ToTable("affiliated_with");

            entity.Property(e => e.Physician).HasColumnName("physician");
            entity.Property(e => e.Department).HasColumnName("department");
            entity.Property(e => e.Primaryaffiliation).HasColumnName("primaryaffiliation");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.AffiliatedWiths)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_department_departmentid");

            entity.HasOne(d => d.PhysicianNavigation).WithMany(p => p.AffiliatedWiths)
                .HasForeignKey(d => d.Physician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");
        });

        modelBuilder.Entity<Agentview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("agentview");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Ahmed>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ahmed");

            entity.Property(e => e.DepartmentId)
                .HasPrecision(4)
                .HasColumnName("department_id");
            entity.Property(e => e.EmployeeId)
                .HasPrecision(6)
                .HasColumnName("employee_id");
            entity.Property(e => e.Salary)
                .HasPrecision(8, 2)
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Appointmentid).HasName("appointment_pkey");

            entity.ToTable("appointment");

            entity.Property(e => e.Appointmentid)
                .ValueGeneratedNever()
                .HasColumnName("appointmentid");
            entity.Property(e => e.EndDtTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_dt_time");
            entity.Property(e => e.Examinationroom).HasColumnName("examinationroom");
            entity.Property(e => e.Patient).HasColumnName("patient");
            entity.Property(e => e.Physician).HasColumnName("physician");
            entity.Property(e => e.Prepnurse).HasColumnName("prepnurse");
            entity.Property(e => e.StartDtTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_dt_time");

            entity.HasOne(d => d.PatientNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_patient_ssn");

            entity.HasOne(d => d.PhysicianNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.Physician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");

            entity.HasOne(d => d.PrepnurseNavigation).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.Prepnurse)
                .HasConstraintName("fk_nurse_employeeid");
        });

        modelBuilder.Entity<AsstRefereeMast>(entity =>
        {
            entity.HasKey(e => e.AssRefId).HasName("asst_referee_mast_pkey");

            entity.ToTable("asst_referee_mast");

            entity.Property(e => e.AssRefId).HasColumnName("ass_ref_id");
            entity.Property(e => e.AssRefName)
                .HasMaxLength(40)
                .HasColumnName("ass_ref_name");
            entity.Property(e => e.CountryId).HasColumnName("country_id");

            entity.HasOne(d => d.Country).WithMany(p => p.AsstRefereeMasts)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("country_id_fkey");
        });

        modelBuilder.Entity<Bh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bh");

            entity.Property(e => e.EmpId).HasColumnName("emp_id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Process)
                .HasMaxLength(20)
                .HasColumnName("process");
        });

        modelBuilder.Entity<Bitch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bitch");

            entity.Property(e => e.Sum).HasColumnName("sum");
        });

        modelBuilder.Entity<Blah>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("blah");

            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasColumnName("purch_amt");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.HasKey(e => new { e.Blockfloor, e.Blockcode }).HasName("block_pkey");

            entity.ToTable("block");

            entity.Property(e => e.Blockfloor).HasColumnName("blockfloor");
            entity.Property(e => e.Blockcode).HasColumnName("blockcode");
        });

        modelBuilder.Entity<Casino>(entity =>
        {
            entity.HasKey(e => e.Casino1).HasName("casino_pkey");

            entity.ToTable("casino");

            entity.Property(e => e.Casino1)
                .HasMaxLength(75)
                .HasColumnName("casino");
            entity.Property(e => e.Events)
                .HasMaxLength(50)
                .HasColumnName("events");
            entity.Property(e => e.Location)
                .HasMaxLength(40)
                .HasColumnName("location");
            entity.Property(e => e.Pricerange)
                .HasPrecision(6)
                .HasColumnName("pricerange");
        });

        modelBuilder.Entity<CoachMast>(entity =>
        {
            entity.HasKey(e => e.CoachId).HasName("coach_mast_pkey");

            entity.ToTable("coach_mast");

            entity.Property(e => e.CoachId).HasColumnName("coach_id");
            entity.Property(e => e.CoachName)
                .HasMaxLength(40)
                .HasColumnName("coach_name");
        });

        modelBuilder.Entity<Col1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("col1");

            entity.Property(e => e.Column).HasColumnName("?column?");
        });

        modelBuilder.Entity<CompanyMast>(entity =>
        {
            entity.HasKey(e => e.ComId).HasName("company_mast_pkey");

            entity.ToTable("company_mast");

            entity.Property(e => e.ComId)
                .ValueGeneratedNever()
                .HasColumnName("com_id");
            entity.Property(e => e.ComName)
                .HasMaxLength(20)
                .HasColumnName("com_name");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("countries");

            entity.Property(e => e.CountryId)
                .HasMaxLength(2)
                .HasColumnName("country_id");
            entity.Property(e => e.CountryName)
                .HasMaxLength(40)
                .HasColumnName("country_name");
            entity.Property(e => e.RegionId)
                .HasPrecision(10)
                .HasColumnName("region_id");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("customer_pkey");

            entity.ToTable("customer");

            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasDefaultValueSql("0")
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");

            entity.HasOne(d => d.Salesman).WithMany(p => p.Customers)
                .HasForeignKey(d => d.SalesmanId)
                .HasConstraintName("salesman_id_fk");
        });

        modelBuilder.Entity<CustomerBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("customer_backup");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<CustomerId>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("customer_id");

            entity.Property(e => e.CustomerId1)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasColumnName("purch_amt");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<CustomerId123>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("customer_id_123");

            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasColumnName("purch_amt");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Customergradelevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("customergradelevels");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<Customergradelevels2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("customergradelevels2");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("departments_pkey");

            entity.ToTable("departments");

            entity.Property(e => e.DepartmentId)
                .HasPrecision(4)
                .HasColumnName("department_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("department_name");
            entity.Property(e => e.LocationId)
                .HasPrecision(4)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("location_id");
            entity.Property(e => e.ManagerId)
                .HasPrecision(6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("manager_id");
        });

        modelBuilder.Entity<Department1>(entity =>
        {
            entity.HasKey(e => e.Departmentid).HasName("department_pkey");

            entity.ToTable("department");

            entity.Property(e => e.Departmentid)
                .ValueGeneratedNever()
                .HasColumnName("departmentid");
            entity.Property(e => e.Head).HasColumnName("head");
            entity.Property(e => e.Name).HasColumnName("name");

            entity.HasOne(d => d.HeadNavigation).WithMany(p => p.Department1s)
                .HasForeignKey(d => d.Head)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");
        });

        modelBuilder.Entity<DepartmentDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("department_detail");

            entity.Property(e => e.DepartmentId)
                .HasPrecision(4)
                .HasColumnName("department_id");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(30)
                .HasColumnName("department_name");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.DirId).HasName("director_pkey");

            entity.ToTable("director");

            entity.Property(e => e.DirId)
                .ValueGeneratedNever()
                .HasColumnName("dir_id");
            entity.Property(e => e.DirFname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("dir_fname");
            entity.Property(e => e.DirLname)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("dir_lname");
        });

        modelBuilder.Entity<Duplicate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("duplicate");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Elephant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("elephants_pkey");

            entity.ToTable("elephants");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("now()")
                .HasColumnName("date");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("emp_pk");

            entity.ToTable("emp");

            entity.Property(e => e.Eid)
                .HasPrecision(3)
                .HasColumnName("eid");
            entity.Property(e => e.Ename)
                .HasMaxLength(13)
                .HasColumnName("ename");
            entity.Property(e => e.Salary)
                .HasPrecision(6)
                .HasColumnName("salary");
        });

        modelBuilder.Entity<EmpDepartment>(entity =>
        {
            entity.HasKey(e => e.DptCode).HasName("emp_department_pkey");

            entity.ToTable("emp_department");

            entity.Property(e => e.DptCode)
                .ValueGeneratedNever()
                .HasColumnName("dpt_code");
            entity.Property(e => e.DptAllotment).HasColumnName("dpt_allotment");
            entity.Property(e => e.DptName)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("dpt_name");
        });

        modelBuilder.Entity<EmpDetail>(entity =>
        {
            entity.HasKey(e => e.EmpIdno).HasName("emp_details_pkey");

            entity.ToTable("emp_details");

            entity.Property(e => e.EmpIdno)
                .ValueGeneratedNever()
                .HasColumnName("emp_idno");
            entity.Property(e => e.EmpDept).HasColumnName("emp_dept");
            entity.Property(e => e.EmpFname)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("emp_fname");
            entity.Property(e => e.EmpLname)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("emp_lname");

            entity.HasOne(d => d.EmpDeptNavigation).WithMany(p => p.EmpDetails)
                .HasForeignKey(d => d.EmpDept)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emp_details_emp_dept_fkey");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employee");

            entity.Property(e => e.Empno).HasColumnName("empno");
            entity.Property(e => e.Ename)
                .HasMaxLength(20)
                .HasColumnName("ename");
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("employees_pkey");

            entity.ToTable("employees");

            entity.Property(e => e.EmployeeId)
                .HasPrecision(6)
                .HasDefaultValueSql("(0)::numeric")
                .HasColumnName("employee_id");
            entity.Property(e => e.CommissionPct)
                .HasPrecision(2, 2)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("commission_pct");
            entity.Property(e => e.DepartmentId)
                .HasPrecision(4)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("department_id");
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("first_name");
            entity.Property(e => e.HireDate).HasColumnName("hire_date");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("job_id");
            entity.Property(e => e.LastName)
                .HasMaxLength(25)
                .HasColumnName("last_name");
            entity.Property(e => e.ManagerId)
                .HasPrecision(6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("manager_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("phone_number");
            entity.Property(e => e.Salary)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("salary");
        });

        modelBuilder.Entity<Ff>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ff");

            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("category");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
            entity.Property(e => e.Subject)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("subject");
            entity.Property(e => e.Winner)
                .HasMaxLength(45)
                .IsFixedLength()
                .HasColumnName("winner");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Fg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fg");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
        });

        modelBuilder.Entity<GameScore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_scores_pkey");

            entity.ToTable("game_scores");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenId).HasName("genres_pkey");

            entity.ToTable("genres");

            entity.Property(e => e.GenId)
                .ValueGeneratedNever()
                .HasColumnName("gen_id");
            entity.Property(e => e.GenTitle)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("gen_title");
        });

        modelBuilder.Entity<GoalDetail>(entity =>
        {
            entity.HasKey(e => e.GoalId).HasName("goal_details_pkey");

            entity.ToTable("goal_details");

            entity.Property(e => e.GoalId).HasColumnName("goal_id");
            entity.Property(e => e.GoalHalf).HasColumnName("goal_half");
            entity.Property(e => e.GoalSchedule)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("goal_schedule");
            entity.Property(e => e.GoalTime).HasColumnName("goal_time");
            entity.Property(e => e.GoalType)
                .HasMaxLength(1)
                .HasColumnName("goal_type");
            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayStage)
                .HasMaxLength(1)
                .HasColumnName("play_stage");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.MatchNoNavigation).WithMany(p => p.GoalDetails)
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.Player).WithMany(p => p.GoalDetails)
                .HasForeignKey(d => d.PlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.GoalDetails)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("grades_pkey");

            entity.ToTable("grades");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Grade1).HasColumnName("grade_1");
            entity.Property(e => e.Grade2).HasColumnName("grade_2");
            entity.Property(e => e.Grade3).HasColumnName("grade_3");
        });

        modelBuilder.Entity<Grade1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("grade");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<GradeCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("grade_customer");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<GradeCustomer1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("grade_customer1");

            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.Number).HasColumnName("number");
        });

        modelBuilder.Entity<Hello>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hello");

            entity.Property(e => e.NumberOne).HasColumnName("number_one");
            entity.Property(e => e.NumberThree).HasColumnName("number_three");
            entity.Property(e => e.NumberTwo).HasColumnName("number_two");
        });

        modelBuilder.Entity<Hello11122>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hello1_1122");

            entity.Property(e => e.Abc).HasColumnName("abc");
        });

        modelBuilder.Entity<Hello112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hello1_12");

            entity.Property(e => e.Abc).HasColumnName("abc");
        });

        modelBuilder.Entity<Hello12>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hello_12");

            entity.Property(e => e.Abc).HasColumnName("abc");
        });

        modelBuilder.Entity<ItemMast>(entity =>
        {
            entity.HasKey(e => e.ProId).HasName("item_mast_pkey");

            entity.ToTable("item_mast");

            entity.Property(e => e.ProId)
                .ValueGeneratedNever()
                .HasColumnName("pro_id");
            entity.Property(e => e.ProCom).HasColumnName("pro_com");
            entity.Property(e => e.ProName)
                .HasMaxLength(25)
                .HasColumnName("pro_name");
            entity.Property(e => e.ProPrice)
                .HasPrecision(8, 2)
                .HasColumnName("pro_price");

            entity.HasOne(d => d.ProComNavigation).WithMany(p => p.ItemMasts)
                .HasForeignKey(d => d.ProCom)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("item_mast_pro_com_fkey");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("jobs_pkey");

            entity.ToTable("jobs");

            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("job_id");
            entity.Property(e => e.JobTitle)
                .HasMaxLength(35)
                .HasColumnName("job_title");
            entity.Property(e => e.MaxSalary)
                .HasPrecision(6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("max_salary");
            entity.Property(e => e.MinSalary)
                .HasPrecision(6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("min_salary");
        });

        modelBuilder.Entity<JobGrade>(entity =>
        {
            entity.HasKey(e => e.GradeLevel).HasName("job_grades_pkey");

            entity.ToTable("job_grades");

            entity.Property(e => e.GradeLevel)
                .HasMaxLength(20)
                .HasColumnName("grade_level");
            entity.Property(e => e.HighestSal)
                .HasPrecision(5)
                .HasColumnName("highest_sal");
            entity.Property(e => e.LowestSal)
                .HasPrecision(5)
                .HasColumnName("lowest_sal");
        });

        modelBuilder.Entity<JobHistory>(entity =>
        {
            entity.HasKey(e => new { e.EmployeeId, e.StartDate }).HasName("job_history_pkey");

            entity.ToTable("job_history");

            entity.Property(e => e.EmployeeId)
                .HasPrecision(6)
                .HasColumnName("employee_id");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.DepartmentId)
                .HasPrecision(4)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("department_id");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.JobId)
                .HasMaxLength(10)
                .HasColumnName("job_id");
        });

        modelBuilder.Entity<Kk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kk");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Kkk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("kkk");

            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("locations_pkey");

            entity.ToTable("locations");

            entity.Property(e => e.LocationId)
                .HasPrecision(4)
                .HasDefaultValueSql("(0)::numeric")
                .HasColumnName("location_id");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.CountryId)
                .HasMaxLength(2)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("country_id");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(12)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("postal_code");
            entity.Property(e => e.StateProvince)
                .HasMaxLength(25)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("state_province");
            entity.Property(e => e.StreetAddress)
                .HasMaxLength(40)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("street_address");
        });

        modelBuilder.Entity<Londoncustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("londoncustomers");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Code)
                .ValueGeneratedNever()
                .HasColumnName("code");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<MatchCaptain>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("match_captain");

            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayerCaptain).HasColumnName("player_captain");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.MatchNoNavigation).WithMany()
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.PlayerCaptainNavigation).WithMany()
                .HasForeignKey(d => d.PlayerCaptain)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_captain_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<MatchDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("match_details");

            entity.Property(e => e.AssRef).HasColumnName("ass_ref");
            entity.Property(e => e.DecidedBy)
                .HasMaxLength(1)
                .HasColumnName("decided_by");
            entity.Property(e => e.GoalScore).HasColumnName("goal_score");
            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PenaltyScore).HasColumnName("penalty_score");
            entity.Property(e => e.PlayStage)
                .HasMaxLength(1)
                .HasColumnName("play_stage");
            entity.Property(e => e.PlayerGk).HasColumnName("player_gk");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
            entity.Property(e => e.WinLose)
                .HasMaxLength(1)
                .HasColumnName("win_lose");

            entity.HasOne(d => d.AssRefNavigation).WithMany()
                .HasForeignKey(d => d.AssRef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ass_ref_fkey");

            entity.HasOne(d => d.MatchNoNavigation).WithMany()
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.PlayerGkNavigation).WithMany()
                .HasForeignKey(d => d.PlayerGk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_gk_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<MatchMast>(entity =>
        {
            entity.HasKey(e => e.MatchNo).HasName("match_mast_pkey");

            entity.ToTable("match_mast");

            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.Audence).HasColumnName("audence");
            entity.Property(e => e.DecidedBy)
                .HasMaxLength(1)
                .HasColumnName("decided_by");
            entity.Property(e => e.GoalScore)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("goal_score");
            entity.Property(e => e.PlayDate).HasColumnName("play_date");
            entity.Property(e => e.PlayStage)
                .HasMaxLength(1)
                .HasColumnName("play_stage");
            entity.Property(e => e.PlrOfMatch).HasColumnName("plr_of_match");
            entity.Property(e => e.RefereeId).HasColumnName("referee_id");
            entity.Property(e => e.Results)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("results");
            entity.Property(e => e.Stop1Sec).HasColumnName("stop1_sec");
            entity.Property(e => e.Stop2Sec).HasColumnName("stop2_sec");
            entity.Property(e => e.VenueId).HasColumnName("venue_id");

            entity.HasOne(d => d.PlrOfMatchNavigation).WithMany(p => p.MatchMasts)
                .HasForeignKey(d => d.PlrOfMatch)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("plr_of_match_fkey");

            entity.HasOne(d => d.Referee).WithMany(p => p.MatchMasts)
                .HasForeignKey(d => d.RefereeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("referee_id_fkey");

            entity.HasOne(d => d.Venue).WithMany(p => p.MatchMasts)
                .HasForeignKey(d => d.VenueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venue_id_fkey");
        });

        modelBuilder.Entity<Maxim00>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maxim00");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
            entity.Property(e => e.Num).HasColumnName("num");
        });

        modelBuilder.Entity<Maximum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maximum");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
            entity.Property(e => e.Num).HasColumnName("num");
        });

        modelBuilder.Entity<Maximum00>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maximum00");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
            entity.Property(e => e.Num).HasColumnName("num");
        });

        modelBuilder.Entity<Maximum899>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maximum899");

            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .HasColumnName("name");
            entity.Property(e => e.Num).HasColumnName("num");
        });

        modelBuilder.Entity<Medication>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("medication_pkey");

            entity.ToTable("medication");

            entity.Property(e => e.Code)
                .ValueGeneratedNever()
                .HasColumnName("code");
            entity.Property(e => e.Brand).HasColumnName("brand");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.MovId).HasName("movie_pkey");

            entity.ToTable("movie");

            entity.Property(e => e.MovId)
                .ValueGeneratedNever()
                .HasColumnName("mov_id");
            entity.Property(e => e.MovDtRel).HasColumnName("mov_dt_rel");
            entity.Property(e => e.MovLang)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("mov_lang");
            entity.Property(e => e.MovRelCountry)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("mov_rel_country");
            entity.Property(e => e.MovTime).HasColumnName("mov_time");
            entity.Property(e => e.MovTitle)
                .HasMaxLength(50)
                .IsFixedLength()
                .HasColumnName("mov_title");
            entity.Property(e => e.MovYear).HasColumnName("mov_year");
        });

        modelBuilder.Entity<MovieCast>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("movie_cast");

            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.MovId).HasColumnName("mov_id");
            entity.Property(e => e.Role)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("role");

            entity.HasOne(d => d.Act).WithMany()
                .HasForeignKey(d => d.ActId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_cast_act_id_fkey");

            entity.HasOne(d => d.Mov).WithMany()
                .HasForeignKey(d => d.MovId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_cast_mov_id_fkey");
        });

        modelBuilder.Entity<MovieDirection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("movie_direction");

            entity.Property(e => e.DirId).HasColumnName("dir_id");
            entity.Property(e => e.MovId).HasColumnName("mov_id");

            entity.HasOne(d => d.Dir).WithMany()
                .HasForeignKey(d => d.DirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_direction_dir_id_fkey");

            entity.HasOne(d => d.Mov).WithMany()
                .HasForeignKey(d => d.MovId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_direction_mov_id_fkey");
        });

        modelBuilder.Entity<MovieGenre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("movie_genres");

            entity.Property(e => e.GenId).HasColumnName("gen_id");
            entity.Property(e => e.MovId).HasColumnName("mov_id");

            entity.HasOne(d => d.Gen).WithMany()
                .HasForeignKey(d => d.GenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_genres_gen_id_fkey");

            entity.HasOne(d => d.Mov).WithMany()
                .HasForeignKey(d => d.MovId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("movie_genres_mov_id_fkey");
        });

        modelBuilder.Entity<My>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("my");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
        });

        modelBuilder.Entity<Mytemptable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mytemptable");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
        });

        modelBuilder.Entity<Mytest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mytest");

            entity.HasIndex(e => e.OrdNum, "mytest_ord_num_key").IsUnique();

            entity.Property(e => e.AgentCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("agent_code");
            entity.Property(e => e.CustCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("cust_code");
            entity.Property(e => e.OrdAmount)
                .HasPrecision(12, 2)
                .HasColumnName("ord_amount");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNum)
                .HasPrecision(6)
                .HasColumnName("ord_num");
        });

        modelBuilder.Entity<Mytest1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mytest1");

            entity.HasIndex(e => e.OrdNum, "mytest1_ord_num_key").IsUnique();

            entity.Property(e => e.AgentCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("agent_code");
            entity.Property(e => e.CustCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("cust_code");
            entity.Property(e => e.OrdAmount)
                .HasPrecision(12, 2)
                .HasColumnName("ord_amount");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNum)
                .HasPrecision(6)
                .HasColumnName("ord_num");
        });

        modelBuilder.Entity<Myworkstuff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("myworkstuff");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Myworkstuff1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("myworkstuffs");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<New>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("new");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<New123>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("new123");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Customer).HasMaxLength(30);
            entity.Property(e => e.Salesman).HasMaxLength(30);
        });

        modelBuilder.Entity<NewTable1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("new_table");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newsalesman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newsalesman");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newtab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newtab");

            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasColumnName("purch_amt");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newtable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("newtable");

            entity.Property(e => e.Blockcode).HasColumnName("blockcode");
            entity.Property(e => e.Blockfloor).HasColumnName("blockfloor");
            entity.Property(e => e.Roomnumber).HasColumnName("roomnumber");
            entity.Property(e => e.Roomtype)
                .HasMaxLength(30)
                .HasColumnName("roomtype");
            entity.Property(e => e.Unavailable).HasColumnName("unavailable");
        });

        modelBuilder.Entity<Newyorksalesman>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("newyorksalesman");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newyorksalesman2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("newyorksalesman2");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newyorksalesman3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("newyorksalesman3");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Newyorkstaff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("newyorkstaff");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<NobelWin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nobel_win");

            entity.Property(e => e.Category)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("category");
            entity.Property(e => e.Country)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("country");
            entity.Property(e => e.Subject)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("subject");
            entity.Property(e => e.Winner)
                .HasMaxLength(45)
                .IsFixedLength()
                .HasColumnName("winner");
            entity.Property(e => e.Year).HasColumnName("year");
        });

        modelBuilder.Entity<Norder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("norders");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.Sum).HasColumnName("sum");
        });

        modelBuilder.Entity<Nro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nros");

            entity.Property(e => e.Dos).HasColumnName("dos");
            entity.Property(e => e.Uno).HasColumnName("uno");
        });

        modelBuilder.Entity<Nuevo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nuevo");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<Number>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numbers");

            entity.Property(e => e.One).HasColumnName("one");
            entity.Property(e => e.Three).HasColumnName("three");
            entity.Property(e => e.Two).HasColumnName("two");
        });

        modelBuilder.Entity<Numeri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numeri");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Decimali).HasColumnName("decimali");
            entity.Property(e => e.Id).HasColumnName("id");
        });

        modelBuilder.Entity<Numero>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("numeros");

            entity.Property(e => e.Dos).HasColumnName("dos");
            entity.Property(e => e.Uno).HasColumnName("uno");
        });

        modelBuilder.Entity<Nurse>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("nurse_pkey");

            entity.ToTable("nurse");

            entity.Property(e => e.Employeeid)
                .ValueGeneratedNever()
                .HasColumnName("employeeid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Registered).HasColumnName("registered");
            entity.Property(e => e.Ssn).HasColumnName("ssn");
        });

        modelBuilder.Entity<Odr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("odr");

            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
        });

        modelBuilder.Entity<Oi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("oi");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
        });

        modelBuilder.Entity<OnCall>(entity =>
        {
            entity.HasKey(e => new { e.Nurse, e.Blockfloor, e.Blockcode, e.Oncallstart, e.Oncallend }).HasName("on_call_pkey");

            entity.ToTable("on_call");

            entity.Property(e => e.Nurse).HasColumnName("nurse");
            entity.Property(e => e.Blockfloor).HasColumnName("blockfloor");
            entity.Property(e => e.Blockcode).HasColumnName("blockcode");
            entity.Property(e => e.Oncallstart)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("oncallstart");
            entity.Property(e => e.Oncallend)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("oncallend");

            entity.HasOne(d => d.NurseNavigation).WithMany(p => p.OnCalls)
                .HasForeignKey(d => d.Nurse)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_oncall_nurse_employeeid");

            entity.HasOne(d => d.Block).WithMany(p => p.OnCalls)
                .HasForeignKey(d => new { d.Blockfloor, d.Blockcode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_oncall_block_floor");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrdNo).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("purch_amt");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("customer_id_fk");

            entity.HasOne(d => d.Salesman).WithMany(p => p.Orders)
                .HasForeignKey(d => d.SalesmanId)
                .HasConstraintName("salesman_id_fk2");
        });

        modelBuilder.Entity<Ordersview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ordersview");

            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
            entity.Property(e => e.PurchAmt)
                .HasPrecision(8, 2)
                .HasColumnName("purch_amt");
        });

        modelBuilder.Entity<Orozco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("orozco");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<Partest1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("partest1");

            entity.HasIndex(e => e.OrdNum, "partest1_ord_num_key").IsUnique();

            entity.Property(e => e.AgentCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("agent_code");
            entity.Property(e => e.CustCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("cust_code");
            entity.Property(e => e.OrdAmount)
                .HasPrecision(12, 2)
                .HasColumnName("ord_amount");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNum)
                .HasPrecision(6)
                .HasColumnName("ord_num");
        });

        modelBuilder.Entity<Participant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("participants");

            entity.Property(e => e.PartName)
                .HasMaxLength(20)
                .HasColumnName("part_name");
            entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
        });

        modelBuilder.Entity<Participant1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("participant");

            entity.Property(e => e.PartName)
                .HasMaxLength(20)
                .HasColumnName("part_name");
            entity.Property(e => e.ParticipantId).HasColumnName("participant_id");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Ssn).HasName("patient_pkey");

            entity.ToTable("patient");

            entity.Property(e => e.Ssn)
                .ValueGeneratedNever()
                .HasColumnName("ssn");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Insuranceid).HasColumnName("insuranceid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Pcp).HasColumnName("pcp");
            entity.Property(e => e.Phone).HasColumnName("phone");

            entity.HasOne(d => d.PcpNavigation).WithMany(p => p.Patients)
                .HasForeignKey(d => d.Pcp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");
        });

        modelBuilder.Entity<PenaltyGk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("penalty_gk");

            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayerGk).HasColumnName("player_gk");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.MatchNoNavigation).WithMany()
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.PlayerGkNavigation).WithMany()
                .HasForeignKey(d => d.PlayerGk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_gk_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<PenaltyShootout>(entity =>
        {
            entity.HasKey(e => e.KickId).HasName("penalty_shootout_pkey");

            entity.ToTable("penalty_shootout");

            entity.Property(e => e.KickId).HasColumnName("kick_id");
            entity.Property(e => e.KickNo).HasColumnName("kick_no");
            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.ScoreGoal)
                .HasMaxLength(1)
                .HasColumnName("score_goal");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.MatchNoNavigation).WithMany(p => p.PenaltyShootouts)
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.Player).WithMany(p => p.PenaltyShootouts)
                .HasForeignKey(d => d.PlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_id_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.PenaltyShootouts)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("persons");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Firstname)
                .HasMaxLength(255)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(255)
                .HasColumnName("lastname");
            entity.Property(e => e.Personid).HasColumnName("personid");
        });

        modelBuilder.Entity<Physician>(entity =>
        {
            entity.HasKey(e => e.Employeeid).HasName("physician_pkey");

            entity.ToTable("physician");

            entity.Property(e => e.Employeeid)
                .ValueGeneratedNever()
                .HasColumnName("employeeid");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Position).HasColumnName("position");
            entity.Property(e => e.Ssn).HasColumnName("ssn");
        });

        modelBuilder.Entity<PlayerBooked>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("player_booked");

            entity.Property(e => e.BookingTime).HasColumnName("booking_time");
            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayHalf).HasColumnName("play_half");
            entity.Property(e => e.PlaySchedule)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("play_schedule");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.SentOff)
                .HasMaxLength(1)
                .HasDefaultValueSql("NULL::bpchar")
                .HasColumnName("sent_off");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.MatchNoNavigation).WithMany()
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.Player).WithMany()
                .HasForeignKey(d => d.PlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_id_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<PlayerInOut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("player_in_out");

            entity.Property(e => e.InOut)
                .HasMaxLength(1)
                .HasColumnName("in_out");
            entity.Property(e => e.MatchNo).HasColumnName("match_no");
            entity.Property(e => e.PlayHalf).HasColumnName("play_half");
            entity.Property(e => e.PlaySchedule)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("play_schedule");
            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
            entity.Property(e => e.TimeInOut).HasColumnName("time_in_out");

            entity.HasOne(d => d.MatchNoNavigation).WithMany()
                .HasForeignKey(d => d.MatchNo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("match_no_fkey");

            entity.HasOne(d => d.Player).WithMany()
                .HasForeignKey(d => d.PlayerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("player_id_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<PlayerMast>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("player_mast_pkey");

            entity.ToTable("player_mast");

            entity.Property(e => e.PlayerId).HasColumnName("player_id");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.DtOfBir).HasColumnName("dt_of_bir");
            entity.Property(e => e.JerseyNo).HasColumnName("jersey_no");
            entity.Property(e => e.PlayerName)
                .HasMaxLength(40)
                .HasColumnName("player_name");
            entity.Property(e => e.PlayingClub)
                .HasMaxLength(40)
                .HasColumnName("playing_club");
            entity.Property(e => e.PosiToPlay)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("posi_to_play");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.PosiToPlayNavigation).WithMany(p => p.PlayerMasts)
                .HasForeignKey(d => d.PosiToPlay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("posi_to_play_fkey");

            entity.HasOne(d => d.Team).WithMany(p => p.PlayerMasts)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<PlayingPosition>(entity =>
        {
            entity.HasKey(e => e.PositionId).HasName("playing_position_pkey");

            entity.ToTable("playing_position");

            entity.Property(e => e.PositionId)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("position_id");
            entity.Property(e => e.PositionDesc)
                .HasMaxLength(15)
                .HasColumnName("position_desc");
        });

        modelBuilder.Entity<Prescribe>(entity =>
        {
            entity.HasKey(e => new { e.Physician, e.Patient, e.Medication, e.Date }).HasName("prescribes_pkey");

            entity.ToTable("prescribes");

            entity.Property(e => e.Physician).HasColumnName("physician");
            entity.Property(e => e.Patient).HasColumnName("patient");
            entity.Property(e => e.Medication).HasColumnName("medication");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Appointment).HasColumnName("appointment");
            entity.Property(e => e.Dose).HasColumnName("dose");

            entity.HasOne(d => d.AppointmentNavigation).WithMany(p => p.Prescribes)
                .HasForeignKey(d => d.Appointment)
                .HasConstraintName("fk_appointment_appointmentid");

            entity.HasOne(d => d.MedicationNavigation).WithMany(p => p.Prescribes)
                .HasForeignKey(d => d.Medication)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_medication_code");

            entity.HasOne(d => d.PatientNavigation).WithMany(p => p.Prescribes)
                .HasForeignKey(d => d.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_patient_ssn");

            entity.HasOne(d => d.PhysicianNavigation).WithMany(p => p.Prescribes)
                .HasForeignKey(d => d.Physician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("procedure_pkey");

            entity.ToTable("procedure");

            entity.Property(e => e.Code)
                .ValueGeneratedNever()
                .HasColumnName("code");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rating");

            entity.Property(e => e.MovId).HasColumnName("mov_id");
            entity.Property(e => e.NumORatings).HasColumnName("num_o_ratings");
            entity.Property(e => e.RevId).HasColumnName("rev_id");
            entity.Property(e => e.RevStars)
                .HasPrecision(4, 2)
                .HasColumnName("rev_stars");

            entity.HasOne(d => d.Mov).WithMany()
                .HasForeignKey(d => d.MovId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rating_mov_id_fkey");

            entity.HasOne(d => d.Rev).WithMany()
                .HasForeignKey(d => d.RevId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rating_rev_id_fkey");
        });

        modelBuilder.Entity<RefereeMast>(entity =>
        {
            entity.HasKey(e => e.RefereeId).HasName("referee_mast_pkey");

            entity.ToTable("referee_mast");

            entity.Property(e => e.RefereeId).HasColumnName("referee_id");
            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.RefereeName)
                .HasMaxLength(40)
                .HasColumnName("referee_name");

            entity.HasOne(d => d.Country).WithMany(p => p.RefereeMasts)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("country_id_fkey");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("regions_pkey");

            entity.ToTable("regions");

            entity.Property(e => e.RegionId)
                .HasPrecision(10)
                .HasColumnName("region_id");
            entity.Property(e => e.RegionName)
                .HasMaxLength(25)
                .IsFixedLength()
                .HasColumnName("region_name");
        });

        modelBuilder.Entity<Related>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("related");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
        });

        modelBuilder.Entity<Reviewer>(entity =>
        {
            entity.HasKey(e => e.RevId).HasName("reviewer_pkey");

            entity.ToTable("reviewer");

            entity.Property(e => e.RevId)
                .ValueGeneratedNever()
                .HasColumnName("rev_id");
            entity.Property(e => e.RevName)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("rev_name");
        });

        modelBuilder.Entity<Rightjoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rightjoins");

            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Roomnumber).HasName("room_pkey");

            entity.ToTable("room");

            entity.Property(e => e.Roomnumber)
                .ValueGeneratedNever()
                .HasColumnName("roomnumber");
            entity.Property(e => e.Blockcode).HasColumnName("blockcode");
            entity.Property(e => e.Blockfloor).HasColumnName("blockfloor");
            entity.Property(e => e.Roomtype)
                .HasMaxLength(30)
                .HasColumnName("roomtype");
            entity.Property(e => e.Unavailable).HasColumnName("unavailable");

            entity.HasOne(d => d.Block).WithMany(p => p.Rooms)
                .HasForeignKey(d => new { d.Blockfloor, d.Blockcode })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_room_block_pk");
        });

        modelBuilder.Entity<Salesdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesdetail");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Salesman>(entity =>
        {
            entity.HasKey(e => e.SalesmanId).HasName("salesman_pkey");

            entity.ToTable("salesman");

            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        modelBuilder.Entity<SalesmanDetail1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesman_detail");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<SalesmanDo1304>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("salesman_do1304");

            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasMaxLength(10)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasMaxLength(20)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<SalesmanExample>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesman_example");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<SalesmanNy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesman_ny");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Salesmandetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesmandetail");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Salesown>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("salesown");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<SampleTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sample_table");

            entity.Property(e => e.City)
                .HasMaxLength(20)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Score>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("scores_pkey");

            entity.ToTable("scores");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Score1).HasColumnName("score");
        });

        modelBuilder.Entity<SoccerCity>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("soccer_city_pkey");

            entity.ToTable("soccer_city");

            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.City)
                .HasMaxLength(25)
                .HasColumnName("city");
            entity.Property(e => e.CountryId).HasColumnName("country_id");

            entity.HasOne(d => d.Country).WithMany(p => p.SoccerCities)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("country_id_fkey");
        });

        modelBuilder.Entity<SoccerCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("soccer_country_pkey");

            entity.ToTable("soccer_country");

            entity.Property(e => e.CountryId).HasColumnName("country_id");
            entity.Property(e => e.CountryAbbr)
                .HasMaxLength(4)
                .HasColumnName("country_abbr");
            entity.Property(e => e.CountryName)
                .HasMaxLength(40)
                .HasColumnName("country_name");
        });

        modelBuilder.Entity<SoccerTeam>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("soccer_team");

            entity.Property(e => e.Draw).HasColumnName("draw");
            entity.Property(e => e.GoalAgnst).HasColumnName("goal_agnst");
            entity.Property(e => e.GoalDiff).HasColumnName("goal_diff");
            entity.Property(e => e.GoalFor).HasColumnName("goal_for");
            entity.Property(e => e.GroupPosition).HasColumnName("group_position");
            entity.Property(e => e.Lost).HasColumnName("lost");
            entity.Property(e => e.MatchPlayed).HasColumnName("match_played");
            entity.Property(e => e.Points).HasColumnName("points");
            entity.Property(e => e.TeamGroup)
                .HasMaxLength(1)
                .HasColumnName("team_group");
            entity.Property(e => e.TeamId).HasColumnName("team_id");
            entity.Property(e => e.Won).HasColumnName("won");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<SoccerVenue>(entity =>
        {
            entity.HasKey(e => e.VenueId).HasName("soccer_venue_pkey");

            entity.ToTable("soccer_venue");

            entity.Property(e => e.VenueId).HasColumnName("venue_id");
            entity.Property(e => e.AudCapacity).HasColumnName("aud_capacity");
            entity.Property(e => e.CityId).HasColumnName("city_id");
            entity.Property(e => e.VenueName)
                .HasMaxLength(30)
                .HasColumnName("venue_name");

            entity.HasOne(d => d.City).WithMany(p => p.SoccerVenues)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("city_id_fkey");
        });

        modelBuilder.Entity<Statement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("statements");

            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Stay>(entity =>
        {
            entity.HasKey(e => e.Stayid).HasName("stay_pkey");

            entity.ToTable("stay");

            entity.Property(e => e.Stayid)
                .ValueGeneratedNever()
                .HasColumnName("stayid");
            entity.Property(e => e.EndTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("end_time");
            entity.Property(e => e.Patient).HasColumnName("patient");
            entity.Property(e => e.Room).HasColumnName("room");
            entity.Property(e => e.StartTime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("start_time");

            entity.HasOne(d => d.PatientNavigation).WithMany(p => p.Stays)
                .HasForeignKey(d => d.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_patient_ssn");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.Stays)
                .HasForeignKey(d => d.Room)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_room_number");
        });

        modelBuilder.Entity<revision.Models.String>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("string");

            entity.Property(e => e.Text).HasColumnName("text");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("student");

            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Roll).HasColumnName("roll");
        });

        modelBuilder.Entity<Student1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("student1");

            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Roll).HasColumnName("roll");
        });

        modelBuilder.Entity<Sybba>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sybba");

            entity.HasIndex(e => e.OrdNum, "sybba_ord_num_key").IsUnique();

            entity.Property(e => e.AgentCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("agent_code");
            entity.Property(e => e.CustCode)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("cust_code");
            entity.Property(e => e.OrdAmount)
                .HasPrecision(12, 2)
                .HasColumnName("ord_amount");
            entity.Property(e => e.OrdDate).HasColumnName("ord_date");
            entity.Property(e => e.OrdNum)
                .HasPrecision(6)
                .HasColumnName("ord_num");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("table1");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .HasColumnName("Customer Name");
            entity.Property(e => e.Salesman).HasMaxLength(30);
        });

        modelBuilder.Entity<TeamCoach>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("team_coaches");

            entity.Property(e => e.CoachId).HasColumnName("coach_id");
            entity.Property(e => e.TeamId).HasColumnName("team_id");

            entity.HasOne(d => d.Coach).WithMany()
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("coach_id_fkey");

            entity.HasOne(d => d.Team).WithMany()
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("team_id_fkey");
        });

        modelBuilder.Entity<Temp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Tempa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempa");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Tempcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempcustomer");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Temphi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temphi");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Tempp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempp");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Tempp11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempp11");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
            entity.Property(e => e.Grade)
                .HasPrecision(3)
                .HasColumnName("grade");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Tempsalesman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tempsalesman");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Commission)
                .HasPrecision(5, 2)
                .HasColumnName("commission");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Test>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("test");

            entity.Property(e => e.X).HasColumnName("x");
        });

        modelBuilder.Entity<Teste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("teste");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Testtable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("testtable", tb => tb.HasComment("a temporary table for some queries "));

            entity.Property(e => e.Col1)
                .HasMaxLength(30)
                .HasColumnName("col1");
        });

        modelBuilder.Entity<Testtesing>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("testtesing");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Testtest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("testtest");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<TrainedIn>(entity =>
        {
            entity.HasKey(e => new { e.Physician, e.Treatment }).HasName("trained_in_pkey");

            entity.ToTable("trained_in");

            entity.Property(e => e.Physician).HasColumnName("physician");
            entity.Property(e => e.Treatment).HasColumnName("treatment");
            entity.Property(e => e.Certificationdate).HasColumnName("certificationdate");
            entity.Property(e => e.Certificationexpires).HasColumnName("certificationexpires");

            entity.HasOne(d => d.PhysicianNavigation).WithMany(p => p.TrainedIns)
                .HasForeignKey(d => d.Physician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");

            entity.HasOne(d => d.TreatmentNavigation).WithMany(p => p.TrainedIns)
                .HasForeignKey(d => d.Treatment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedure_code");
        });

        modelBuilder.Entity<Trentum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("trenta");

            entity.Property(e => e.Numeri).HasColumnName("numeri");
        });

        modelBuilder.Entity<Tt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tt");

            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Undergo>(entity =>
        {
            entity.HasKey(e => new { e.Patient, e.Procedure, e.Stay, e.Date }).HasName("undergoes_pkey");

            entity.ToTable("undergoes");

            entity.Property(e => e.Patient).HasColumnName("patient");
            entity.Property(e => e.Procedure).HasColumnName("procedure");
            entity.Property(e => e.Stay).HasColumnName("stay");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Assistingnurse).HasColumnName("assistingnurse");
            entity.Property(e => e.Physician).HasColumnName("physician");

            entity.HasOne(d => d.AssistingnurseNavigation).WithMany(p => p.Undergos)
                .HasForeignKey(d => d.Assistingnurse)
                .HasConstraintName("fk_nurse_employeeid");

            entity.HasOne(d => d.PatientNavigation).WithMany(p => p.Undergos)
                .HasForeignKey(d => d.Patient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_patient_ssn");

            entity.HasOne(d => d.PhysicianNavigation).WithMany(p => p.Undergos)
                .HasForeignKey(d => d.Physician)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_physician_employeeid");

            entity.HasOne(d => d.ProcedureNavigation).WithMany(p => p.Undergos)
                .HasForeignKey(d => d.Procedure)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_procedure_code");

            entity.HasOne(d => d.StayNavigation).WithMany(p => p.Undergos)
                .HasForeignKey(d => d.Stay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stay_stayid");
        });

        modelBuilder.Entity<V1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v1");

            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.OrdNo)
                .HasPrecision(5)
                .HasColumnName("ord_no");
        });

        modelBuilder.Entity<View>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view");

            entity.Property(e => e.City)
                .HasMaxLength(15)
                .HasColumnName("city");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
            entity.Property(e => e.SalesmanId)
                .HasPrecision(5)
                .HasColumnName("salesman_id");
        });

        modelBuilder.Entity<Vowl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("vowl");

            entity.Property(e => e.CustName)
                .HasMaxLength(30)
                .HasColumnName("cust_name");
            entity.Property(e => e.Substring).HasColumnName("substring");
        });

        modelBuilder.Entity<Zebra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("zebras_pkey");

            entity.ToTable("zebras");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("now()")
                .HasColumnName("date");
            entity.Property(e => e.Score).HasColumnName("score");
        });

        modelBuilder.Entity<Zz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("zz");

            entity.Property(e => e.Avg).HasColumnName("avg");
            entity.Property(e => e.CustomerId)
                .HasPrecision(5)
                .HasColumnName("customer_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
