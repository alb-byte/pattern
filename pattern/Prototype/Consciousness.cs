using System;
using System.Collections.Generic;
using System.Text;

namespace pattern.Prototype
{
    [Serializable]
    public class Consciousness
    {
        public Consciousness(int iq)
        {
            this.IQ = iq;
        }
        public int IQ { get; set; }
    }
}
