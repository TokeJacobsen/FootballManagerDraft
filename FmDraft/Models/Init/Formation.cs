using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class Formation
    {
        public string[] FormationArray = new string[11];
        public string FormationTitle { get; set; }

        public Formation(string title, string pos1, string pos2, string pos3, string pos4, string pos5, string pos6, string pos7, string pos8, string pos9, string pos10 )
        {
            FormationArray[0] = "GK";
            FormationArray[1] = pos1;
            FormationArray[2] = pos2;
            FormationArray[3] = pos3;
            FormationArray[4] = pos4;
            FormationArray[5] = pos5;
            FormationArray[6] = pos6;
            FormationArray[7] = pos7;
            FormationArray[8] = pos8;
            FormationArray[9] = pos9;
            FormationArray[10] = pos10;
            FormationTitle = title;
        }

    }
}