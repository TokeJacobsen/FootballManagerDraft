using FmDraft.Models.ValutaStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class GoalkeeperFactory : PlayerFactory
    {
        private static GoalkeeperFactory instance;
        private GoalkeeperFactory()
        {
        }

        public static GoalkeeperFactory GetInstance()
        {
            if(instance == null)
            {
                instance = new GoalkeeperFactory();
                return instance;
            }

            return instance;
        }

        public Player GetPlayer(Players player, Valuta valuta)
        {
            Goalkeeper newPlayer = new Goalkeeper();
            newPlayer.Id = player.ID_Player;
            newPlayer.Acceleration = player.Acceleration;
            newPlayer.Aerial = player.Aerial;
            newPlayer.Age = player.Age;
            newPlayer.Aggression = player.Aggression;
            newPlayer.Agility = player.Agility;
            newPlayer.Anticipation = player.Anticipation;
            newPlayer.Balance = player.Balance;
            newPlayer.Bravery = player.Bravery;
            newPlayer.Club = new ViewModels.Club
            {
                Name = player.Clubs.ClubName,
                Division = new ViewModels.Division
                {
                    Name = player.Clubs.Divisions.DivisionName,
                    Nation = player.Clubs.Divisions.Based
                }

            };
            newPlayer.CommandOfArea = player.Command_of_area;
            newPlayer.Communication = player.Communication;
            newPlayer.Composure = player.Composure;
            newPlayer.Concentration = player.Concentration;
            newPlayer.Decisions = player.Decisions;
            newPlayer.Determination = player.Determination;
            newPlayer.Eccentricity = player.Eccentricity;
            newPlayer.FirstTouch = player.First_touch;
            newPlayer.Handling = player.Handling;
            newPlayer.Height = player.Hight;
            newPlayer.JumpingReach = player.Jumping;
            newPlayer.Kicking = player.Kicking;
            newPlayer.Leadership = player.Leadership;
            newPlayer.Name = player.Name;
            newPlayer.Nationality = player.Nationality;
            newPlayer.NaturalFitness = player.Natural_fitness;
            newPlayer.OffTheBall = player.Off_the_ball;
            newPlayer.OneOnOne = player.One_on_one;
            newPlayer.Pace = player.Pace;
            newPlayer.Passing = player.Passing;
            newPlayer.Position = player.Position;
            newPlayer.Positioning = player.Positioning;
            newPlayer.Reflexes = player.Reflexes;
            newPlayer.Flair = player.Flair;
            newPlayer.RushingOut = player.Rushing_out;
            newPlayer.Stamina = player.Stamina;
            newPlayer.Strength = player.Strentgh;
            newPlayer.Teamwork = player.Teamwork;
            newPlayer.TendencyToPunch = player.Tendency_to_punch_ball;
            newPlayer.Throwing = player.Thowing;
            newPlayer.Value = (int)valuta.Convert(DataCleaner.ConvertValueToNumber(player.Value));
            newPlayer.Vision = player.Vision;
            newPlayer.Weight = player.Weight;
            newPlayer.Workrate = player.Workrate;
            return newPlayer;
        }
    }
}