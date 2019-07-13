using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FmDraft.Models.Init;

namespace FmDraft.Models.DAO
{
    public class FormationsList
    {
        public static Dictionary<string, Formation> GetFormations()
        {
            Dictionary<string, Formation> formations = new Dictionary<string, Formation>();
            using (FMDraftEntities1 db = new FMDraftEntities1())
            {
                var formationQuery = from c in db.Formations
                                    select c;
                foreach (var f in formationQuery)
                {

                    Formation formation = new Formation(f.ForTitle, f.For2, f.For3, f.For4, f.For5, f.For6, f.For7, f.For8, f.For9, f.For10, f.For11);


                    formations.Add(f.ForTitle, formation);
                }
            }
            return formations;

        }
    }
}