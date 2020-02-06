using IteratorPattern.Collections;

namespace IteratorPattern
{
    public class ConcreteIterator : Iterator
    {
        private readonly ConcreteAggregate concreteAggregate;

        private int _current = 0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            this.concreteAggregate = concreteAggregate;
        }

        public override object CurrentItem()
        {
            return concreteAggregate[_current];
        }

        public override object First()
        {
            return concreteAggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= concreteAggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            if (_current < concreteAggregate.Count - 1)
            {
                ret = concreteAggregate[++_current];
            }

            return ret;
        }
    }
}