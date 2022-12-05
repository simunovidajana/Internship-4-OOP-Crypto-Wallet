using CryptoWallet.Classes;
using CryptoWallet.Enums;
using CryptoWallet.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MainMenu();
        }

        private static void Selection(int choice)
        {
            switch (choice)
            {
                case 0:
                    Exit();
                    break;
                case 1:
                    KreirajWallet();
                    break;
                case 2:
                    PristupiWalletu();
                    break;
            }
        }

        private static void MainMenu()
        {
            var options = "\n1 - Kreiraj wallet\n2 - Pristupi walletu\n0 - Izađi iz programa";
            Selection(Menu(options, "", 0, 2));

            Console.ReadKey();
        }
        private static int Menu(string options, string optionally, int lowerLimit, int upperLimit)
        {
            Console.Clear();
            Console.WriteLine(optionally);

            Console.WriteLine("\nIzaberite jednu od ponuđenih mogućnosti upisom broja: ");
            bool correctInput;
            int userChoice;
            do
            {
                Console.WriteLine(options);
                correctInput = int.TryParse(Console.ReadLine(), out userChoice);

            } while (correctInput == false || userChoice < lowerLimit || userChoice > upperLimit);

            return userChoice;
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nOdabrali ste opciju : 0 - Izlaz iz aplikacije.\n");
            var closeApp = "";
            do
            {
                Console.WriteLine("Jeste li sigurni da želite izaći iz aplikacije? (DA/NE)");
                closeApp = Console.ReadLine().Trim();

            } while (closeApp != "DA" && closeApp != "NE");
            if (closeApp == "DA")
                Environment.Exit(0);
            else
                MainMenu();
        }
        private static void PristupiWalletu()
        {
            throw new NotImplementedException();
        }

        private static void KreirajWallet()
        {
            var options = "\n1 - Bitcoin wallet\n2 - Etheruem wallet\n3 - Solana wallet";
            SelectionKreirajWallet(Menu(options, "", 1, 3));

            Console.ReadKey();
        }

        private static void SelectionKreirajWallet(int choice)
        {
            switch (choice)
            {
                case 1:
                    KreirajOdabraniWallet(1);
                    break;
                case 2:
                    KreirajWallet();
                    break;
                case 3:
                    PristupiWalletu();
                    break;
            }
        }

        private static void KreirajOdabraniWallet(int enumVrijednostWalleta)
        {
            //if(enumVrijednostWalleta == )
        }
    }
}
