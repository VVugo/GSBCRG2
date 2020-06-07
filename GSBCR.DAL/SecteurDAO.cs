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
    public class SecteurDAO
    {

        /// <summary>
        /// Permet de charger touts les secteurs
        /// </summary>
        /// <returns>List SECTEUR</returns>
        public List<SECTEUR> FindAll()
        {
            List<SECTEUR> reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from r in context.SECTEURs
                          select r;
                reg = req.ToList<SECTEUR>();
            }
            return reg;
        }
    }
}
