using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models
{
    public class Goalkeeper : Player
    {
        public byte Throwing { get; set; }
        public byte TendencyToPunch { get; set; }
        public byte RushingOut { get; set; }
        public byte Reflexes { get; set; }
        public byte OneOnOne { get; set; }
        public byte Kicking { get; set; }
        public byte Handling { get; set; }
        public byte Eccentricity { get; set; }
        public byte Communication { get; set; }
        public byte CommandOfArea { get; set; }
        public byte Aerial { get; set; }



    }
}