using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class Formations
    {
        Dictionary<string, Formation> formations = new Dictionary<string, Formation>();

        Formation formation442 = new Formation("D (L)", "D (C)", "D (C)", "D (R)", "M (L)", "M (C)", "M (C)", "M (R)", "ST (C)", "ST (C)");
        Formation formation433_1 = new Formation("D (L)", "D (C)", "D (C)", "D (R)", "M (C)", "M (C)", "M (C)", "AM (L)", "AM (R)", "ST (C)");
        Formation formation433_2 = new Formation("D (L)", "D (C)", "D (C)", "D (R)", "M (C)", "M (C)", "AM (C)", "AM (L)", "AM (R)", "ST (C)");
        Formation formation433_3 = new Formation("D (L)", "D (C)", "D (C)", "D (R)", "DM", "M (C)", "M (C)", "AM (L)", "AM (R)", "ST (C)");
        Formation formation532 = new Formation("D (L)", "D (C)", "D (C)", "D (C)", "D (R)", "M (C)", "M (C)", "AM (C)", "ST (C)", "ST (C)");

        public Formations()
        {
            formations.Add("4-4-2 flat", formation442);
            formations.Add("4-3-3 flat", formation433_1);
            formations.Add("4-3-3 attack", formation433_2);
            formations.Add("4-3-3 defense", formation433_3);
            formations.Add("5-3-2 defense", formation532);


        }

        public Dictionary<string, Formation> GetFormations()
        {
            return formations;
        }

    }
}