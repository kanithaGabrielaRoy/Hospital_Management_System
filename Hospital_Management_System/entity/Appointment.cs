using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.entity
{
    public class Appointment
    {
        private int appointmentId;
        private int patientId;
        private int doctorId;
        private DateTime appointmentDate;
        private string description;

        // Default constructor
        public Appointment() { }

        // Parameterized constructor
        public Appointment(int appointmentId, int patientId, int doctorId, DateTime appointmentDate, string description)
        {
            this.appointmentId = appointmentId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            this.appointmentDate = appointmentDate;
            this.description = description;
        }

        // Properties
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public int DoctorId { get => doctorId; set => doctorId = value; }
        public DateTime AppointmentDate { get => appointmentDate; set => appointmentDate = value; }
        public string Description { get => description; set => description = value; }

        public override string ToString()
        {
            return $"AppointmentId: {appointmentId}, PatientId: {patientId}, DoctorId: {doctorId}, Date: {appointmentDate}, Description: {description}";
        }
    }
}
