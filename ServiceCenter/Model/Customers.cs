using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Model;

internal class Customers
{
   public List<Customer> customers {  get; set; }//reference variables no equals new list

    public Customers()
    {
        customers = new List<Customer>();
    }

    public Customer Authenticate(string username, string password)
    {
        var c = customers.Where(x => (x.UserName == username && x.Password== password));

        if(c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null;
        }
    }
}
