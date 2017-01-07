using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BS.BSExtension
{
    public static class SocieteTransferObject
    {
        /// <summary>
        /// Transforme un Societe en ToSociete
        /// </summary>
        /// <param name="typeProjet"></param>
        /// <returns></returns>
        public static TOSociete ToTransferObject(this Societe societe)
        {
            if (societe == null)
            {
                return null;
            }

            TOSociete a = new TOSociete();

            a.Identifiant = societe.Id;
            a.Nom = societe.Nom;
            a.Guid = societe.Guid;
            a.TelephoneStandard = societe.TelephoneStandard;
            a.AdresseLigne1 = societe.AdresseLigne1;
            a.AdresseLigne2 = societe.AdresseLigne2;
            a.CodePostal = societe.CodePostal;
            a.Ville = societe.Ville;
            a.SiteWeb = societe.SiteWeb;
            a.EMail = societe.EMail;
            a.Remarque = societe.Remarque;


            return a;
        }

        public static List<TOSociete> ToTransferObject(this List<Societe> listSociete)
        {
            List<TOSociete> listeToA = new List<TOSociete>();
            foreach (var toC in listSociete)
            {
                listeToA.Add(toC.ToTransferObject());
            };

            return listeToA;

            //return listSociete.Select(c => c.ToTransferObject()).ToList();
        }
    }
}
