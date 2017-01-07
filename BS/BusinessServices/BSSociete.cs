using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using BS.BSExtension;

namespace BS.BusinessServices
{
    public interface IBSSociete
    {
        TOSociete GetSocieteById(int id);
        TOSociete GetSocieteByNom(string nom);
        List<TOSociete> GetAllSocietes();
        TOSociete Add(TOSociete toSociete);
        bool Del(int id);
        void Update(TOSociete toSociete);
    }

    public class BSSociete : IBSSociete
    {
        private BusinessService Service;

        public BSSociete(BusinessService bs)
        {
            Service = bs;
        }            

        public TOSociete GetSocieteById(int id)
        {
            var societe = Service.DomaineSociete.GetSocieteById(id);
            return societe.ToTransferObject();
        }


        public TOSociete GetSocieteById_testMoq(int id)
        {
            var societe = Service.DomaineSociete.GetSocieteById(id);
            societe.Nom = "nouveau nom!";
            return societe.ToTransferObject();
        }


        public TOSociete GetSocieteByNom(string nom)
        {
            var societe = Service.DomaineSociete.GetSocieteByNom(nom);
            return societe.ToTransferObject();
        }

        public List<TOSociete> GetAllSocietes()
        {
            var societe = Service.DomaineSociete.GetAllSocietes();
           
            return societe.ToTransferObject();
        }

        public TOSociete Add(TOSociete toSociete)
        {
            var societe = Service.DomaineSociete.Add(toSociete.ToEntity());
            return societe.ToTransferObject();
        }

        public bool Del(int id)
        {
            var societe = Service.DomaineSociete.Del(id);
            return true;
        }

        public void Update(TOSociete toSociete)
        {
            Service.DomaineSociete.Update(toSociete.ToEntity());
        }
    }
}
