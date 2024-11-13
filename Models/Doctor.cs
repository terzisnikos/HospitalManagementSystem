using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        // Computed Property to get the count of unique patients
        public int PatientCount => Appointments.Select(a => a.Patient.Id).Distinct().Count();
    }
}
