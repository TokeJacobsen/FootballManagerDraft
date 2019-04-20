using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FmDraft.Models
{
    public class OutfieldPlayer
    {
        public byte Technique { get; set; }
        public byte Tackling { get; set; }
        public byte PentaltyKick { get; set; }
        public byte Marking { get; set; }
        public byte LongThrow { get; set; }
        public byte Longshot { get; set; }
        public byte Heading { get; set; }
        public byte FreeKick { get; set; }
        public byte Finishing { get; set; }
        public byte Dribbling { get; set; }
        public byte Crossing { get; set; }
        public byte CornerKick { get; set; }

    }
}