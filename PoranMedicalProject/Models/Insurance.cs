﻿namespace PoranMedicalProject.Models
{
    public class Insurance
    {
        public int InsuranceID { get; set; }
        public string InsuranceProvider { get; set; }
        public string PolicyNumber { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
