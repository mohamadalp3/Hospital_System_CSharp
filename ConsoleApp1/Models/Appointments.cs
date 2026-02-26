using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Appointments
    {
        
        public class Appointment
        {
            public int AppointmentId { get; set; }       // رقم الموعد
            public int PatientId { get; set; }           // رقم المريض
            public int DoctorId { get; set; }            // رقم الطبيب
            public string ? AppointmentDate { get; set; } // تاريخ ووقت الموعد
            public string ? Notes { get; set; }            // ملاحظات إضافية



            // ربط العلاقة الكائنية
            public Patient Patient { get; set; }
            public Doctor Doctor { get; set; }
            // دالة لعرض تفاصيل الموعد
            public void DisplayInfo()
            {
                Console.WriteLine($"موعد رقم: {AppointmentId}");
                Console.WriteLine($"المريض: {PatientId}");
                Console.WriteLine($"الطبيب: {DoctorId}");
                Console.WriteLine($"التاريخ: {AppointmentDate}");
                Console.WriteLine($"ملاحظات: {Notes}");
            }

        }
    }



}

