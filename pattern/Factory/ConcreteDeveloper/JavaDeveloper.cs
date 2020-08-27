using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.Factory
{
    public class JavaDeveloper : Developer
    {
        public JavaDeveloper(string name):base(name)
        {  }
        public override Code GetCode()
        {
            return new JavaCode();
        }
    }
}
