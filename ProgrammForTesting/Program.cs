using Customer_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammForTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            ListCustomer list = new ListCustomer();
            var test = list.CreateNewDataBase("test", "password");
            var test2 = list.LoadDataBase("test", "password");

            Customer cu1 = new Customer("Fristname", "Lastname", "email", 0, new DateTime());
            Customer cu2 = new Customer("Tobi", "Ww", "Email", 0, new DateTime());
            Customer cu3 = new Customer("Clemens", "Lasdetname", "email", 0, new DateTime());
            Customer cu4 = new Customer("Grunt", "Gg", "email", 0, new DateTime());

            list.AddCustomer(cu1);
            list.AddCustomer(cu2);
            list.AddCustomer(cu3);
            list.AddCustomer(cu4);

            list.UpdateDatabase();
        }
    }
}
