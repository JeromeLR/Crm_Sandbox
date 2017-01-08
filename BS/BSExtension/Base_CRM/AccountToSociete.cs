using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using TO;
using _4_DAL_CRM;

namespace BS.BSExtension
{
    public static class MethodeExtentionToEBase
    {
        /// <summary>
        /// Societe CrmData en Societe ERP
        /// </summary>
        /// <param name="CRMSociete"></param>
        /// <returns></returns>
        public static TOSociete TOToBase(this Account societe)
        {
            if (societe != null)
            {
                TOSociete societeERP = new TOSociete
                {
                    Nom = societe.Name,
                    AdresseLigne1 = societe.Address1_Line1,
                    AdresseLigne2 = societe.Address1_Line2,
                    CodePostal = societe.Address1_PostalCode,
                    Ville = societe.Address1_City,
                    TelephoneStandard = societe.Address1_Telephone1,
                    SiteWeb = societe.WebSiteURL,
                    EMail = societe.EMailAddress1,
                    Remarque = societe.Description,
                    Guid = societe.Id.ToString(),

                };

                return societeERP;
            }
            else return null;

        }
        /// <summary>
        /// Societe CrmData en Societe ERP
        /// </summary>
        /// <param name="CRMSociete"></param>
        /// <returns></returns>
        public static Societe toBase(this Account societe)
        {
            if (societe != null)
            {
                Societe societeERP = new Societe
                {
                    Nom = societe.Name,
                    AdresseLigne1 = societe.Address1_Line1,
                    AdresseLigne2 = societe.Address1_Line2,
                    CodePostal = societe.Address1_PostalCode,
                    Ville = societe.Address1_City,
                    TelephoneStandard = societe.Address1_Telephone1,
                    SiteWeb = societe.WebSiteURL,
                    EMail = societe.EMailAddress1,
                    Remarque = societe.Description,
                    Guid = societe.Id.ToString(),

                };

                return societeERP;
            }
            else return null;

        }
    }
}
