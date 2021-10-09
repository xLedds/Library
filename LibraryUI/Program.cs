using LibraryBusinessLogic;
using LibraryData;
using LibraryEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto! Scegli un'azione:");
            Console.WriteLine("1 - Login");
            Console.WriteLine("2 - Esci");
            var azione = Console.ReadLine();
            if (azione == "1")
            {
                Console.WriteLine("Inserisci username:");
                string username = Console.ReadLine();
                Console.WriteLine("Inserisci password:");
                string password = Console.ReadLine();
                if (BusinessLogic.Login(username, password) == 1)
                {
                    Console.WriteLine("\nLogin effettuato con successo.");
                    ShowAdminUI();
                }
                else if (BusinessLogic.Login(username, password) == 2)
                {
                    Console.WriteLine("\nLogin effettuato con successo.");
                    Console.WriteLine("\n1 - Ricerca libro");
                    Console.WriteLine("2 - Effettua un prestito");
                    Console.WriteLine("3 - Restituisci libro");
                    Console.WriteLine("4 - Visualizza storico prenotazioni");
                    Console.WriteLine("5 - Esci");
                    var scelta = Console.ReadLine();
                    switch (scelta)
                    {
                        case "1":
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Login non effettuato");
                }
            }
            Console.ReadLine();
        }

        private static void ShowAdminUI()
        {
            Console.WriteLine("\n1 - Inserisci libro");
            Console.WriteLine("2 - Modifica libro");
            Console.WriteLine("3 - Cancella libro");
            Console.WriteLine("4 - Ricerca libro");
            Console.WriteLine("5 - Effettua un prestito");
            Console.WriteLine("6 - Restituisci libro");
            Console.WriteLine("7 - Visualizza storico prenotazioni");
            Console.WriteLine("8 - Esci");
            var scelta = Console.ReadLine();
            switch (scelta)
            {
                case "1":
                    AddBookMenu();
                    ShowAdminUI();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                default:
                    break;
            }
        }

        private static void AddBookMenu()
        {
            Console.WriteLine("Inserisci titolo");
            var title = Console.ReadLine();
            Console.WriteLine("Inserisci nome autore");
            var authorName = Console.ReadLine();
            Console.WriteLine("Inserisci cognome autore");
            var authorSurname = Console.ReadLine();
            Console.WriteLine("Inserisci publishing house");
            var publishingHouse = Console.ReadLine();
            Console.WriteLine("Inserisci quantità");
            var quantity = int.Parse(Console.ReadLine());
            if (BusinessLogic.AddBook(title, authorName, authorSurname, publishingHouse, quantity))
                Console.WriteLine("Libro aggiunto con successo.");
            else
                Console.WriteLine("Libro già esistente, aggiornata quantità.");
        }
    }
}

