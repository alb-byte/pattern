using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.AbstractFactory.ConcreteSpeech
{
    public class BelarusSpeech : Speech
    {
        public override void Say()
        {
            Console.WriteLine("ЖЭСТАЧАЙШЭ");
        }
    }
}
