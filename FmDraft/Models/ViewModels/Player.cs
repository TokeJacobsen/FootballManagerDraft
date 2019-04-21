using FmDraft.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models
{
    public class Player
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public Club Club { get; set; }
        public byte Acceleration { get; set; }
        public byte Workrate { get; set; }
        public byte Vision { get; set; }
        public byte Teamwork { get; set; }
        public byte Strength { get; set; }
        public byte Stamina { get; set; }
        public byte Positioning { get; set; }
        public byte Passing { get; set; }
        public byte Pace { get; set; }
        public byte NaturalFitness { get; set; }
        public byte Leadership { get; set; }
        public byte JumpingReach { get; set; }
        public byte Flair { get; set; }
        public byte Determination { get; set; }
        public byte Decisions { get; set; }
        public byte Concentration { get; set; }
        public byte Composure { get; set; }
        public byte Bravery { get; set; }
        public byte Balance { get; set; }
        public byte Anticipation { get; set; }
        public byte Agility { get; set; }
        public byte Aggression { get; set; }
        public double Value { get; set; }
        public string Position { get; set; }
        public byte Age { get; set; }
        public int Height { get; set; }
        public byte Weight { get; set; }
        public byte FirstTouch { get; set; }
        public byte OffTheBall { get; set; }

       }
}