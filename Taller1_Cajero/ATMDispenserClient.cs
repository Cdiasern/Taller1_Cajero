using System.Reflection.Metadata;
using Taller1_Cajero.DispenseClasses;

namespace Taller1_Cajero
{
    public class ATMDispenserClient
    {
        private readonly IHandler _handler;

        public ATMDispenserClient()
        {
            _handler = new DispenseOneHundredThousandHandler();
            IHandler handler50 = new DispenseFiftyThousandHandler();
            IHandler handler20 = new DispenseTwentyThousandHandler();
            IHandler handler10 = new DispenseOneThousandHandler();
            IHandler handler5 = new DispenseFiveThousandHandler();

            _handler.SetNext(handler50)
                    .SetNext(handler20)
                    .SetNext(handler10)
                    .SetNext(handler5);
        }

        public void Process(int amount)
        {
            if (amount % 5000 != 0)
            {
                throw new InvalidOperationException("El monto a retirar debe ser múltiplo de $5.000");
            }

            _handler.Dispense(amount);
        }
    }
}