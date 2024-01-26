using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_22_01
{
    internal class Train
    {
        public int Id {  get; set; }
        public string Carrier { get; set; }
        public float Milleage {  get; set; }
        public string TechnicalNumber {  get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string ManagerPhoneNumber {  get; set; }
    }
}
