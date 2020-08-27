using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.AbstractFactory.ConcreteSpeech
{
    public class KoreanSpeech : Speech
    {
        public override void Say()
        {
            Console.WriteLine("미국 악");
        }
    }
}
