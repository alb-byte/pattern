using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.AbstractFactory
{
    public class Dictator
    {
        private Speech speech;
        public Dictator(DictatorFactory factory)
        {
            speech = factory.GetSpeech();
        }
        public void Speak()
        {
            speech.Say();
        }
    }
}
