using System.Collections.Generic;

namespace HospitalManagementSystem.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        public List<Medication> Medications { get; set; } = new List<Medication>();
    }
}
