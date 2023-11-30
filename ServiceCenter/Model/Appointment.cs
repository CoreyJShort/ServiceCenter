using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Model
{
    internal class Appointment
    {
        public string ID {  get; set; }
        public string Notes { get; set; }
        public DateTime dateTime { get; set; }

    }
}
