using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Classe2;

namespace _2___Rappresentare_una_persona_fisica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta = 0, controllo = 0;
            bool registrato = false;
            do
            {
                Console.WriteLine("Inserisci il codice: ");
                int codice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserisci il cognome: ");
                string cognome = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Inserisci il nome: ");
                string nome = Convert.ToString(Console.ReadLine());
                do
                {
                    Console.WriteLine("Premi 1 per registrare l'utente, premi 0 per NON registrare l'utente: ");
                    controllo = Convert.ToInt32(Console.ReadLine());
                    if (controllo == 1)
                        registrato = true;
                    else
                        registrato = false;
                } while (controllo != 1 && controllo != 0);
                
                
                Classe2.Persona persona = new Persona(codice, cognome, nome, registrato);

                string output = persona.Output();
                Console.WriteLine("I dati anagrafici sono: " + output);

                Console.WriteLine("premere 0 per uscire dal programma: ");
                scelta = Convert.ToInt32(Console.ReadLine());   
            } while (scelta != 0);
            
        }
    }
}
