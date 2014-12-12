using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompositePattern
{
    public class Department : Component
    {
          private ArrayList _children = new ArrayList();
        public Department(string name) : base(name)
        {

        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);
            foreach (Component c in _children)
            {
                c.Display(depth + 2);
            }
        }
    }
}
