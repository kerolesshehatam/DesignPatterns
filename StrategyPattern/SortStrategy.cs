using System.Collections.Generic;

namespace StrategyPattern
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
