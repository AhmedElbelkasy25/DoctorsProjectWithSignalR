using DoctorsTaskithImprovements.Data_Access;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace DoctorsTaskithImprovements.Utilities
{
    public class RealTimeHub : Hub
    {
        private readonly ApplicationDbContext _context = new();

        

        public async Task FilterDoctorsClientToServer(string docName, int specializationId)
        {
            var doctors = _context.Doctors.Include(d => d.Specialization).AsQueryable();

            if (!string.IsNullOrEmpty(docName))
                doctors = doctors.Where(d => d.Name.Contains(docName));

            if (specializationId > 0)
                doctors = doctors.Where(d => d.SpecializationId == specializationId);

            var result = doctors.Select(d => new
            {
                Id = d.Id,
                name = d.Name,
                img = d.Img,
                specialization = d.Specialization.Name
            }).ToList();

            await Clients.Caller.SendAsync("ReceiveFilteredDoctors", result);
        }
    }
}

