using System;

namespace BridgePattern.Bridge
{
    public class DataPresenter
    {
        private IPresenter _presenter;
        public IPresenter Presenter { set => _presenter = value; }

        public virtual void Operation()
        {
            Console.WriteLine("Abstract: Base operation with:\n");

            _presenter.OperationImplementation();
        }
    }
}
