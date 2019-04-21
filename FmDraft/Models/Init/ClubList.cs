using FmDraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Init
{
    public class Clubs
    {
        public Clubs()
        {

        }

        public List<Club> GetClubList()
        {
            List<Club> clubs = new List<Club>();
            using (FMDraftEntities1 db = new FMDraftEntities1())
            {
                var clubsQuery = from c in db.Clubs
                                 select c;
                foreach (var c in clubsQuery)
                {
                    Club club = new Club
                    {
                        Division = new Division
                        {
                            Name = c.Divisions.DivisionName,
                            Nation = c.Divisions.Based
                        },
                        Name = c.ClubName
                        
                    };
                    clubs.Add(club);
                }
            }
            return clubs;
        }
    }
}