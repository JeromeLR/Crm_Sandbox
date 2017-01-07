using System.Collections.Generic;
using System.Linq;
using DAL.Entities;

namespace DAL.Domaine
{
    public interface IDomaineSociete
    {
        List<Societe> GetAllSocietes();
        Societe GetSocieteByNom(string nom);
        Societe GetSocieteById(int id);
        Societe Add(Societe a);
        bool Del(int id);
        void Update(Societe societe);
    }

    /// <summary>
    /// Domaine Client
    /// </summary>
    public class DomaineSociete : IDomaineSociete
    {
        /// Retourne tous les clients
        /// </summary>
        /// <returns>liste de clients</returns>
        public List<Societe> GetAllSocietes()
        {
            List<Societe> societes;
            using (var db = new modelEntities1())
            {
                societes = db.Societe.ToList();
            }
            return societes;
        }

        /// <summary>
        /// Retourne un client par son nom
        /// </summary>
        /// <param name="nom"></param>
        /// <returnsSociete>client</returns>
        public Societe GetSocieteByNom(string nom)
        {
            Societe societe;
            using (var db = new modelEntities1())
            {
                societe = db.Societe.First(c => c.Nom == nom);
            }
            return societe;
        }

        /// <summary>
        /// Retourne un Societe par son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>client</returns>
        public Societe GetSocieteById(int id)
        {
            Societe societe;
            using (var db = new modelEntities1())
            {
                societe = db.Societe.First(c => c.Id == id);
            }
            return societe;
        }

        public Societe Add(Societe c)
        {
            var newSociete = new Societe
            {
                //Id = c.Id,
                Nom=c.Nom,
                Guid = c.Guid,
                CodePostal = c.CodePostal,
                AdresseLigne1 = c.AdresseLigne1,
                AdresseLigne2 = c.AdresseLigne2,
                Ville = c.Ville,
            };
            using (var db = new modelEntities1())
            {
                db.Societe.Add(newSociete);
                db.SaveChanges();
            }
            return newSociete;
        }

        public bool Del(int id)
        {
            var societe = GetSocieteById(id);
            using (var db = new modelEntities1())
            {

                db.Societe.Attach(societe);
                db.Societe.Remove(societe);
                db.SaveChanges();
                return true;
            }
        }

        public void Update(Societe societe)
        {
            using (var db = new modelEntities1())
            {
                var original = db.Societe.Find(societe.Id);

                if (original != null)
                {
                    db.Entry(original).CurrentValues.SetValues(societe);
                    db.SaveChanges();
                }
            }

        }
    }
}
