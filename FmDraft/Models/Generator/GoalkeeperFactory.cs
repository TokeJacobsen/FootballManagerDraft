using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class GoalkeeperFactory : PlayerFactory
    {
        FMDraftEntities1 db;
        public GoalkeeperFactory(FMDraftEntities1 db)
        {
            this.db = db;
        }

        public Player GetPlayer(Players player)
        {
            Goalkeeper goalkeeper = new Goalkeeper();
            goalkeeper.Acceleration = player.Acceleration;
            goalkeeper.Aerial = player.Aerial;

            throw new NotImplementedException();
        }
    }
}