//using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.ComponentModel;
using BS;
using BS.BSExtension;
using DAL.Domaine;
using DAL.Entities;
using Microsoft.Xrm.Sdk;
using Moq;
using NUnit;
using NUnit.Framework;
using TO;
using _4_DAL_CRM;
using _4_DAL_CRM.Domaine;


namespace _3_BS_Tests
{
    [TestFixture]
    public class AccountSocieteTests
    {
        private BusinessService bs;
      

        [OneTimeSetUp]
        public void Setup()
        {
            bs = BusinessService.Instance;
        }

        #region Account
        [Test]
        public void TestGetAccountByGuid()
        {
            var serviceMock = new Mock<IOrganizationService>();
            IOrganizationService service = serviceMock.Object;

            var mockDomaineAccount = new Mock<IDomaineAccount>();
            bs.DomaineAccount = mockDomaineAccount.Object;

            Account accountRetourne = new Account
            {
                Name = "Entrprise duchemole",
                Description = "opportunité !"
            };

            mockDomaineAccount.Setup(x => x.RetrieveByGuid(
                It.IsAny<Guid>(),
                It.IsAny<IOrganizationService>())
                ).Returns(accountRetourne);
           
            var accountAChercher = bs.Account.GetAccountByGuid(new Guid("88888888-4444-4444-4444-121212121212"),service);

            Assert.AreEqual("opportunité !", accountAChercher.Remarque);
        }
        #endregion Account

        #region Societe
        [Test]
        public void TestCreerSociete()
        {

            TOSociete societeACreer = new TOSociete
            {
                Nom = "Des clics et des claques",
                Remarque = "dangereux"
            };

            // moq domainearticle
            var mockDomaineSociete = new Mock<IDomaineSociete>();
            //initmoq
            mockDomaineSociete.Setup(x => x.Add(It.IsAny<Societe>()))
                .Returns(new Societe()
                {
                    Nom = "Des clics et des claques",
                    Remarque = "dangereux"
                });

            bs.DomaineSociete = mockDomaineSociete.Object;

            var s = bs.Societe.Add(societeACreer);

            Assert.AreEqual(s.Nom, "Des clics et des claques");
        }
        #endregion Societe

        #region AccountSociete
        [Test]
        public void TestUpdateSociete()
        {
            // mise à jour d'une société avec les nouvelles valeurs CRM
            // ici pas de mock base entity

            var serviceMock = new Mock<IOrganizationService>();
            IOrganizationService service = serviceMock.Object;

            var mockDomaineAccount = new Mock<IDomaineAccount>();
            bs.DomaineAccount = mockDomaineAccount.Object;

            Societe socAmettreAJour = new Societe
            {
                Guid = "88888888-4444-4444-4444-121212121212",
                Nom = "Touiteur",
                AdresseLigne1 = "5 rue des lumières"
            };


            Account accountAJour = new Account
            {
                Id=new Guid("88888888-4444-4444-4444-121212121212"),
                Name = "Twitter",
                Address1_Line1 = "Rue de la Paix"
            };

            mockDomaineAccount.Setup(x => x.RetrieveByGuid(
                new Guid("88888888-4444-4444-4444-121212121212"),
                It.IsAny<IOrganizationService>())
                ).Returns(accountAJour);

          
            bs.Societe.UpdateFromAccount(accountAJour);

            var soc = bs.Societe.GetSocieteByGuid(accountAJour.Id);
            var acc = bs.Account.GetAccountByGuid(accountAJour.Id,service);

            Assert.AreEqual(soc.Nom, acc.Nom);

        }
        #endregion AccountSociete
    }

}
