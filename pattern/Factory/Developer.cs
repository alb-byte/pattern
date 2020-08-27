using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.Factory
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name)
        {
            this.Name = name;
        }
        public abstract Code GetCode();
    }
}
