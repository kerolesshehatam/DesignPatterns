namespace MementoPattern
{
    public class AppMemory
    {
        private SalesMemento _memento;

        public SalesMemento Memento
        {
            set => _memento = value;
            get => _memento;
        }
    }
}
