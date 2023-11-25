using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace prova
{

    internal class Program
    {
        string parola, par, key;
        short num, nn;
        byte i, par2;
        ConsoleKeyInfo chiave;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }

        void run()
        {
            Console.Title = "Crypter Menu";
            byte number;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            scritta();
            Console.Write("1) crypter symmetric key\n2) decrypter symmetric key\n\nInserisci l'opzione: ");
            number = byte.Parse(Console.ReadLine());
            Console.Clear();

            switch (number)
            {
                case 1:
                    scritta();
                    crypter();
                    break;
                case 2:
                    scritta();
                    deceypter();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    scritta();
                    Console.WriteLine("Errore l'opzione non esiste!");
                    ritorn();
                    break;
            }
            Console.ReadLine();
        }
        void crypter()
        {
            key = "";

            Console.Write("Inserisci la Frase: ");
            parola = Console.ReadLine();

            num = (short)parola.Length;

            for (int i = 0; i < num; i++)
            {
                par = parola.Substring(i, 1);
                par2 = Convert.ToByte(par[0]);
                nn = par2 += 4;

                key += Convert.ToChar(par2).ToString();
            }
            Console.WriteLine($"frase cryptata : {key}");
            ritorn();
        }

        void deceypter()
        {
            key = "";

            Console.Write("Inserisci la Frase: ");
            parola = Console.ReadLine();

            num = (short)parola.Length;

            for (int i = 0; i < num; i++)
            {
                par = parola.Substring(i, 1);
                par2 = Convert.ToByte(par[0]);
                nn = par2 -= 4;

                key += Convert.ToChar(par2).ToString();
            }
            Console.WriteLine($"Frase decryptata : {key}");
            ritorn();
        }
        void ritorn()
        {
            Console.Write("\n\nClicca INVIO per tornare all'inzio.");
            chiave = Console.ReadKey();

            if (chiave.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Program program = new Program();
                program.run();
            }

        }
        void scritta()
        {
            Console.WriteLine("█▀▀ █▀█ █▄█ █▀█ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n█▄▄ █▀▄ ░█░ █▀▀ ░█░   █░▀░█ ██▄ █░▀█ █▄█");
        }
    }
}
