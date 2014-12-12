using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompositePattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Instantiate a department and add employees to it
            Department HumanRessources = new Department("Human Ressources");
            HumanRessources.Add(new Employee("Bo"));
            HumanRessources.Add(new Employee("Soeren"));
            HumanRessources.Add(new Employee("Joergen"));
            
            // Display the employees using the Display Method
            HumanRessources.Display(1);

            // Instantiate a department and add employees to it
            Department itDepartment = new Department("ITDepartment");

            itDepartment.Add(new Employee("Ole"));
            itDepartment.Add(new Employee("Michael"));

            //Display the employees using the Display Method
            itDepartment.Display(1);

            // Testing to see if an employee can be added to employees
            Employee employee = new Employee("Peter");
            employee.Add(new Employee("Soeren"));
        }
    }
}
