using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class Formation
    {
        public Formation(string pos1, string pos2, string pos3, string pos4, string pos5, string pos6, string pos7, string pos8, string pos9, string pos10 )
        {
            string[] formation = new string[11];
            formation[0] = "GK";
            formation[1] = pos1;
            formation[2] = pos2;
            formation[3] = pos3;
            formation[4] = pos4;
            formation[5] = pos5;
            formation[6] = pos6;
            formation[7] = pos7;
            formation[8] = pos8;
            formation[9] = pos9;
            formation[10] = pos10;

        }

    }
}