using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenter.Model;

public class Customers
{
    public List<Customer> customers { get; set; } //when you have a list like this as a property, This is a 'reference variable', there is no lst yet, adding customers will not work yet.

    public Customers()
    {
        customers = new List<Customer>(); // NOW we have an actual list 
    }

    public Customer Authenticate(string username, string password)// this will give you the user 
    {
        var c = customers.Where(o => (o.UserName == username) && (o.Password == password)); //member = o in this situation 

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
