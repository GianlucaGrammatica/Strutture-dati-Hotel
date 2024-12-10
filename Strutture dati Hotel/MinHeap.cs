using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutture_dati_Hotel
{
    internal class MinHeap
    {

        /*
            Classe MinHeap

            Deve essere implementata una struttura dati Min Heap che rispetti le seguenti funzionalità:

                - Inserisci(Prenotazione p): aggiunge una nuova prenotazione nel heap.
                - EstraiMinimo(): rimuove e restituisce la prenotazione con la data di arrivo più vicina.
                - VisualizzaMinimo(): mostra la prenotazione con la data di arrivo più vicina senza rimuoverla.
                - StampaHeap(): stampa tutte le prenotazioni nell'ordine del Min Heap.
        */

        private Prenotazione[] Base = new Prenotazione[4];
        private int Count = 0;
        private int Capacity = 4;

        public MinHeap()
        {
            Count = 0;
        }

        // Gestione Array
        private void IncArray()
        {
            Capacity = Capacity * 2;
            Prenotazione[] newBase = new Prenotazione[Capacity];
            Base.CopyTo(newBase, 0);
            Base = newBase;
            return;
        }

        public bool CheckCapacity(int toCheck)
        {
            if (Capacity <= toCheck)
            {
                IncArray();
            }
            return true;
        }

        // Manipolazione Heap
        public void Inserisci(Prenotazione toAdd)
        {
            Count++;
            if (CheckCapacity(Count))
            {
                Base[Count] = toAdd;
            }

            HeapSort();
            /*
             * Aggiunge in fondo
             * Parte da lì
             * Fa diviso due, +0 o +1
             * se trova un maggiore scambia
             * e procede
             */
        }

        public void Inserisci(string nomeCliente, DateTime dataArrivo)
        {
            Count++;
            if (CheckCapacity(Count))
            {
                Prenotazione newPrenotazione = new Prenotazione(nomeCliente, dataArrivo);
                Base[Count] = newPrenotazione;
            }

            HeapSort();
        }


        // Ordinamento
        private void Heapify(int i)
        {

            int Smallest = i;
            int Left = i * 2;
            int Rigth = i * 2 + 1;


            if (Left < Count && Base[Left].DataArrivo < Base[Smallest].DataArrivo)
            {
                Smallest = Left;
            }

            if (Rigth < Count && Base[Rigth].DataArrivo < Base[Smallest].DataArrivo)
            {
                Smallest = Rigth;
            }


            if (Smallest != i)
            {
                Prenotazione temp = Base[i];
                Base[i] = Base[Smallest];
                Base[Smallest] = temp;

                Heapify(Smallest);
            }
        }

        private void Hepify2(int i)
        {
            //int Smallest = int.Parse(Math.Floor(decimal.Parse(i) / 2));
        }

        void HeapSort()
        {
            for (int i = Count / 2; i >= 1; i--)
            {
                Heapify(i);
            }

            for (int i = Count - 1; i >= 1; i--)
            {

                Prenotazione temp = Base[1];
                Base[1] = Base[i];
                Base[i] = temp;

                Heapify(1);
            }
        }

        // Accesso Heap
        public Prenotazione EstraiMinimo()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }

            Prenotazione min = Base[1];
            Base[1] = Base[Count];
            Count--;

            HeapSort();
            return min;
        }

        public Prenotazione VisualizzaMinimo()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }

            Prenotazione min = Base[1];

            return min;
        }

        public string StampaHeap()
        {
            string toReturn = "-- Prenotazioni --\n\n";

            if (Count <= 0)
            {
                return "empty";
            }

            for (int i = 1; i < Count + 1; i++)
            {
                toReturn += Base[i].ToString() + "\n";
            }

            return toReturn;
        }
    }
}
