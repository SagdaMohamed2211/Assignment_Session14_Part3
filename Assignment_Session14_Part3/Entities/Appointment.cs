using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session14_Part3.Entities
{
    [PrimaryKey(nameof(Patientid), nameof(Doctorid))]
    internal class Appointment
    {

        public  int Patientid { get; set; }

        public  int Doctorid { get; set; }

        public  DateFormat AppointmentDate { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
