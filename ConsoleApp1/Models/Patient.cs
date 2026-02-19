using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Patient
    {
        // هنا نضع معلومات المريض (رقم، اسم، تشخيص)
        public int Patient_ID { get; set; }
        public string Name { get; set; }
        public string Diagnosis { get; set; }
    }
}