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
    public class CommandeTests
    {
        private const string id = "1";
        private static DateTime dateCommande = DateTime.Parse("2022-02-16");
        private const string montant = "12";
        private static readonly Commande commande = new Commande(id, dateCommande, montant); 

        [TestMethod()]
        public void CommandeTest()
        {
            Assert.AreEqual(id, commande.Id, "devrait réussir : id valorisé");
            Assert.AreEqual(dateCommande, commande.DateCommande, "devrait réussir : dateCommande valorisé");
            Assert.AreEqual(montant, commande.Montant, "devrait réussir : montant valorisé");
        }
    }
}