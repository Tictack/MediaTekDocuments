﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.controller.Tests
{
    [TestClass()]
    public class FrmMediatekControllerTests
    {

        private readonly FrmMediatekController controller = new FrmMediatekController();
        [TestMethod()]
        public void ParutionDansAbonnementTest()
        {
            DateTime dateCommande = new DateTime(2022, 10, 3);
            DateTime dateFinAbonnement = new DateTime(2022, 11, 3);
            DateTime dateParution = new DateTime(2022, 10, 4);
            bool resultatAttendu = true;

            bool resultatActuel = controller.ParutionDansAbonnement(dateCommande, dateFinAbonnement, dateParution);

            Assert.AreEqual(resultatAttendu, resultatActuel);
        }
    }
}