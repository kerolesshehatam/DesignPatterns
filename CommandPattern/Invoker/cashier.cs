using CommandPattern.Commands;
using CommandPattern.Receiver;

namespace CommandPattern.Invoker
{
    /// <summary>
    /// The Invoker 
    /// </summary
    public class Cashier
    {
        private OrderCommand _orderCommand;
        private MenuItem _menuItem;
        private Kitchen _kitchenOrder;

        public Cashier()
        {
            _kitchenOrder = new Kitchen();
        }


        public void SetCommand(int commandOption)
        {
            _orderCommand = new CommandFactory().GetCommand(commandOption);
        }

        public void SetMenuItem(MenuItem item)
        {
            _menuItem = item;
        }

        public void ExecuteCommand()
        {
            _kitchenOrder.ExecuteCommand(_orderCommand, _menuItem);
        }

        public void ShowCurrentOrder()
        {
            _kitchenOrder.ShowCurrentItems();
        }
    }
}
