using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
        // كلاس يمثل بيانات الروشتة (الوصفة الطبية)
        public class Prescription
        {
            public int Prescription_ID { get; set; } // رقم الروشتة
            public int Patient_ID { get; set; } // رقم المريض (مفتاح أجنبي)
            public int Doctor_ID { get; set; } // رقم الطبيب (مفتاح أجنبي)
            public DateTime Date { get; set; } // تاريخ الروشتة
            public string Medication { get; set; } // اسم الدواء
            public string Dosage { get; set; } // الجرعة وتعليمات الاستخدام

        // ربط العلاقة الكائنية
           public Patient Patient { get; set; }
           public Doctor Doctor { get; set; }
           // تابع للتحقق مما إذا كانت الروشتة حديثة خلال عدد أيام محدد
           public bool IsRecent(int days)
            {
                return (DateTime.Now - Date).TotalDays <= days;
            }

            // تابع لعرض معلومات الروشتة
            public void PrintPrescriptionInfo()
            {
                Console.WriteLine("===== Prescription Information =====");
                Console.WriteLine($"Prescription ID: {Prescription_ID}");
                Console.WriteLine($"Patient ID: {Patient_ID}");
                Console.WriteLine($"Doctor ID: {Doctor_ID}");
                Console.WriteLine($"Date: {Date.ToShortDateString()}");
                Console.WriteLine($"Medication: {Medication}");
                Console.WriteLine($"Dosage: {Dosage}");
            }
        }
    }

