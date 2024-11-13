using System.Collections.Generic;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Interfaces
{
    public interface IAppointment
    {
        Appointment GetAppointmentById(int id);
        IEnumerable<Appointment> GetAppointmentsByPatientId(int patientId);
        IEnumerable<Appointment> GetAppointmentsByDoctorId(int doctorId);
        void ScheduleAppointment(Appointment appointment);
        void UpdateAppointment(Appointment appointment);
        void CancelAppointment(int id);
    }
}
