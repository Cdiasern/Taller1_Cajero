using Taller1_Cajero;

public class Program
{
    public static void Main(string[] args)
    {
        ATMDispenserClient atmDispenser = new ATMDispenserClient();
        bool exit = false;

        do
        {
            Console.Clear();
            Console.Write("Ingrese monto a retirar: $");
            int amount = int.Parse(Console.ReadLine());

            try
            {
                atmDispenser.Process(amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Presiona 'S' para realizar una nueva transacción o 'N' para salir");
            string continueTransaccion = Console.ReadLine()?.ToUpper();

            if (continueTransaccion == "N")
            {
                exit = true;
            }

        } while (!exit);
    }
}