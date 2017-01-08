using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO;
using BS.BSExtension;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using _4_DAL_CRM;

namespace BS.BusinessServices
{
    public interface IBSAccount
    {
        //TOSociete GetAccountByGuid(Guid guid);
    }

    public class BSAccount : IBSAccount
    {
        private BusinessService Service;

        public OrganizationServiceProxy serviceCrm;

        public IOrganizationService seriveCRM2 { get; set; }

        public BSAccount(IOrganizationService service)
        {
            this.serviceCrm = serviceCrm;
            this.seriveCRM2 = seriveCRM2;
        }

        public BSAccount(BusinessService bs)
        {
            Service = bs;
        }

        public TOSociete GetAccountByGuid(Guid guid, IOrganizationService orgnaisationService)
        {
            Account account = Service.DomaineAccount.RetrieveByGuid(guid, orgnaisationService);

            return account.ToTransferObject();
        }

        public void UpdateAccount(Account account, IOrganizationService orgnaisationService)
        {

            Service.DomaineAccount.Update(account, orgnaisationService);

        }

    }
}
