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
    public class RegionDAO
    {

        /// <summary>
        /// Permet de rechercher une région par son nom
        /// </summary>
        /// <param code="REG_NOM">Region nom</param>
        /// <returns>REGION</returns>
        public REGION FindById(string code)
        {
            REGION reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.REGIONs.Include("LeSecteur")
                          where r.REG_NOM.Contains(code)
                          select r;
                reg = req.SingleOrDefault<REGION>();
            }
            return reg;
        }

        /// <summary>
        /// Permet de charger toutes les régions
        /// </summary>
        /// <returns>List REGION</returns>
        public List<REGION> FindAll()
        {
            List<REGION> reg = null;
            using ( var context = new GSB_VisiteEntities())
            {
                var req = from r in context.REGIONs.Include("LeSecteur")
                          select r;
                reg = req.ToList<REGION>();
            }
            return reg;
        }
    }
}
