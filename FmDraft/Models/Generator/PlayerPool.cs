using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class PlayerPool
    {
        public PlayerPool()
        {
            using(var db = new FMDraftEntities())
            {
                var query = from players in db.Players
            }
        }

    }
}