using System;
using System.Collections.Generic;
using HospitalManagementSystem.Models;
using HospitalManagementSystem.Interfaces;


// Sample data and service implementations
var patientService = new Patient();
var doctorService = new Doctor();
var appointmentService = new Appointment();
var prescriptionService = new Prescription();

// Create some doctors
var doctor1 = new Doctor { Id = 1, Name = "Dr. Smith", Specialty = "Cardiology" };
var doctor2 = new Doctor { Id = 2, Name = "Dr. Johnson", Specialty = "Pediatrics" };

// Create some patients
var patient1 = new Patient { Id = 1, Name = "Alice Johnson", DateOfBirth = new DateTime(1990, 5, 20) };
var patient2 = new Patient { Id = 2, Name = "Bob Smith", DateOfBirth = new DateTime(1985, 3, 15) };

// Schedule an appointment for a patient
var appointment1 = new Appointment
{
    Id = 1,
    Date = DateTime.Now.AddDays(1),
    Status = AppointmentStatus.Scheduled,
    Patient = patient1,
    Doctor = doctor1
};

// Create a prescription for the appointment
var prescription = new Prescription();
prescription.Medications.Add(new Medication
{
    Name = "Lisinopril",
    Dosage = "10mg",
    Frequency = "Once a day",
    Duration = "30 days"
});

