using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class Enum
    {
        public enum Provenance
        {
            Base = 1,
            CRM = 2
        };
    }

    public class TOSociete
    {
        public int Identifiant { get; set; }
        public string Guid { get; set; }
        public string TelephoneStandardGuid { get; set; }
        public string Nom { get; set; }
        public string TelephoneStandard { get; set; }
        public string AdresseLigne1 { get; set; }
        public string AdresseLigne2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string SiteWeb { get; set; }
        public string EMail { get; set; }
        public string Remarque { get; set; }

        public Enum.Provenance provenance { get; set; }
    }
}
