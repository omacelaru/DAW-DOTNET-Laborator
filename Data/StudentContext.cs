using DAW_DOTNET_Laborator.Models;
using DAW_DOTNET_Laborator.Models.Many_to_Many;
using DAW_DOTNET_Laborator.Models.One_to_Many;
using DAW_DOTNET_Laborator.Models.One_to_One;
using Microsoft.EntityFrameworkCore;

namespace DAW_DOTNET_Laborator.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Pen> Pens { get; set; }
        public DbSet<Learn> Learns { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Address)
                .WithOne(a => a.Student)
                .HasForeignKey<Address>(a => a.StudentId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.pens)
                .WithOne(p => p.Student)
                .HasForeignKey(p => p.StudentId);


            modelBuilder.Entity<Learn>().HasKey(l => new {l.StudentId, l.SubjectId});
            modelBuilder.Entity<Learn>()
                .HasOne(l => l.Student)
                .WithMany(s => s.learns)
                .HasForeignKey(l => l.StudentId);
            modelBuilder.Entity<Learn>()
                .HasOne(l => l.Subject)
                .WithMany(s => s.learns)
                .HasForeignKey(l => l.SubjectId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
