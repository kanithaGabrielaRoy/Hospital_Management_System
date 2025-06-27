------------C# CODING CHALLENGE -------------

----create datbase HospitalDB
create database HospitalDB

---create class Patient
create table Patient (
PatientID int identity primary key, 
FirstName varchar(50) not null,
LastName varchar(50) not null,
DateOfBirth date not null,
Gender varchar(10) not null,
ContactNumber varchar(15) not null,
Address text )

---create class Doctor
create table Doctor (
DoctorID int identity primary key, 
FirstName varchar(50) not null,
LastName varchar(50) not null,
Specialization varchar(50) not null,
ContactNumber varchar(15) not null)

---create class Appointments
create table Appointments (
AppointmentID int identity primary key,
PatientID int not null
foreign key (PatientID) references Patient(PatientID),
DoctorID int not null
foreign key (DoctorID) references Doctor(DoctorID),
AppointmentDate date not null,
Description text )

---insert values into Patient table
insert into Patient(FirstName,LastName,DateOfBirth,Gender,ContactNumber,Address)
values ('Chitra','Maalya','2002-10-17','Female','9367216743','13,Nehru St,Rameswaram'),
('Karthick','Raj','2006-06-23','Male','9648823167','3, Vaigai Street,Madurai')

---insert values into Doctor class
insert into Doctor(FirstName,LastName,Specialization,ContactNumber)
values ('Vinodh','Kumar','Cardiologist','6382389264'),
('Meena','Rajasekari','Nephrologist','9443716886')

---insert values into Appointments class
insert into Appointment(PatientID,DoctorID,AppointmentDate,Description)
values (1,2,'2025-06-26','Swelling of Legs'),
(2,1,'2025-06-28','Slight pain in the chest')