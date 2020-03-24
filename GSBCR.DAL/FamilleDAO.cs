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
    public class FamilleDAO
    {
        /// <summary>
        /// Permet de rechercher une famille de médicament par son nom
        /// </summary>
        /// <param name="FAM_LIBELLE">Libelle d'une famille</param>
        /// <returns>FAMILLE</returns>
        public FAMILLE FindById(string libelleFamille)
        {
            FAMILLE fam = null;
            using ( var context = new GSB_VisiteEntities())
            {
                var req = from f in context.FAMILLEs.Include("LesMedicaments")
                          where f.FAM_LIBELLE.Contains(libelleFamille)
                          select f;
                fam = req.SingleOrDefault<FAMILLE>();
            }
            return fam;
        }

        /// <summary>
        /// Permet de charger toutes les familles de médicaments
        /// </summary>
        /// <returns>FAMILLE</returns>
        public List<FAMILLE> FindAll()
        {
            List<FAMILLE> fam = null;
            using( var context = new GSB_VisiteEntities())
            {
                var req = from f in context.FAMILLEs.Include("LesMedicaments")
                          select f;
                fam = req.ToList<FAMILLE>();
            }
            return fam;
        }

    }
}
