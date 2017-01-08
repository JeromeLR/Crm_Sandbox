using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using _4_DAL_CRM;

namespace BS.BSExtension
{
    public static class AccountTransferObject
    {
        /// <summary>
        /// Transforme un Societe en ToSociete
        /// </summary>
        /// <param name="typeProjet"></param>
        /// <returns></returns>
        public static TOSociete ToTransferObject(this Account account)
        {
            if (account == null)
            {
                return null;
            }

            TOSociete a = new TOSociete();

            //a.Identifiant = account.Id;
            a.Nom = account.Name;
            a.Guid = account.Id.ToString();
            a.TelephoneStandard = account.Address1_Telephone1;
            a.AdresseLigne1 = account.Address1_Line1;
            a.AdresseLigne2 = account.Address1_Line2;
            a.CodePostal = account.Address1_PostalCode;
            a.Ville = account.Address1_City;
            a.SiteWeb = account.WebSiteURL;
            a.EMail = account.EMailAddress1;
            a.Remarque = account.Description;


            return a;
        }

        public static List<TOSociete> ToTransferObject(this List<Account> listSociete)
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
