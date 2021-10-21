using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Azzurra
{
    public class Utenti
    {
        public string Email { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string Nome { set; get; }
        public string Cognome { set; get; }
        public string DatadiNascita { set; get; }
        public string LuogodiNascita { set; get; }
        public string Nazionalità { set; get; }
        public string Comune { set; get; }
        public string CodiceFiscale { set; get; }
        public string Residenza { set; get; }
        public string Domicilio { set; get; }
        public string Telefono { set; get; }
        public string TitolodiStudio { set; get; }
        public string Patente { set; get; }
        public bool AutoMunito { set; get; }
        public bool CategoriaProtetta { set; get; }
        public string EsperienzaLavorativa { set; get; }
        public string Conoscenzelinguistiche { set; get; }
        public string ConoscenzeInformatiche { set; get; }
        public string SettoreDiInteresse { set; get; }
        public bool DisponibilitàAlTrasferimento { set; get; }
        public bool Sesso { set; get; }
        public bool DurataDelContratto { set; get; }
    }
}
