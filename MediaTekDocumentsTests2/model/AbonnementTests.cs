using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.model.Tests
{
    [TestClass()]
    public class AbonnementTests
    {
        private const string id = "1";
        private static DateTime dateCommande = DateTime.Parse("2022-02-16");
        private const string montant = "12";
        private static DateTime dateFinAbonnement = DateTime.Parse("2023-02-16");
        private const string idRevue = "10004";
        private const string titre = "Carré";
        private static readonly Abonnement abonnement = new Abonnement(id, dateCommande, montant, dateFinAbonnement, idRevue, titre);
        [TestMethod()]
        public void AbonnementTest()
        {
            Assert.AreEqual(id, abonnement.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, abonnement.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, abonnement.Montant, "devrait réussir : montant valorisé");
            Assert.AreEqual(dateFinAbonnement, abonnement.DateFinAbonnement, "devrait réussir : dateFinAbonnement valorisé");
            Assert.AreEqual(idRevue, abonnement.IdRevue, "devrait réussir : idRevue valorisé");
            Assert.AreEqual(titre, abonnement.Titre, "devrait réussir : titre valorisé");
        }
    }
}