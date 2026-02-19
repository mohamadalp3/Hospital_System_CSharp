using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    
        // كلاس يمثل بيانات الأطباء بناءً على المخطط المطلوب
        public class Doctor
        {
            public int Doctor_ID { get; set; } // رقم الطبيب (المعرف الفريد)
            public string First_Name { get; set; } // الاسم الأول
            public string Last_Name { get; set; } // الكنية
            public string Specialty { get; set; } // التخصص
            public string Phone_Number { get; set; } // رقم الهاتف
            public string Email { get; set; } // البريد الإلكتروني
            public string Work_Shift { get; set; } // وردية العمل (صباحي/مسائي)
            public string Department { get; set; } // القسم التابع له
        }
    }

