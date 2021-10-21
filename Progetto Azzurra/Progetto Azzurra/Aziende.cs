using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Azzurra
{
    public class Aziende
    {
        public string username { get; set; }
        public string password { get; set; }
        public string codiceAteco { get; set; }
        public string cellulare { get; set; }
        public string ufficioDiSede { get; set; }
        public string ufficioDiSedeLegale { get; set; }
        public string PIva { get; set; }
        public string CodiceFiscaleRappresentanteLegale { get; set; }
        public string visuraCamerale { get; set; }
        public int numeroDiSede { get; set; }
        public string nome { get; set; }
        public string ragioneSociale { get; set; }


        public Aziende(string username, string password, string codiceAteco, string cellulare, string ufficioDiSede, string ufficioDiSedeLegale, string PIva, string codiceFiscaleRappresentanteLegale, string visuraCamerale, int numeroDiSede, string nome, string ragioneSociale)
        {
            this.username = username;
            this.password = password;
            this.codiceAteco = codiceAteco;
            this.cellulare = cellulare;
            this.ufficioDiSede = ufficioDiSede;
            this.ufficioDiSedeLegale = ufficioDiSedeLegale;
            this.PIva = PIva;
            this.CodiceFiscaleRappresentanteLegale = codiceFiscaleRappresentanteLegale;
            this.visuraCamerale = visuraCamerale;
            this.numeroDiSede = numeroDiSede;
            this.nome = nome;
            this.ragioneSociale = ragioneSociale;
        }
    }
}
