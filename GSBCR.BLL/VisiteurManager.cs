﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using GSBCR.DAL;

namespace GSBCR.BLL
{
    public static class VisiteurManager
    {
         /// <summary>
        /// Permet de charger un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <param name="mdp">mot de passe Visiteur</param>
        /// <returns>objet VISITEUR</returns>
        public static VISITEUR ChargerVisiteur(string matricule, string mdp)
        {
            VISITEUR vis = new VisiteurDAO().FindById(matricule);
            if ((vis != null) && (vis.vis_mdp == mdp))
                return vis;
            else
                return null;

        }

        /// <summary>
        /// Permet de charger la dernière affectation du visiteur
        /// et donc son profil (visiteur, délégué, responsabe secteur) et sa région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>objet VAFFECTATION</returns>
        public static VAFFECTATION ChargerAffectationVisiteur(string matricule)
        {
            VAFFECTATION vaff = new VaffectationDAO().FindByMatricule(matricule);
            return vaff;
        }

        /// Permet de charger les rapports non terminés du visiteur (état 1)
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE></returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurEncours(string m)
        {
            List<RAPPORT_VISITE> lr;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            le.Add(1);
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }

        /// Permet de charger un rapport de visite
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public static RAPPORT_VISITE ChargerRapportVisite(string m, int n)
        {
            RAPPORT_VISITE r = new RapportVisiteDAO().FindById(m, n);
            return r;
        }

        /// Permet de charger les rapports terminés du visiteur (état 2 et 3) 
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportVisiteurFinis(string m)
        {
            //Charger les rapports terminés (état = 2 ou 3) du visiteur
            List<RAPPORT_VISITE> rv;
            List<string> lm = new List<string>();
            lm.Add(m);
            List<int> le = new List<int>();
            //le.AddRange(new int[] { 2, 3 });
            le.Add(2);
            le.Add(3);
            rv = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return rv;
        }

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

        /// Permet de charger les rapports non consultés (état 2) des visiteurs d'une région  
        /// </summary>
        /// <param name="code">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionNonLus(string code)
        {
            List<RAPPORT_VISITE> lr = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(code);
            List<string> lm = new List<string>();
            List<int> le = new List<int>();
            le.Add(2);
            foreach (VISITEUR v in lv)
            {
                lm.Add(v.VIS_MATRICULE);
            }
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }
    
        /// Permet de charger les rapports terminés et consultés (état 3) des visiteurs d'une région 
        /// </summary>
        /// <param name="r">code région</param>
        /// <returns>List<RAPPORT_VISITE>/returns>
        public static List<RAPPORT_VISITE> ChargerRapportRegionLus(string code)
        {
            // Charger les rapports terminés(état = 3) des visiteurs d'une région
            List<RAPPORT_VISITE> lr = new List<RAPPORT_VISITE>();
            List<VISITEUR> lv = ChargerVisiteurByRegion(code);
            List<string> lm = new List<string>();
            List<int> le = new List<int>();
            le.Add(3);
            foreach (VISITEUR v in lv)
            {
                lm.Add(v.VIS_MATRICULE);
            }
            lr = new RapportVisiteDAO().FindByEtatEtVisiteur(lm, le);
            return lr;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void CreateRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().insert(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données 
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public static void MajRapport(RAPPORT_VISITE r)
        {
            try
            {
                new RapportVisiteDAO().update(r);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        /// <summary>
        /// Permet de charger un médicament à partir de son nom de dépot légal
        /// </summary>
        /// <param name="depot">chaine caractères</param>
        public static MEDICAMENT ChargerLeMedicament(string depot)
        {
            MEDICAMENT l = new MedicamentDAO().FindById(depot);
            return l;
        }

        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        public static List<MEDICAMENT> ChargerMedicaments()
        {
            List<MEDICAMENT> lm = new MedicamentDAO().FindAll();
            return lm;
        }

        /// <summary>
        /// Permet de charger tous les motifs visite
        /// </summary>
        public static List<MOTIF_VISITE> ChargerMotifVisites()
        {
            List<MOTIF_VISITE> lm = new MotifVisiteDAO().FindAll();
            return lm;
        }

        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        public static List<PRATICIEN> ChargerPraticiens()
        {
            List<PRATICIEN> lp = new PratricienDAO().FindAll();
            return lp;
        }

        /// <summary>
        /// Permet de charger un praticien à partir de son numéro
        /// <param name="pranum">entier</param>
        /// </summary>
        public static PRATICIEN ChargerLePraticien(Int16 pranum)
        {
            //Charger un praticien via son numéro
            PRATICIEN pra = new PratricienDAO().FindById(pranum);
            return pra;
        }

        /// <summary>
        /// Permet de mettre à jour un visiteur dans la base de données 
        /// </summary>
        /// <param name="v">objet visiteur</param>
        public static void MajVisiteur(VISITEUR v)
        {
            //ew VisiteurDAO().update(v);

            try
             {
                 new VisiteurDAO().update(v);
             }
             catch (Exception ex)
             {

                 throw ex;
             }

        }

        /// <summary>
        /// Permet de créer un visiteur dans la base de données 
        /// </summary>
        /// <param name="v">objet visiteur</param>
        public static void CreateVisiteur(VISITEUR v)
        {
            try
            {
                new VisiteurDAO().insert(v);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<RAPPORT_VISITE> GetRapportValideByMedoc(String numMed, string mat)
        {
            try
            {
               return new RapportVisiteDAO().FindByMedoc(numMed, mat);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<RAPPORT_VISITE> GetRapportValideByPratricien(String numPra, string mat)
        {
            try
            {
                return new RapportVisiteDAO().FindBypratricien(numPra, mat);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<REGION> GetRegion()
        {
            try
            {
                return new RegionDAO().FindAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<SECTEUR> GetSecteur()
        {
            try
            {
                return new SecteurDAO().FindAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void CreateTravailler(TRAVAILLER v)
        {
            try
            {
                new TravaillerDAO().insert(v);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
