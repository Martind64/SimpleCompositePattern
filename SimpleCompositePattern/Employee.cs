using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompositePattern
{
    public class Employee : Component
    {
        public Employee(string name) : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add an employee to employees");
        }

        public override void Remove(Component C)
        {
            Console.WriteLine("Cannot remove an employee from employees");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
        }
    }
}
