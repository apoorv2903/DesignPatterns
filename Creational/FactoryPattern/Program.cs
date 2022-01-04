using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore();
            store.orderPizza(PizzaType.Farmhouse);
        }
    }
}
