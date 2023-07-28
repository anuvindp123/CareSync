using System.Threading.Tasks;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Repositories
{
    public interface IPatientRepository
    {
        Task<int> AddPatient(Patient patient);
    }
}
