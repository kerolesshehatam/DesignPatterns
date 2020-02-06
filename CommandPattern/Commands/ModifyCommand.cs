using System.Collections.Generic;
using System.Linq;

namespace CommandPattern.Commands
{
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}
