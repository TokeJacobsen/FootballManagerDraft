using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class OutfieldPlayerFactory : PlayerFactory
    {
        FMDraftEntities db;
        public OutfieldPlayerFactory (FMDraftEntities db)
        {
            this.db = db;
        }
        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }
    }
}