using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace pattern.Singleton
{
    public class Albert
    {
        private static Albert instance;
        private static Object locker = new Object();
        private int age;
        private Albert(int age)
        {
            this.age = age;
        }
        public string Age
        {
            get
            {
                if(age != 0)
                {
                    return $"Albert: {age}";
                }
                else
                {
                    return $"Who?";
                }
            }
        }
        public static Albert getInstance(int age)
        {
            if(instance == null)
            {
                lock (locker)
                {
                    instance = new Albert(age);
                }
            }
            return instance;
        }
    }
}
