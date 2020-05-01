using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace GSBCR.DAL
{
    public class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEURs
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }



        /// <summary>
        /// Permet de mettre à jour un visiteur dans la base de données par appel de la procédure stockée updInfoVisiteur
        /// </summary>
        /// <param name="v">objet visiteur</param>
        public void update(VISITEUR v)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    context.Entry(v).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }

        /// <summary>
        /// Permet de créer un visiteur dans la base de données par appel de la procédure stockée addVisiteur
        /// </summary>
        /// <param name="v">objet visiteur</param>
        public void insert(VISITEUR v)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    context.VISITEURs.Add(v);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
