using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Appointments
    {
        
        public class Appointment
        {
            public int AppointmentId { get; set; }       // رقم الموعد
            public int PatientId { get; set; }           // رقم المريض
            public int DoctorId { get; set; }            // رقم الطبيب
            public string ? AppointmentDate { get; set; } // تاريخ ووقت الموعد
            public string ? Notes { get; set; }            // ملاحظات إضافية

          
        }
    }



}

