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
            goalkeeper.Age = player.Age;
            goalkeeper.Aggression = player.Aggression;
            goalkeeper.Agility = player.Agility;
            goalkeeper.Anticipation = player.Anticipation;
            goalkeeper.Balance = player.Balance;
            goalkeeper.Bravery = player.Bravery;
            goalkeeper.Club = new ViewModels.Club
            {
                Division = goalkeeper.Club.Division,
                Name = goalkeeper.Club.Name

            };
            goalkeeper.CommandOfArea = player.Command_of_area;
            goalkeeper.Communication = player.Communication;
            goalkeeper.Composure = player.Composure;
            goalkeeper.Concentration = player.Concentration;
            goalkeeper.Decisions = player.Decisions;
            goalkeeper.Determination = player.Determination;
            goalkeeper.Eccentricity = player.Eccentricity;
            goalkeeper.FirstTouch = player.First_touch;
            goalkeeper.Handling = player.Handling;
            goalkeeper.Height = player.Hight;
            goalkeeper.JumpingReach = player.Jumping;
            goalkeeper.Kicking = player.Kicking;
            goalkeeper.Leadership = player.Leadership;
            goalkeeper.Name = player.Name;
            goalkeeper.Nationality = player.Nationality;
            goalkeeper.NaturalFitness = player.Natural_fitness;
            goalkeeper.OffTheBall = player.Off_the_ball;
            goalkeeper.OneOnOne = player.One_on_one;
            goalkeeper.Pace = player.Pace;
            goalkeeper.Passing = player.Passing;
            goalkeeper.Position = player.Position;
            goalkeeper.Positioning = player.Positioning;
            goalkeeper.Reflexes = player.Reflexes;
            goalkeeper.RushingOut = player.Rushing_out;
            goalkeeper.Stamina = player.Stamina;
            goalkeeper.Strength = player.Strentgh;
            goalkeeper.Teamwork = player.Teamwork;
            goalkeeper.TendencyToPunch = player.Tendency_to_punch_ball;
            goalkeeper.Throwing = player.Thowing;
            // goalkeeper.Value = player.Value;
            goalkeeper.Vision = player.Vision;
            goalkeeper.Weight = player.Weight;
            goalkeeper.Workrate = player.Workrate;
            return goalkeeper;
        }
    }
}