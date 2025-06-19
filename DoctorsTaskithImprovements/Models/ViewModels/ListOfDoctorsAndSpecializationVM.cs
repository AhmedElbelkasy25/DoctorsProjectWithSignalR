using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoctorsTaskithImprovements.Models.ViewModels
{
    public class ListOfDoctorsAndSpecializationVM
    {
        public List<Doctor> Doctors { get; set; } = new List<Doctor>();
        public List<SelectListItem> Specialization { get; set; } = new List<SelectListItem>();
        public string DocName { get; set; } = string.Empty;
        public int SpecializationId { get; set; }
    }
}
