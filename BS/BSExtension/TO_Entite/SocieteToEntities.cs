using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;

namespace BS.BSExtension
{
    public static class SocieteToEntities
    {
        /// <summary>
        /// Transforme le TO en Entity
        /// </summary>
        /// <param name="listeToCommande">Tranfert Object</param>
        /// <returns>The Entity</returns>
        public static Societe ToEntity(this TOSociete toSociete)
        {
            if (toSociete == null)
            {
                return null;
            }

            Societe entity = new Societe();

            entity.Id = toSociete.Identifiant;
            entity.Guid = toSociete.Guid;

            entity.Nom = toSociete.Nom;
            entity.TelephoneStandard = toSociete.TelephoneStandard;
            entity.AdresseLigne1 = toSociete.AdresseLigne1;
            entity.AdresseLigne2 = toSociete.AdresseLigne2;
            entity.Remarque = toSociete.Remarque;
            entity.CodePostal = toSociete.CodePostal;
            entity.Ville = toSociete.Ville;
            entity.SiteWeb = toSociete.SiteWeb;
            entity.EMail = toSociete.EMail;

           
          
            return entity;
        }
    }
}
