﻿namespace Taller1_Cajero.DispenseClasses
{
    public class DispenseOneThousandHandler : BaseHandler
    {
        public override void Dispense(int amount)
        {
            int value = 10000;

            if (amount >= value)
            {
                int num = amount / value;
                int remainder = amount % value;
                Console.WriteLine($"Retirando {num} billete(s) de {value:C0}");

                if (remainder > 0)
                {
                    base.Dispense(remainder);
                }
            }
            else
            {
                base.Dispense(amount);
            }
        }
    }
}