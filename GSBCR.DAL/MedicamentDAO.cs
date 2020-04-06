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
    public class MedicamentDAO
    {
        /// <summary>
        /// Permet de rechercher un médicamennt par son nom de dépot
        /// </summary>
        /// <param depot="MED_DEPOTLEGAL">Dépot d'un médicament</param>
        /// <returns>MEDICAMENT</returns>
        public MEDICAMENT FindById(string depot)
        {
            MEDICAMENT med = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MEDICAMENTs.Include("LaFamille")
                          where m.MED_DEPOTLEGAL == depot
                          select m;
                med = req.SingleOrDefault<MEDICAMENT>();

            }
            return med;
        }

        /// <summary>
        /// Permet de charger tous les médicaments
        /// </summary>
        /// <returns>List MEDICAMENT</returns>
        public List<MEDICAMENT> FindAll()
        {
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MEDICAMENTs.Include("LaFamille")
                          select m;
                meds = req.ToList<MEDICAMENT>();

            }
            return meds;
            
        }

        /// <summary>
        /// Permet de charger tous les médicaments d'une famille
        /// <param code="FAM_CODE">Code famillet</param>
        /// </summary>
        /// <returns>List MEDICAMENT</returns>
        public List<MEDICAMENT> FindByFamille(string code)
        {
            //charger tous les médicaments d'une famille
            List<MEDICAMENT> meds = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MEDICAMENTs.Include("LaFamille")
                          where m.FAM_CODE == code
                          select m;
                meds = req.ToList<MEDICAMENT>();
            }
                return meds;
        }
    }
}
