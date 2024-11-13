using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        // Computed Property to get total number of appointments for the patient
        public int TotalAppointments => Appointments.Count;
    }
}
