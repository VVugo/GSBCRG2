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
        public TYPE_PRATICIEN FindById(string code)
        {
            //Rechercher un type praticien par son code
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

        public List<TYPE_PRATICIEN> FindAll()
        {
            //Charger tous les types praticiens
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
