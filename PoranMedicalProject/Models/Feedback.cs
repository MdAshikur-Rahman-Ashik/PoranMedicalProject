﻿namespace PoranMedicalProject.Models
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int PatientID { get; set; }
        public int HospitalID { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }  // e.g., from 1 to 5 stars
        public Patient Patient { get; set; }
        public Hospital Hospital { get; set; }
    }
}
