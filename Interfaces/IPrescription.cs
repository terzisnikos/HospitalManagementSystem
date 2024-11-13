using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Interfaces
{
    public interface IPrescription
    {
        Prescription GetPrescriptionByAppointmentId(int appointmentId);
        void AddPrescription(Prescription prescription, int appointmentId);
        void UpdatePrescription(Prescription prescription);
    }
}
