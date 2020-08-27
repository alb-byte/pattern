using pattern.AbstractFactory;
using pattern.Factory;
using pattern.Prototype;
using pattern.Singleton;
using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------Factory-----------------------------
            Developer developer1 = new JavaDeveloper("JAVADeveloper");
            Developer developer2 = new CDeveloper("CDeveloper");
            developer1.GetCode();
            developer2.GetCode();
            //---------------AbstractFactory-----------------------------
            Dictator dictator1 = new Dictator(new LukaFactory());
            Dictator dictator2 = new Dictator(new KimChenInFactory());
            dictator1.Speak();
            dictator2.Speak();
            //---------------Singleton----------------------------------
            Albert albert = Albert.getInstance(19);
            Console.WriteLine(albert.Age);
            Albert albert2 = Albert.getInstance(150);
            Console.WriteLine(albert2.Age);
            //---------------Prototype----------------------------------
            Person person = new Person("gray", new Consciousness(120));
            Person clone = person.Clone();
            clone.Consciousness.IQ = 100;
            Console.WriteLine($"person color: {person.EyeColor}\tclone color: {clone.EyeColor}\n" +
                $"person IQ: {person.Consciousness.IQ}\tclone IQ: {clone.Consciousness.IQ}");


        }
    }
}
