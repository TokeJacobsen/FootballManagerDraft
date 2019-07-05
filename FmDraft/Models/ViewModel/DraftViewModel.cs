using FmDraft.Models.Init;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace FmDraft.Models.ViewModel
{
    public class DraftViewModel
    {
        GameSettings gameSettings;
        public GameSettings GameSettings { get { return gameSettings; } }

        public DraftViewModel( )
        {
            gameSettings = GameSettings.Instance;
            
        }

    }
}