using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Hospital_Management_System.entity;
using Hospital_Management_System.util;
using Hospital_Management_System.myexceptions;

namespace Hospital_Management_System.dao
{

    public class HospitalServiceImpl : IHospitalService
    {
        SqlConnection sqlConnection = null; // Connection created in using block
        SqlCommand cmd = null;

        public HospitalServiceImpl()
        {
            cmd = new SqlCommand();
        }

        public Appointment GetAppointmentById(int appointmentId)
        {
            Appointment appointment = null;
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = "SELECT * FROM Appointment WHERE AppointmentId = @AppointmentId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    appointment = new Appointment(
                        (int)reader["AppointmentId"],
                        (int)reader["PatientId"],
                        (int)reader["DoctorId"],
                        (DateTime)reader["AppointmentDate"],
                        reader["Description"].ToString()
                    );
                }
            }
            return appointment;
        }

        public List<Appointment> GetAppointmentsForPatient(int patientId)
        {
            List<Appointment> appointments = new List<Appointment>();
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = "SELECT * FROM Appointment WHERE PatientId = @PatientId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PatientId", patientId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment(
                        (int)reader["AppointmentId"],
                        (int)reader["PatientId"],
                        (int)reader["DoctorId"],
                        (DateTime)reader["AppointmentDate"],
                        reader["Description"].ToString()
                    ));
                }
            }
            return appointments;
        }

        public List<Appointment> GetAppointmentsForDoctor(int doctorId)
        {
            List<Appointment> appointments = new List<Appointment>();
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = "SELECT * FROM Appointment WHERE DoctorId = @DoctorId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    appointments.Add(new Appointment(
                        (int)reader["AppointmentId"],
                        (int)reader["PatientId"],
                        (int)reader["DoctorId"],
                        (DateTime)reader["AppointmentDate"],
                        reader["Description"].ToString()
                    ));
                }
            }
            return appointments;
        }

        public bool ScheduleAppointment(Appointment appointment)
        {
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = @"INSERT INTO Appointment (PatientId, DoctorId, AppointmentDate, Description)
                                  VALUES (@PatientId, @DoctorId, @AppointmentDate, @Description)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Description", appointment.Description);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool UpdateAppointment(Appointment appointment)
        {
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = @"UPDATE Appointment SET 
                                  PatientId = @PatientId, 
                                  DoctorId = @DoctorId, 
                                  AppointmentDate = @AppointmentDate, 
                                  Description = @Description 
                                  WHERE AppointmentId = @AppointmentId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AppointmentId", appointment.AppointmentId);
                cmd.Parameters.AddWithValue("@PatientId", appointment.PatientId);
                cmd.Parameters.AddWithValue("@DoctorId", appointment.DoctorId);
                cmd.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                cmd.Parameters.AddWithValue("@Description", appointment.Description);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        public bool CancelAppointment(int appointmentId)
        {
            using (sqlConnection = DbConnUtil.GetConnectionObject())
            {
                cmd.CommandText = "DELETE FROM Appointment WHERE AppointmentId = @AppointmentId";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                cmd.Connection = sqlConnection;
                sqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }
    }
}