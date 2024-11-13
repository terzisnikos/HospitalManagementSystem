using System;

namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public AppointmentStatus Status { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Prescription Prescription { get; set; }

        // Method to change the status of the appointment
        public void ChangeStatus(AppointmentStatus newStatus)
        {
            Status = newStatus;
        }
    }
}
