using System.Reflection.Metadata;

namespace Taller1_Cajero
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
            return _nextHandler;
        }

        public virtual void Dispense(int amount)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Dispense(amount);
            }
        }
    }

}
