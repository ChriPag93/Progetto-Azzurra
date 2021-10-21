using System;
using System.Collections.Generic;

namespace Progetto_Azzurra
{
    public class Amministratori
    {
        public string nome { set; get; }
        public string email { set; get; }
        public string password { set; get; }
        public List<Operatori> Operatori { get; set; }
        public List<Utenti> Utenti { get; set; }
        public List<Aziende> Aziende { get; set; }
        public void AddUtenti(Utenti Utenti)
        {
            this.Utenti.Add(Utenti);
        }
        public void AddAziende(Aziende Aziende)
        {
            this.Aziende.Add(Aziende);
        }
        public void RemoveUtenti(string CodiceFiscale)
        {
            this.Utenti.RemoveAll(x => x.CodiceFiscale == CodiceFiscale);
        }
        public void RemoveAziende(string CodiceFiscaleRappresentanteLegale)
        {
            this.Aziende.RemoveAll(x => x.CodiceFiscaleRappresentanteLegale == CodiceFiscaleRappresentanteLegale);
        }
    }

}

