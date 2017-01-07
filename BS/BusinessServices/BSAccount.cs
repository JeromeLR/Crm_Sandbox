using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using BS.BSExtension;

namespace BS.BusinessServices
{
    public interface IBSAccount
    {
        TOSociete GetAccountById(int id);
        TOSociete GetAccountByNom(string nom);
        List<TOSociete> GetAllAccounts();
        TOSociete Add(TOSociete toSociete);
        bool Del(int id);
        void Update(TOSociete toSociete);
    }

    public class BSAccount : IBSAccount
    {
        private BusinessService Service;

        public BSAccount(BusinessService bs)
        {
            Service = bs;
        }            

        public TOSociete GetAccountById(int id)
        {
            var societe = Service.DomaineSociete.GetSocieteById(id);
            return societe.ToTransferObject();
        }
        
        public TOSociete GetAccountByNom(string nom)
        {
            var societe = Service.DomaineSociete.GetSocieteByNom(nom);
            return societe.ToTransferObject();
        }

        public List<TOSociete> GetAllAccounts()
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
