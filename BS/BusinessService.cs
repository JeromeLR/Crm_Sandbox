using DAL.Domaine;
using BS.BusinessServices;
using Microsoft.Xrm.Sdk.Client;
using _4_DAL_CRM;
using _4_DAL_CRM.Domaine;
using __4_DAL_CRM;

namespace BS
{
    //unity
    public interface IBusinessService
    {
        //private static object instanceVerrou = new object();
    }

    public class BusinessService : IBusinessService
    {
         #region Singleton
        /// <summary>
        /// Singleton
        /// </summary>
        public static BusinessService _instance;

        /// <summary>
        /// Verrou du singleton _instance
        /// </summary>
        private static object instanceVerrou = new object();

        /// <summary>
        /// Accesseur du singleton
        /// </summary>
        public static BusinessService Instance
        {
            get
            {
                lock (instanceVerrou)
                {
                    if (_instance == null)
                    {
                        _instance = new BusinessService();
                    }

                    return _instance;
                }
            }
        }

        #endregion

        #region Base

        public IDomaineSociete DomaineSociete;
        public BSSociete Societe { get; private set; }

        #endregion Base

        #region CRM

        public IDomaineAccount DomaineAccount;
        public BSAccount Account { get; set; }

        
        #endregion CRM

        //unity : private=>public
        public BusinessService()
        {
            DomaineSociete = new DomaineSociete();
            Societe = new BSSociete(this);

            DomaineAccount = new DomaineAccount();
            Account = new BSAccount(this);

            
        }
    }
}
