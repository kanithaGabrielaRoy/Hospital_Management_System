using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.entity
{
    public class Doctor
    {
        private int doctorId;
        private string firstName;
        private string lastName;
        private string specialization;
        private string contactNumber;

        // Default constructor
        public Doctor() { }

        // Parameterized constructor
        public Doctor(int doctorId, string firstName, string lastName, string specialization, string contactNumber)
        {
            this.doctorId = doctorId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.specialization = specialization;
            this.contactNumber = contactNumber;
        }

        // Properties
        public int DoctorId { get => doctorId; set => doctorId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }

        public override string ToString()
        {
            return $"DoctorId: {doctorId}, Name: {firstName} {lastName}, Specialization: {specialization}, Contact: {contactNumber}";
        }
    }
}
