namespace ChainOfResponsibilityPattern.Models
{
    public abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
