using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models.Generator
{
    public class OutfieldPlayerFactory : PlayerFactory
    {
        private static OutfieldPlayerFactory instance;
        private OutfieldPlayerFactory ()
        {
        }

        public static OutfieldPlayerFactory GetInstance()
        {
            if(instance == null)
            {
                instance = new OutfieldPlayerFactory();
                return instance;
            }
            return instance;
        }

        public Player GetPlayer(Players player)
        {
            OutfieldPlayer newPlayer = new OutfieldPlayer();
            newPlayer.Id = player.ID_Player;
            newPlayer.CornerKick = player.Corner_kick;
            newPlayer.Crossing = player.Crossing;
            newPlayer.Dribbling = player.Dribbling;
            newPlayer.Finishing = player.Finishing;
            newPlayer.FreeKick = player.Free_kick;
            newPlayer.Heading = player.Heading;
            newPlayer.Longshot = player.Longshot;
            newPlayer.LongThrow = player.Long_throw;
            newPlayer.Marking = player.Marking;
            newPlayer.PentaltyKick = player.Pentalty_kick;
            newPlayer.Tackling = player.Tackling;
            newPlayer.Technique = player.Technique;
            newPlayer.Acceleration = player.Acceleration;
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
            newPlayer.Composure = player.Composure;
            newPlayer.Concentration = player.Concentration;
            newPlayer.Decisions = player.Decisions;
            newPlayer.Determination = player.Determination;
            newPlayer.FirstTouch = player.First_touch;
            newPlayer.Height = player.Hight;
            newPlayer.JumpingReach = player.Jumping;
            newPlayer.Leadership = player.Leadership;
            newPlayer.Name = player.Name;
            newPlayer.Nationality = player.Nationality;
            newPlayer.NaturalFitness = player.Natural_fitness;
            newPlayer.OffTheBall = player.Off_the_ball;
            newPlayer.Pace = player.Pace;
            newPlayer.Passing = player.Passing;
            newPlayer.Position = player.Position;
            newPlayer.Positioning = player.Positioning;
            newPlayer.Stamina = player.Stamina;
            newPlayer.Strength = player.Strentgh;
            newPlayer.Teamwork = player.Teamwork;
            newPlayer.Value = DataCleaner.ConvertValueToNumber(player.Value);
            newPlayer.Vision = player.Vision;
            newPlayer.Weight = player.Weight;
            newPlayer.Workrate = player.Workrate;
            newPlayer.Flair = player.Flair;

            return newPlayer;
        }
    }
}