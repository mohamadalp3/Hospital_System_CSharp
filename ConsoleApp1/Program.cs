using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // تفعيل اللغة العربية في وحدة التحكم
            Console.OutputEncoding = Encoding.UTF8;

            // 1. بيانات الطبيب (بالإنجليزي)
            Doctor doctor1 = new Doctor
            {
                Doctor_ID = 101,
                First_Name = "nour",
                Last_Name = "Doe",
                Specialty = "Cardiology",
                Department = "Surgery",
                Work_Shift = "Morning",
                Phone_Number = "+1-555-0199",
                Email = "j.doe@hospital.com",
                Patients = new List<Patient>()
            };

            // 2. بيانات المريض (بالإنجليزي)
            Patient patient1 = new Patient
            {
                Patient_ID = 501,
                First_Name = "James",
                Last_Name = "Wilson",
                Date_of_Birth = new DateTime(1985, 10, 20),
                Gender = "Male",
                Address = "New York, USA",
                Diagnosis = "Hypertension",
                Admission_Status = "Stable",
                Assigned_Doctor_ID = doctor1.Doctor_ID,
                AssignedDoctor = doctor1
            };

            doctor1.Patients.Add(patient1);

            // --- الطباعة باللغة العربية ---

            Console.WriteLine("------------------------------------------");
            doctor1.PrintDoctorInfo(); // ستظهر العناوين بالعربي والقيم بالإنجليزي
            Console.WriteLine($"إجمالي عدد المرضى: {doctor1.Patients.Count}");

            Console.WriteLine("\n------------------------------------------");
            patient1.PrintPatientInfo(); // ستظهر العناوين بالعربي والقيم بالإنجليزي
            Console.WriteLine($"الطبيب المعالج: د. {doctor1.First_Name} {doctor1.Last_Name}");

            Console.WriteLine("\nاضغط أي مفتاح للخروج...");
            Console.ReadKey();
        }
    }
}