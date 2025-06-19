using Microsoft.EntityFrameworkCore;

namespace DoctorsTaskithImprovements.Data_Access
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Models.Appointment> Appointments { get; set; } = null!;
        public DbSet<Models.Doctor> Doctors { get; set; } = null!;
        public DbSet<Models.Specialization> Specializations { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DoctorWithImprove; Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        }
    }
}
