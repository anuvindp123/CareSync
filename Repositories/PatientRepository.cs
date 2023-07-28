using WebAPI_Wa.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebAPI_Wa.Repositories
{
    
    
    public class PatientRepository : IPatientRepository
    {
        private readonly Wa_DbContext _context;
        public PatientRepository(Wa_DbContext context)
        {
            _context = context;
        }
        public async Task<int> AddPatient(Patient patient)
        {
            var ok = _context.patient.Add(patient);
            _context.SaveChanges();
            return ok.Entity.Id;    
        }
    }
}
