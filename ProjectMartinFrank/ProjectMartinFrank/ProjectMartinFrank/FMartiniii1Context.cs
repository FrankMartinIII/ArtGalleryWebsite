using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace ProjectMartinFrank
{
    public partial class FMartiniii1Context : DbContext
    {
        //public FMartiniii1Context()
        //{
        //}

        public FMartiniii1Context(DbContextOptions<FMartiniii1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblArt> TblArts { get; set; }
        public virtual DbSet<TblArtist> TblArtists { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<VwArtandArtist> VwArtandArtists { get; set; }
        public virtual DbSet<SpArtistFavArt> SpArtistFavArts { get; set; }
        public virtual DbSet<SpUserFavArt> SpUserFavArts { get; set; }
        public virtual DbSet<SpArtistList> SpArtistLists { get; set; }
        public IConfiguration myconfig { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(myconfig.GetConnectionString("MartinConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblArt>(entity =>
            {
                entity.HasKey(e => e.ArtId)
                    .HasName("PK__tblArt__5A460B41B34BCB7D");

                entity.ToTable("tblArt");

                entity.Property(e => e.ArtId).HasColumnName("artID");

                entity.Property(e => e.ArtDate)
                    .HasColumnType("date")
                    .HasColumnName("artDate");

                entity.Property(e => e.ArtImg)
                    .HasMaxLength(100)
                    .HasColumnName("artImg");

                entity.Property(e => e.ArtPrice).HasColumnName("artPrice");

                entity.Property(e => e.ArtTitle)
                    .HasMaxLength(100)
                    .HasColumnName("artTitle");

                entity.Property(e => e.ArtType)
                    .HasMaxLength(50)
                    .HasColumnName("artType");

                entity.Property(e => e.ArtistId).HasColumnName("artistID");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.TblArts)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK__tblArt__artistID__5EBF139D");
            });

            modelBuilder.Entity<TblArtist>(entity =>
            {
                entity.HasKey(e => e.ArtistId)
                    .HasName("PK__tblArtis__4F439367263B6D89");

                entity.ToTable("tblArtist");

                entity.Property(e => e.ArtistId).HasColumnName("artistID");

                entity.Property(e => e.ArtistDob)
                    .HasColumnType("date")
                    .HasColumnName("artistDOB");

                entity.Property(e => e.ArtistEmail)
                    .HasMaxLength(25)
                    .HasColumnName("artistEmail");

                entity.Property(e => e.ArtistFavTypeArt)
                    .HasMaxLength(50)
                    .HasColumnName("artistFavTypeArt");

                entity.Property(e => e.ArtistFname)
                    .HasMaxLength(25)
                    .HasColumnName("artistFName");

                entity.Property(e => e.ArtistLname)
                    .HasMaxLength(25)
                    .HasColumnName("artistLName");
            });

            modelBuilder.Entity<TblCar>(entity =>
            {
                entity.HasKey(e => e.CarId);

                entity.ToTable("tblCars");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.CarYear)
                    .HasMaxLength(4)
                    .HasColumnName("carYear")
                    .IsFixedLength(true);

                entity.Property(e => e.Color)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.LicensePlate)
                    .HasMaxLength(15)
                    .HasColumnName("licensePlate")
                    .IsFixedLength(true);

                entity.Property(e => e.Make)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("make");

                entity.Property(e => e.Model)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("model");
            });

            modelBuilder.Entity<TblDriver>(entity =>
            {
                entity.HasKey(e => e.DriverId);

                entity.ToTable("tblDriver");

                entity.Property(e => e.DriverId)
                    .ValueGeneratedNever()
                    .HasColumnName("driverID");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .HasColumnName("city");

                entity.Property(e => e.Dname)
                    .HasMaxLength(25)
                    .HasColumnName("dname");

                entity.Property(e => e.Dstate)
                    .HasMaxLength(2)
                    .HasColumnName("dstate")
                    .IsFixedLength(true);

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<TblFaculty>(entity =>
            {
                entity.HasKey(e => e.FacultyId)
                    .HasName("PK__tblFacul__DBBF6FD1DC73EEE5");

                entity.ToTable("tblFaculty");

                entity.Property(e => e.FacultyId).HasColumnName("facultyID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Dept)
                    .HasMaxLength(25)
                    .HasColumnName("dept");

                entity.Property(e => e.FacGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("facGender")
                    .IsFixedLength(true);

                entity.Property(e => e.FacName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("facName");

                entity.Property(e => e.HireDate)
                    .HasColumnType("date")
                    .HasColumnName("hireDate");

                entity.Property(e => e.Salary).HasColumnName("salary");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblFaculties)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__tblFacult__carID__2B3F6F97");
            });

            modelBuilder.Entity<TblIncident>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("PK__tblIncid__06A5D76180B8ED60");

                entity.ToTable("tblIncidents");

                entity.Property(e => e.IncidentId).HasColumnName("incidentID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.FacultyId).HasColumnName("facultyID");

                entity.Property(e => e.IncidentDate)
                    .HasColumnType("date")
                    .HasColumnName("incidentDate");

                entity.Property(e => e.IncidentDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("incidentDesc");

                entity.Property(e => e.PId).HasColumnName("pID");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__tblIncide__carID__36B12243");

                entity.HasOne(d => d.Faculty)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.FacultyId)
                    .HasConstraintName("FK__tblIncide__facul__34C8D9D1");

                entity.HasOne(d => d.PIdNavigation)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.PId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblIncident__pID__35BCFE0A");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.TblIncidents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__tblIncide__stude__33D4B598");
            });

            modelBuilder.Entity<TblOwner>(entity =>
            {
                entity.HasKey(e => e.OwnerId)
                    .HasName("PK__tblOwner__7E4B716CDD32FAD3");

                entity.ToTable("tblOwner");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.OwnerAddress)
                    .HasMaxLength(40)
                    .HasColumnName("ownerAddress");

                entity.Property(e => e.OwnerFirstName)
                    .HasMaxLength(25)
                    .HasColumnName("ownerFirstName");

                entity.Property(e => e.OwnerLastName)
                    .HasMaxLength(25)
                    .HasColumnName("ownerLastName");

                entity.Property(e => e.OwnerPhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("ownerPhoneNumber");

                entity.Property(e => e.OwnerState)
                    .HasMaxLength(2)
                    .HasColumnName("ownerState")
                    .IsFixedLength(true);

                entity.Property(e => e.OwnerTown)
                    .HasMaxLength(25)
                    .HasColumnName("ownerTown");
            });

            modelBuilder.Entity<TblPet>(entity =>
            {
                entity.HasKey(e => e.PetId)
                    .HasName("PK__tblPet__DDF85059F5AE52D1");

                entity.ToTable("tblPet");

                entity.Property(e => e.PetId).HasColumnName("petID");

                entity.Property(e => e.OwnerId).HasColumnName("ownerID");

                entity.Property(e => e.PetBreed)
                    .HasMaxLength(25)
                    .HasColumnName("petBreed");

                entity.Property(e => e.PetDob)
                    .HasColumnType("date")
                    .HasColumnName("petDOB");

                entity.Property(e => e.PetName)
                    .HasMaxLength(25)
                    .HasColumnName("petName");

                entity.Property(e => e.PetNotes)
                    .HasMaxLength(50)
                    .HasColumnName("petNotes");

                entity.Property(e => e.PetPrice).HasColumnName("petPrice");

                entity.Property(e => e.PetSex)
                    .HasMaxLength(2)
                    .HasColumnName("petSex")
                    .IsFixedLength(true);

                entity.Property(e => e.PetType)
                    .HasMaxLength(25)
                    .HasColumnName("petType");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.TblPets)
                    .HasForeignKey(d => d.OwnerId)
                    .HasConstraintName("FK__tblPet__ownerID__5629CD9C");
            });

            modelBuilder.Entity<TblPolice>(entity =>
            {
                entity.HasKey(e => e.PoliceId);

                entity.ToTable("tblPolice");

                entity.Property(e => e.PoliceId)
                    .ValueGeneratedNever()
                    .HasColumnName("policeID");

                entity.Property(e => e.Pname)
                    .HasMaxLength(25)
                    .HasColumnName("pname");
            });

            modelBuilder.Entity<TblPublicSafety>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PK__tblPubli__DD36D5021236B093");

                entity.ToTable("tblPublicSafety");

                entity.Property(e => e.PId).HasColumnName("pID");

                entity.Property(e => e.PBadgeNo)
                    .HasMaxLength(4)
                    .HasColumnName("pBadgeNo")
                    .IsFixedLength(true);

                entity.Property(e => e.PGender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("pGender")
                    .IsFixedLength(true);

                entity.Property(e => e.PName)
                    .HasMaxLength(25)
                    .HasColumnName("pName");
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentId)
                    .HasName("PK__tblStude__4D11D65CD33A65F7");

                entity.ToTable("tblStudent");

                entity.Property(e => e.StudentId).HasColumnName("studentID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Major)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("major");

                entity.Property(e => e.SName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("sName");

                entity.Property(e => e.Sgender)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sgender")
                    .IsFixedLength(true);

                entity.Property(e => e.SlName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("slName");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblStudents)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__tblStuden__carID__300424B4");
            });

            modelBuilder.Entity<TblTest>(entity =>
            {
                entity.HasKey(e => e.ColorimgId)
                    .HasName("PK__tblTest__BC7B61418B75BBF4");

                entity.ToTable("tblTest");

                entity.Property(e => e.ColorimgId).HasColumnName("colorimgID");

                entity.Property(e => e.CarId).HasColumnName("carID");

                entity.Property(e => e.Imgvarname)
                    .HasMaxLength(25)
                    .HasColumnName("imgvarname");

                entity.Property(e => e.Randomtext)
                    .HasMaxLength(25)
                    .HasColumnName("randomtext");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.TblTests)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK__tblTest__carID__59063A47");
            });

            modelBuilder.Entity<TblTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK__tblTicke__3333C670BF07FCC9");

                entity.ToTable("tblTicket");

                entity.Property(e => e.TicketId).HasColumnName("ticketID");

                entity.Property(e => e.DriverId).HasColumnName("driverID");

                entity.Property(e => e.PoliceId).HasColumnName("policeID");

                entity.Property(e => e.TicketDate)
                    .HasColumnType("date")
                    .HasColumnName("ticketDate");

                entity.Property(e => e.ViolationId).HasColumnName("violationID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK__tblTicket__drive__44FF419A");

                entity.HasOne(d => d.Police)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.PoliceId)
                    .HasConstraintName("FK__tblTicket__polic__440B1D61");

                entity.HasOne(d => d.Violation)
                    .WithMany(p => p.TblTickets)
                    .HasForeignKey(d => d.ViolationId)
                    .HasConstraintName("FK__tblTicket__viola__4316F928");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__CB9A1CDF4503484C");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UserDob)
                    .HasColumnType("date")
                    .HasColumnName("userDOB");

                entity.Property(e => e.UserEmail)
                    .HasMaxLength(25)
                    .HasColumnName("userEMail");

                entity.Property(e => e.UserFavTypeArt)
                    .HasMaxLength(50)
                    .HasColumnName("userFavTypeArt");

                entity.Property(e => e.UserFname)
                    .HasMaxLength(25)
                    .HasColumnName("userFName");

                entity.Property(e => e.UserLname)
                    .HasMaxLength(25)
                    .HasColumnName("userLName");
            });

            modelBuilder.Entity<TblViolation>(entity =>
            {
                entity.HasKey(e => e.ViolationId);

                entity.ToTable("tblViolation");

                entity.Property(e => e.ViolationId)
                    .ValueGeneratedNever()
                    .HasColumnName("violationID");

                entity.Property(e => e.Fine).HasColumnName("fine");

                entity.Property(e => e.Violation)
                    .HasMaxLength(25)
                    .HasColumnName("violation");
            });

            modelBuilder.Entity<VsCarImage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vsCarImages");

                entity.Property(e => e.Imgvarname)
                    .HasMaxLength(25)
                    .HasColumnName("imgvarname");

                entity.Property(e => e.Make)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("make");

                entity.Property(e => e.Model)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("model");

                entity.Property(e => e.RandomText)
                    .HasMaxLength(25)
                    .HasColumnName("randomText");
            });

            modelBuilder.Entity<VwArtandArtist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VwArtandArtist");

                entity.Property(e => e.ArtDate)
                    .HasColumnType("date")
                    .HasColumnName("artDate");

                entity.Property(e => e.ArtImg)
                    .HasMaxLength(100)
                    .HasColumnName("artImg");

                entity.Property(e => e.ArtPrice).HasColumnName("artPrice");

                entity.Property(e => e.ArtTitle)
                    .HasMaxLength(100)
                    .HasColumnName("artTitle");

                entity.Property(e => e.ArtType)
                    .HasMaxLength(50)
                    .HasColumnName("artType");

                entity.Property(e => e.ArtistFname)
                    .HasMaxLength(25)
                    .HasColumnName("artistFName");

                entity.Property(e => e.ArtistLname)
                    .HasMaxLength(25)
                    .HasColumnName("artistLName");
            });

            modelBuilder.Entity<SpUserFavArt>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("SpUserFavArt");
                entity.Property(e => e.userFavTypeArt).HasColumnName("userFavTypeArt");
                entity.Property(e => e.CountFavoriteArtTypeUsers).HasColumnName("CountFavoriteArtTypeUsers");
            });
            modelBuilder.Entity<SpArtistFavArt>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("SpArtistFavArt");
                entity.Property(e => e.artistFavTypeArt).HasColumnName("artistFavTypeArt");
                entity.Property(e => e.CountFavoriteArtTypeArtists).HasColumnName("CountFavoriteArtTypeArtists");
            });

            modelBuilder.Entity<SpArtistList>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("SpArtistList");
                entity.Property(e => e.artistID).HasColumnName("artistID");
                entity.Property(e => e.artistFName).HasColumnName("artistFName");
                entity.Property(e => e.artistLName).HasColumnName("artistLName");
                entity.Property(e => e.artistDOB)
                    .HasColumnType("date")
                    .HasColumnName("artistDOB");
                entity.Property(e => e.artistEmail).HasColumnName("artistEmail");
                entity.Property(e => e.AmountArtUploaded).HasColumnName("AmountArtUploaded");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
