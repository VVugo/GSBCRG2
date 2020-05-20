using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace GSBCR.DAL
{
    public class RapportVisiteDAO
    {
        /// <summary>
        /// Permet de retourner un rapport de visite en connaissant son id
        /// </summary>
        /// <param name="m">matricule Visiteur</param>
        /// <param name="n">numéro rapport</param>
        /// <returns>RAPPORT_VISITE</returns>
        public RAPPORT_VISITE FindById(string m, int n)
        {
            RAPPORT_VISITE rv =null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.RAPPORT_VISITE
                          where r.RAP_MATRICULE == m && r.RAP_NUM == n
                          select r;
                rv = req.SingleOrDefault<RAPPORT_VISITE>();
                
            }
            return rv;

        }

        /// <summary>
        /// Permet de créer une liste avec tous les rapports de visite de visiteurs qui ont un certain état
        /// </summary>
        /// <param name="lesMatricules">Liste de matricule (string)</param>
        /// <param name="lesEtats">Liste d'états (int)</param>
        /// <returns></returns>
        public List<RAPPORT_VISITE> FindByEtatEtVisiteur(List<string> lesMatricules, List<int> lesEtats)
        {
            List<RAPPORT_VISITE> lesRapports = null;
            using (var context = new GSB_VisiteEntities())
            {
                int i = 0;
                string reqStr = "select * from RAPPORT_VISITE r where r.RAP_MATRICULE in(";
                foreach (string m in lesMatricules)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += "'" + m + "'";
                }
                reqStr += ") and r.RAP_ETAT in(";
                i = 0;
                foreach (int e in lesEtats)
                {
                    if (i != 0)
                        reqStr += ",";
                    else
                        i++;
                    reqStr += e ;
                }
                reqStr += ")";
                lesRapports = context.RAPPORT_VISITE.SqlQuery(reqStr).ToList<RAPPORT_VISITE>();
                
            } 
            return lesRapports;
        }

        /// <summary>
        /// Permet de créer un rapport dans la base de données par appel de la procédure stockée addRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void insert(RAPPORT_VISITE r)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    context.RAPPORT_VISITE.Add(r);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                } 
            }

        }

         /// <summary>
        /// Permet de mettre à jour un rapport dans la base de données par appel de la procédure stockée updRapport
        /// </summary>
        /// <param name="r">objet rapport de visite</param>
        public void update(RAPPORT_VISITE r)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    context.Entry(r).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
                
            }
        }

        public List<RAPPORT_VISITE> FindByMedoc(String numMedoc)
        {
            List<RAPPORT_VISITE> rv = null;
            using (var context = new GSB_VisiteEntities())
            {
                string rqt = "select * from RAPPORT_VISITE where RAP_MED1 like @NUM_MED or RAP_MED2 like @NUM_MED ";
                rv = context.RAPPORT_VISITE.SqlQuery(rqt, new SqlParameter("NUM_MED", numMedoc)).ToList<RAPPORT_VISITE>();

            }
            return rv;

        }

        public List<RAPPORT_VISITE> FindBypratricien(String numPra)
        {
            List<RAPPORT_VISITE> rv = null;
            using (var context = new GSB_VisiteEntities())
            {
                string rqt = "select * from RAPPORT_VISITE where RAP_PRANUM like @NUM_PRA";
                rv = context.RAPPORT_VISITE.SqlQuery(rqt, new SqlParameter("NUM_PRA", numPra)).ToList<RAPPORT_VISITE>();

            }
            return rv;

        }


    }
}
