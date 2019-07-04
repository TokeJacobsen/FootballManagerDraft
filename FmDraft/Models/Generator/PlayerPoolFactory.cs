using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class PlayerPoolFactory
    {
        private List<string> divisions;
        List<Player> playerPool;
        public PlayerPoolFactory(List<string> divisions)
        {
            playerPool = new List<Player>();
            this.divisions = divisions;

        }
        public List<Player> GetPlayerPool()
        {
            PlayerFactory factory;
            using(var db = new FMDraftEntities1())
            {
                foreach (string division in divisions)
                {
                    var players = from p in db.Players
                                  where p.Clubs.Divisions.DivisionName.Equals(division)
                                  select p;
                    foreach (var player in players)
                    {
                        if (player.Position.Equals("GK"))
                        {
                            factory = GoalkeeperFactory.GetInstance();
                            playerPool.Add(factory.GetPlayer(player));
                        }
                        else
                        {
                            factory = OutfieldPlayerFactory.GetInstance();
                            playerPool.Add(factory.GetPlayer(player));
                        }
                    }
                }
            }
            return playerPool;
        }
    }
}