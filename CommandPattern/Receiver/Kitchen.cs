using CommandPattern.Commands;
using System;
using System.Collections.Generic;

namespace CommandPattern.Receiver
{
    /// <summary>
    /// The Receiver
    /// </summary
    public class Kitchen
    {
        public List<MenuItem> currentItems { get; set; }
        public Kitchen()
        {
            currentItems = new List<MenuItem>();
        }

        public void ExecuteCommand(OrderCommand command, MenuItem item)
        {
            command.Execute(currentItems, item);
        }

        public void ShowCurrentItems()
        {
            foreach (var item in currentItems)
            {
                item.Display();
            }
            Console.WriteLine("-----------------------");
        }
    }
}
