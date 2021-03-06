﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompositePattern
{
    public abstract class Component
    {

        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component C);
        public abstract void Display(int depth);



    }
}
