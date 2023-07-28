using System.Threading.Tasks;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Manager
{
    public interface IPatientManager
    {
        Task<int> AddPatient(Patient patient);
    }
}
