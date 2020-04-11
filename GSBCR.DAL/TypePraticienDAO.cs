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
    public class TypePraticienDAO
    {

        /// <summary>
        /// Permet de rechercher un type de praticien avec son code
        /// </summary>
        /// <param code="TYP_CODE">Type code praticien</param>
        /// <returns>TYPE PRATICIEN</returns>
        public TYPE_PRATICIEN FindById(string code)
        {
            TYPE_PRATICIEN typ = null;
            using ( var context = new GSB_VisiteEntities())
            {
                var req = from t in context.TYPE_PRATICIEN
                          where t.TYP_CODE == code
                          select t;
                typ = req.SingleOrDefault<TYPE_PRATICIEN>();
            }
            return typ;
        }

        /// <summary>
        /// Permet de charger tous les types de praticiens
        /// </summary>
        /// <returns>TYPE PRATICIEN</returns>
        public List<TYPE_PRATICIEN> FindAll()
        {
            List<TYPE_PRATICIEN> typ = null;
            using ( var context = new GSB_VisiteEntities())
            {
                var req = from t in context.TYPE_PRATICIEN
                          select t;
                typ = req.ToList<TYPE_PRATICIEN>();
            }
            return typ;
        }

    }
}
