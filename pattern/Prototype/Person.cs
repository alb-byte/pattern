using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace pattern.Prototype
{
    [Serializable]
    public class Person
    {
        public Consciousness Consciousness{get;set;}
        public string EyeColor { get; set; }
        public Person(string color,Consciousness c)
        {
            this.EyeColor = color;
            this.Consciousness = c;
        }

        public Person Clone()
        {
            Person clone = null;
            using (MemoryStream memory = new MemoryStream())
            {
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(memory, this);
                memory.Seek(0, SeekOrigin.Begin);
                clone = binary.Deserialize(memory) as Person;
            }
            return clone;
        }
    }
}
