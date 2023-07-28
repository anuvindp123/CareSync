using Microsoft.EntityFrameworkCore;
using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Models
{
    public class Wa_DbContext : DbContext
    {
        internal object vehicles;

        public Wa_DbContext(DbContextOptions<Wa_DbContext> options) : base(options)
        {

        }

        public DbSet<Product> products { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<User> users { get; set; }


        //CareSync
        public DbSet<Patient> patients { get; set; }
        public DbSet<Hospital> hospitals { get; set; }
        public DbSet<DoctorPatientHospitalLinks> doctorPatientHospitalLinks { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Diseases> diseases { get; set; }
        public DbSet<Consultation> consultations { get; set; }
        public DbSet<DataViewLogs> dataViewLogs { get; set; }
        public DbSet<PatientDiseases> patientDiseases { get; set; }
        public DbSet<ConsulationDiseases> consulationDiseases { get; set; }
        public DbSet<ConsulationMedications> consulationMedications { get; set; }
        public DbSet<Medications> medications { get; set; }
        public DbSet<SpecialDate> SpecialDates { get; set; }
        public DbSet<ConsultationSpecialDates> consultationSpecialDates { get; set; }
        
        public DbSet<DoctorHospitalsLink> doctorHospitalsLink { get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<HospitalDepartmentsLink> hospitalDepartmentsLink { get; set; }


    }
}
