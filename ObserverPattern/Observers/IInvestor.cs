using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}

