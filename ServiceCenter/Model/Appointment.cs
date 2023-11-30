using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Model;

public class Appointment //"time slots"
{
    public string Id { get; set; }
    public string Notes { get; set; } // this is not neccesary but it is nice to have
    public DateTime dateTime { get; set; }

}
