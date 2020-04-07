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
    public class PratricienDAO
    {
        /// <summary>
        /// Permet de rechercher un praticien par son numéro
        /// </summary>
        /// <param pranum="PRA_NUM">Numéro d'un praticien</param>
        /// <returns>PRATICIEN</returns>
        public PRATICIEN FindById(Int16 pranum)
        {
            PRATICIEN pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from p in context.PRATICIENs
                          where p.PRA_NUM == pranum
                          select p;
                pas = req.SingleOrDefault<PRATICIEN>();
            }
                return pas;
        }

        /// <summary>
        /// Permet de charger tous les praticiens
        /// </summary>
        /// <returns>PRATICIEN</returns>
        public List<PRATICIEN> FindAll()
        {
            List<PRATICIEN> pas = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from p in context.PRATICIENs.Include("LeType")
                          select p;
                pas = req.ToList<PRATICIEN>();

            }
            return pas;
        }

        /// <summary>
        /// Permet de rechercher un praticien en fonction de son type
        /// </summary>
        /// <param code="TYP_CODE">Code type du praticien</param>
        /// <returns>List PRATICIEN</returns>
        public List<PRATICIEN> FindByType(string code)
        {
            //Charger tous les praticiens d'un type
            List<PRATICIEN> pas = null;
            using ( var context = new GSB_VisiteEntities())
            {
                var req = from p in context.PRATICIENs.Include("LeType")
                          where p.TYP_CODE == code
                          select p;
                pas = req.ToList<PRATICIEN>();
            }
            return pas;
        }
    }
}
