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
    }
}