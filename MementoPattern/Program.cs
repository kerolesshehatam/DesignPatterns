using System;

namespace MementoPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Sales s = new Sales();
            s.Name = "Keroles";
            s.Phone = "0123456789";
            s.Budget = 5000.0;

            // Store internal state
            AppMemory m = new AppMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Name = "Ali";
            s.Phone = "098765";
            s.Budget = 1000.0;

            // Restore saved state
            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }
}
