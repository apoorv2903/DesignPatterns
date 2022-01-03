using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IStock ibm = new Stock("IBM", 135.27);
            IStock apple = new Stock("APPLE", 181);
            var john = new Investor("John");
            var jack = new Investor("Jack");
            var jill = new Investor("Jill");
            ibm.Subscribe(john);
            ibm.Subscribe(jack);
            apple.Subscribe(jack);
            ibm.Price = 136;
            apple.Price=183;
            ibm.Price = 134;
            ibm.UnSubscribe(jack);
            apple.Subscribe(jill);
            apple.Price = 186;
            ibm.Price = 132;
            ibm.Price = 139;
            apple.UnSubscribe(jill);
            apple.Price = 182;
        }
    }
}
