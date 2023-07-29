using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI_Wa.Dto.Request;
using WebAPI_Wa.Dto.Response;
using WebAPI_Wa.Models;
using WebAPI_Wa.Models.CareSync;

namespace WebAPI_Wa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {

        private readonly Wa_DbContext _context;
        public HospitalController(Wa_DbContext context)
        {
            _context = context;
        }

        [HttpPost("SaveHospital")]
        public async Task<ActionResult> SaveHospital(AddHospitalRequest addHospitalRequest)
        {
            Hospital hospital = new Hospital();
            hospital.HospitalName = addHospitalRequest.HospitalName;
            hospital.RegistrationNumber = addHospitalRequest.RegistrationNumber;
            hospital.ContactNumber = addHospitalRequest.ContactNumber;
            hospital.Email = addHospitalRequest.Email;
            hospital.UserName = addHospitalRequest.UserName;
            hospital.Password = addHospitalRequest.Password;
            _context.hospitals.Add(hospital);
            _context.SaveChanges();
            return Ok(true);
        }


        [HttpPost("SaveDepartment")]
        public async Task<ActionResult> SaveDepartment(DeparmentRequest deparmentRequest)
        {
            Department department = new Department();
            department.Name = deparmentRequest.Name;
            department.Description = deparmentRequest.Description;
            _context.department.Add(department);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost("SaveHospitalDepartmentLink")]
        public async Task<ActionResult> SaveHospitalDepartmentLink(HospitalDepartmentsRequest HospitalDepartmentsRequest)
        {
            HospitalDepartmentsLink obj = new HospitalDepartmentsLink();
            obj.hospitalId = HospitalDepartmentsRequest.hospitalId;
            obj.departmentId = HospitalDepartmentsRequest.departmentId;
            _context.hospitalDepartmentsLink.Add(obj);
            _context.SaveChanges();
            return Ok(true);
        }
        [HttpPost("GetAllDepartmentByHospital")]
        public async Task<ActionResult> SaveHospitalDepartmentLink(int hospitalId)
        {
            var hospialLink = _context.hospitalDepartmentsLink.Where(x => x.hospitalId == hospitalId).ToList();
            List<GetAllDeptsByHospitalResponse> list = new List<GetAllDeptsByHospitalResponse>();
            if (hospialLink != null)
            {
                foreach (var hospital in hospialLink)
                {
                    var data = _context.department.Where(x => x.Id == hospital.departmentId).FirstOrDefault();
                    GetAllDeptsByHospitalResponse obj = new GetAllDeptsByHospitalResponse();
                    obj.Id = data.Id;
                    obj.DeptName = data.Name;
                    list.Add(obj);
                }
            }
            return Ok(list);
        }
        [HttpPost("SaveDisease")]
        public async Task<ActionResult> SaveDisease(DiseasesRequest diseasesRequest)
        {
            Diseases obj = new Diseases();
            obj.Name = diseasesRequest.Name;
            obj.Type = diseasesRequest.Type;
            _context.diseases.Add(obj);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost("GetAllDisease")]
        public async Task<ActionResult> GetAllDisease()
        {
            return Ok(_context.diseases.ToList());
        }
    }
}
