using GSBCR.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSBCR.DAL
{
    public class TravaillerDAO
    {
        public void insert(TRAVAILLER v)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    context.TRAVAILLERs.Add(v);
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
