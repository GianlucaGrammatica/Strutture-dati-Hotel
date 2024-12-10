using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutture_dati_Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Inserire almeno 5 prenotazioni casuali nel Min Heap.
                Visualizzare la prenotazione con la data più vicina utilizzando VisualizzaMinimo().
                Estrarre e stampare le prenotazioni in ordine di data utilizzando EstraiMinimo() fino a svuotare il Min Heap.
            */

            Random Random = new Random();
            MinHeap ListaPrenotazioni = new MinHeap();

            for (int i = 0; i < 5; i++)
            {
                ListaPrenotazioni.Inserisci($"Cliente{i + 1}", RandomDate.GetRandomDate(Random));
            }

            Console.WriteLine(ListaPrenotazioni.StampaHeap());

            Console.ReadKey();  
        }        
    }

    public static class RandomDate
    {
        public static DateTime GetRandomDate(this Random random, int minYear = 2024, int maxYear = 2034)
        {
            var year = random.Next(minYear, maxYear);
            var month = random.Next(1, 12);
            var noOfDaysInMonth = DateTime.DaysInMonth(year, month);
            var day = random.Next(1, noOfDaysInMonth);

            return new DateTime(year, month, day);
        }
    }
}
