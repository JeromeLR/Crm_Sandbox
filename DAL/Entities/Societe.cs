//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Societe
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Nom { get; set; }
        public string TelephoneStandard { get; set; }
        public string AdresseLigne1 { get; set; }
        public string AdresseLigne2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string SiteWeb { get; set; }
        public string EMail { get; set; }
        public string Remarque { get; set; }
    }
}
