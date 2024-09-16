namespace Taller1_Cajero
{
    public interface IHandler
    {
        IHandler SetNext(IHandler nextHandler);
        void Dispense(int amount);
    }
}