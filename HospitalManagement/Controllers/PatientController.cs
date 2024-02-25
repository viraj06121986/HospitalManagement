using HospitalManagement.Models.UserRole;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HospitalManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : Controller
    {
        [HttpGet("Id")]
        public JsonResult Index(int Id)
        {
            var options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = null;
            List<Patient> patients = new List<Patient> { 
                new Patient { Id = 101, FirstName = "Viraj", DateOfBirth = DateOnly.ParseExact("06/12/1986","dd/mm/yyyy")}
            };
            return Json(patients,options);
        }

        [HttpGet("Name")]
        public JsonResult PatientWithName(string Name)
        {
            var options = new JsonSerializerOptions();
            options.PropertyNamingPolicy = null;
            List<Patient> patients = new List<Patient> {
                new Patient { Id = 101, FirstName = "Viraj", DateOfBirth = DateOnly.ParseExact("06/12/1986","dd/mm/yyyy")}
            };
            return Json(patients, options);
        }
    }
}
