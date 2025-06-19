using DoctorsTaskithImprovements.Data_Access;
using DoctorsTaskithImprovements.Models;
using DoctorsTaskithImprovements.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DoctorsTaskithImprovements.Controllers
{
    public class DoctorController : Controller
    {
        private readonly ApplicationDbContext _dbContext = new ApplicationDbContext();
        public IActionResult Index(string? DocName = null , int SpecializationId = 0)
        {
            IQueryable<Doctor> doctors = _dbContext.Doctors
                .Include(d => d.Specialization);
                
            if(DocName != null)
            {
                doctors = doctors.Where(d => d.Name.Contains(DocName));
            }

            if (SpecializationId > 0)
            {
                doctors = doctors.Where(d => d.SpecializationId == SpecializationId);
            }
            var allSpecialization = _dbContext.Specializations.Select(e=> new SelectListItem() 
            {Text =e.Name , Value = e.Id.ToString()}).ToList();
            var model = new ListOfDoctorsAndSpecializationVM() {  Doctors=doctors.ToList(),
            Specialization = allSpecialization
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult FilterDoctors(string? docName, int specializationId)
        {
            var doctors = _dbContext.Doctors.Include(d => d.Specialization).AsQueryable();

            if (!string.IsNullOrEmpty(docName))
                doctors = doctors.Where(d => d.Name.Contains(docName));

            if (specializationId > 0)
                doctors = doctors.Where(d => d.SpecializationId == specializationId);

            var result = doctors.Select(d => new {
                d.Name,
                d.Img,
                Specialization = d.Specialization.Name
            }).ToList();

            return Json(result);
        }
    }
}
