using IteratorPattern.Collections;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();

            aggregate[0] = "Item 0";
            aggregate[1] = "Item 1";
            aggregate[2] = "Item 2";
            aggregate[3] = "Item 3";
            aggregate[4] = "Item 4";

            Iterator iterator = aggregate.CreateIterator();

            object item = iterator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
                
            }

            Console.ReadKey();


        }
    }
}
