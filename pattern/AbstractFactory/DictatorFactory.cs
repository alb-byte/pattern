using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.AbstractFactory
{
    public abstract class DictatorFactory
    {
        public abstract Speech GetSpeech();
    }
}
