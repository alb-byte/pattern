using pattern.AbstractFactory.ConcreteSpeech;
using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.AbstractFactory
{
    public class LukaFactory : DictatorFactory
    {
        public override Speech GetSpeech()
        {
            return new BelarusSpeech();
        }
    }
}
