﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GSBCR.modele;
using GSBCR.BLL;
using System.Collections.Generic;

namespace UnitTestGSBCR
{
    [TestClass]
    public class UnitVisiteurManager
    {
        [TestMethod]
        public void TestChargerVisiteur()
        {
            VISITEUR v = VisiteurManager.ChargerVisiteur("a131", "30BFD069");
            Assert.IsNotNull(v, "le visiteur a131 mdp 30BFD069 non chargé");
            VISITEUR v1 = VisiteurManager.ChargerVisiteur("a131", "");
            Assert.IsNull(v1, "le visiteur a131 est chargé sans mot de passe");
        }

        [TestMethod]
        public void TestChargerRapportVisiteurEnCours()
        {
            bool ok = false;
            List<RAPPORT_VISITE> lr = VisiteurManager.ChargerRapportVisiteurEncours("a131");
            foreach (RAPPORT_VISITE r in lr)
            {
                Assert.AreEqual("a131", r.RAP_MATRICULE, "le rapport n''appartient pas au matricule a131");
                Assert.AreEqual("1", r.RAP_ETAT, "état rapport différent de en cours (1)");
                ok = (r.RAP_NUM >= 57 && r.RAP_NUM <= 62);
                Assert.IsTrue(ok, "n° de rapport faux");
            }

        }
        [TestMethod]
        public void TestChargerAffectationVisiteur()
        {

        }
    }
}
