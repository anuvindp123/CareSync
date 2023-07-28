using System.Threading.Tasks;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.Requests;
using WebAPI_Wa.Repositories;

namespace WebAPI_Wa.Manager
{
    public class PatientManager : IPatientManager
    {
        private readonly IPatientRepository _patientRepository;

        public PatientManager(IPatientRepository patientRepository)
        {
            _patientRepository= patientRepository;
        }
        public async Task<int> AddPatient(Patient patient)
        {

            var ok = _patientRepository.AddPatient(patient);
            return ok.Id;
        }
    }
}
