using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class OutfieldPlayerFactory : PlayerFactory
    {
        FMDraftEntities1 db;
        public OutfieldPlayerFactory (FMDraftEntities1 db)
        {
            this.db = db;
        }
        public Player GetPlayer(Players player)
        {
           throw new NotImplementedException();
        }
    }
}