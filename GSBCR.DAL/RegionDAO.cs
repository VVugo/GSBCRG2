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
        public REGION FindById(string code)
        {
            //Rechercher une région par son nom
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

        public List<REGION> FindAll()
        {
            //Charger toutes les régions
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
