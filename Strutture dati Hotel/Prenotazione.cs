using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strutture_dati_Hotel
{
    internal class Prenotazione
    {
        /*
            Ogni prenotazione deve contenere:
            - NomeCliente (stringa): il nome del cliente.
            - DataArrivo (DateTime): la data di arrivo del cliente.
            - Fornire un metodo ToString() per stampare i dati della prenotazione in formato leggibile.
        */

        public string NomeCliente;
        public DateTime DataArrivo;

        public Prenotazione() 
        {
            
            NomeCliente = "";
            DataArrivo = DateTime.Now;

        }

        public Prenotazione(string nomeCliente, DateTime dataArrivo) 
        {            
            NomeCliente = nomeCliente;
            DataArrivo = dataArrivo;
        }

        public override string ToString()
        {
            string toReturn = $"{NomeCliente} - {DataArrivo}";

            return toReturn;
        }
    }
}
