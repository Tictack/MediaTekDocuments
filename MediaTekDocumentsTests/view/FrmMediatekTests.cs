using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaTekDocuments.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTekDocuments.view.Tests
{
    [TestClass()]
    public class FrmMediatekTests
    {
        private DateTime dateAchat = DateTime.Parse("2021-12-01");
        private DateTime dateFinAbonnement = DateTime.Parse("2023-12-01");
        private DateTime dateParution = DateTime.Parse("2022-12-01");
        [TestMethod()]
        public void TestMethodes()
        {
            bool reponseCode = ParutionDansAbonnement(dateFinAbonnement)
        }
    }
}