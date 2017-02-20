using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainContainer.DataModel
{
    public class Alignment
    {
        //Class that mostly works like a string equivalent of an enum
        public string Value { get; set; }

        private Alignment(string value) { this.Value = value; }

        public static Alignment LG { get { return new Alignment("Lawful Good"); } }
        public static Alignment NG { get { return new Alignment("Neutral Good"); } }
        public static Alignment CG { get { return new Alignment("Chaotic Good"); } }
        public static Alignment LN { get { return new Alignment("Lawful Neutral"); } }
        public static Alignment N { get { return new Alignment("Neutral"); } }
        public static Alignment CN { get { return new Alignment("Chaotic Neutral"); } }
        public static Alignment LE { get { return new Alignment("Lawful Evil"); } }
        public static Alignment NE { get { return new Alignment("Neutral Evil"); } }
        public static Alignment CE { get { return new Alignment("Chaotic Evil"); } }
        public static Alignment UN { get { return new Alignment("Unaligned"); } }

    }
}
