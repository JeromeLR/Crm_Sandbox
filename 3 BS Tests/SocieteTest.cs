//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BS;
using DAL.Domaine;
using DAL.Entities;
using Moq;
using NUnit;
using NUnit.Framework;


namespace _3_BS_Tests
{
    [TestFixture]
    public class SocieteTests
    {
        //private BusinnessServiceCRM bs;

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreateSociete()
        {
            var bs = BusinessService.Instance;

            var a = bs.Societe.GetSocieteById(1);

            NUnit.Framework.Assert.AreEqual(a.Nom, "Vicco");
        }

        [Test]
        public void CreateArticle_MOQ()
        {
            // moq domainearticle
            var mockDomaineSociete = new Mock<IDomaineSociete>();
            //initmoq
            mockDomaineSociete.Setup(x => x.GetSocieteById(It.IsAny<int>())).Returns(new Societe
            {
                Nom = "Corp",
                CodePostal = "36542",
                EMail = "test@test.com"
            });


            var bs = BusinessService.Instance;
            bs.DomaineSociete = mockDomaineSociete.Object;

            var a = bs.Societe.GetSocieteById(1);

            Assert.AreEqual(a.Nom, "Corp");
        }

      
    }

}
