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
    public class MotifVisiteDAO
    {
        /// <summary>
        /// Permet de charger un motif de visite par son libellé
        /// <param code="MOT_LIBEL">Motif libellé</param>
        /// </summary>
        /// <returns>MOTIF_VISITE</returns>
        public MOTIF_VISITE FindById(string code)
        {
            MOTIF_VISITE lmv = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          where m.MOT_LIBEL == code
                          select m;
                lmv = req.SingleOrDefault<MOTIF_VISITE>();
            }
            return lmv;
        }

        /// <summary>
        /// Permet de charger tous les motifs visites
        /// </summary>
        /// <returns>List MOTIF_VISITE</returns>
        public List<MOTIF_VISITE> FindAll()
        {
            List<MOTIF_VISITE> lmv = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE
                          select m;
                lmv = req.ToList<MOTIF_VISITE>();

            }
            return lmv;
        }
    }
}
