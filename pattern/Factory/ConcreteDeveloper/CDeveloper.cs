using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.Factory
{
    public class CDeveloper : Developer
    {
        public CDeveloper(string name):base(name)
        { }
        public override Code GetCode()
        {
            return new CCode();
        }
    }
}
