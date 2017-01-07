using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Domaine;
using DAL;
using BS.BusinessServices;


// todo Question : appel d'un BS à partir d'un autre : passer par les domaines de la DAL ?
// todo Factorisation des BS ?
// todo MVC : bonne définitions des modèles ?


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


        public IDomaineSociete DomaineSociete;
        public BSSociete Societe { get; private set; }

        


        //unity : private=>public
        public BusinessService()
        {
            DomaineSociete = new DAL.Domaine.DomaineSociete();
            Societe = new BSSociete(this);

           
        }
    }
}
