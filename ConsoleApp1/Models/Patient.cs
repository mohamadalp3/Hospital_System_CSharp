using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Patient
    {
        public int Patient_ID { get; set; } // رقم المريض
        public string First_Name { get; set; } // الاسم الأول
        public string Last_Name { get; set; } // الكنية
        public DateTime Date_of_Birth { get; set; } // تاريخ الميلاد
        public string Gender { get; set; } // الجنس
        public string Phone_Number { get; set; } // رقم الهاتف
        public string Address { get; set; } // العنوان
        public string Diagnosis { get; set; } // التشخيص
        public string Admission_Status { get; set; } // حالة الدخول (مثلاً: طوارئ، منوم)
        public int Assigned_Doctor_ID { get; set; } // رقم الطبيب المسؤول (علاقة الربط)
         // ربط العلاقة: المريض ينتمي لطبيب واحد
        public Doctor AssignedDoctor { get; set; }

        // ربط العلاقة: المريض يمكن أن يملك عدة مواعيد ووصفات
        public List<Appointments.Appointment> PatientAppointments { get; set; } = new List<Appointments.Appointment>();
        public List<Prescription> PatientPrescriptions { get; set; } = new List<Prescription>();
        //تابع يرجع الاسم الكامل للمريض
        public string GetFullName()
        {
            return $"{First_Name} {Last_Name}";
        }

        //  تابع حساب العمر
        public int GetAge()
        {
            int age = DateTime.Now.Year - Date_of_Birth.Year;
            if (DateTime.Now.DayOfYear < Date_of_Birth.DayOfYear)
                age--;

            return age;
        }

        // 3️⃣ تابع عرض معلومات المريض
        public void PrintPatientInfo()
        {
            Console.WriteLine("===== Patient Information =====");
            Console.WriteLine($"Patient ID: {Patient_ID}");
            Console.WriteLine($"Full Name: {GetFullName()}");
            Console.WriteLine($"Age: {GetAge()} years");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Phone Number: {Phone_Number}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Diagnosis: {Diagnosis}");
            Console.WriteLine($"Admission Status: {Admission_Status}");
            Console.WriteLine($"Assigned Doctor ID: {Assigned_Doctor_ID}");
        }
        public string GeneratePatientReport()
        {
            return $"Patient: {GetFullName()} | " +
                   $"Age: {GetAge()} | " +
                   $"Appointments: {PatientAppointments.Count} | " +
                   $"Prescriptions: {PatientPrescriptions.Count}";
        }
        public int GetActivePrescriptions(int validDays)
        {
            return PatientPrescriptions
                   .Count(p => !p.IsExpired(validDays));
        }
    }
}
    
  