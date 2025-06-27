﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System.myexceptions
{
    public class PatientNumberNotFoundException : Exception
    {
        public PatientNumberNotFoundException() : base("Patient number not found.") { }

        public PatientNumberNotFoundException(string message) : base(message) { }

        public PatientNumberNotFoundException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}