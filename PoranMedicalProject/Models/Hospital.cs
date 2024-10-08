﻿namespace PoranMedicalProject.Models
{
    public class Hospital
    {
        public int HospitalID { get; set; }
        public string HospitalName { get; set; }
        public string Location { get; set; }

        // One Hospital can have many Appointments
        public ICollection<Appointment> Appointments { get; set; }

        // Many Hospitals can be part of many TreatmentPlans (many-to-many)
        public ICollection<TreatmentPlanHospital> TreatmentPlanHospitals { get; set; }
    }
}