﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class DelegueManager
    {
        /// <summary>
        /// Permet de retourner une liste de visiteurs pour un région à partir de vaffectation
        /// </summary>
        /// <param name="regionCode">code région</param>
        /// <returns>List<VISITEUR></returns>
        public static List<VISITEUR> ChargerVisiteurByRegion(string regionCode)
        {
            List<VISITEUR> lv = new List<VISITEUR>();
            VISITEUR vis;
            List<VAFFECTATION> lvaff = new VaffectationDAO().FindByRegion(regionCode);
            foreach (VAFFECTATION vaff in lvaff)
            {
                vis = new VisiteurDAO().FindById(vaff.VIS_MATRICULE);
                lv.Add(vis);
            }
            return lv;
        }

        /// <summary>
        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(string code)
        {
            //Charger les rapports terminés et non lus (état = 2 ) des visiteurs d'une région
            List<RAPPORT_VISITE> lr;
            List<int> le = new List<int>();
            le.Add(2);
            lr = new RapportVisiteDAO().FindByEtatEtRegion(le, code);
            return lr;
        }

        /// <summary>
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(string code)
        {
            // Charger les rapports terminés (état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lr;
            List<int> le = new List<int>();
            le.Add(3);
            lr = new RapportVisiteDAO().FindByEtatEtRegion(le, code);
            return lr;
        }
    }
}
