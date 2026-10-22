using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session14_Part3.Entities
{
    internal class Doctor
    {
        public int id { get; set; }

        public string Name { get; set; }

        public  string Specialization { get; set; }


        public ICollection<Appointment> Appointments { get; set; }
    }
}
