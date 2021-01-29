using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentStep244
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

        public void Quittable(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            Console.WriteLine("Employee Quit");
        }
    }
}
