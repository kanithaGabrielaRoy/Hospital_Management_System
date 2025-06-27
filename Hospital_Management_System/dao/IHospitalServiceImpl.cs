using Hospital_Management_System.entity;
using System.Collections.Generic;
using Hospital_Management_System.entity;

namespace Hospital_Management_System.dao
{
    public interface IHospitalServiceImpl : IHospitalService
    {
        void DisplayAppointmentById();
        void DisplayAppointmentsForPatient();
        void DisplayAppointmentsForDoctor();
        void ScheduleNewAppointment();
        void UpdateAppointmentDetails();
        void CancelAppointmentById();
    }
}