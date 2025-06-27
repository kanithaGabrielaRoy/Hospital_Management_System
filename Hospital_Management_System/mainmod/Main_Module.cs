using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital_Management_System.entity;
using Hospital_Management_System.dao;
using Hospital_Management_System.myexceptions;
namespace Hospital_Management_System.mainmod
{
    class MainModule
    {
        static void Main(string[] args)
        {
            HospitalServiceImpl service = new HospitalServiceImpl();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n--- Hospital Management System ---");
                Console.WriteLine("1. Get Appointment by ID");
                Console.WriteLine("2. Get Appointments for Patient");
                Console.WriteLine("3. Get Appointments for Doctor");
                Console.WriteLine("4. Schedule Appointment");
                Console.WriteLine("5. Update Appointment");
                Console.WriteLine("6. Cancel Appointment");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1: service.DisplayAppointmentById(); break;
                        case 2: service.DisplayAppointmentsForPatient(); break;
                        case 3: service.DisplayAppointmentsForDoctor(); break;
                        case 4: service.ScheduleNewAppointment(); break;
                        case 5: service.UpdateAppointmentDetails(); break;
                        case 6: service.CancelAppointmentById(); break;
                        case 7:
                            exit = true;
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (PatientNumberNotFoundException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}