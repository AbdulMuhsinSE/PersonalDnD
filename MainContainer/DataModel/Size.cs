using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainContainer.Utils;

namespace MainContainer.DataModel
{
    sealed class Size
    {
        string sname;
        Tuple<double, double> areaOccupied;

        private Size() { }
        private Size(string sname, Tuple<double,double> areaOccupied)
        {
            this.Sname = sname;
            this.AreaOccupied = areaOccupied;
        }

        public static readonly Size TINY = new Size("tiny", new Tuple<double, double> (2.5,2.5));
        public static readonly Size SMALL = new Size("small", new Tuple<double, double>(5, 5));
        public static readonly Size MEDUIUM = new Size("medium", new Tuple<double, double>(5, 5));
        public static readonly Size LARGE = new Size("large", new Tuple<double, double>(5, 5));
        public static readonly Size HUGE = new Size("huge", new Tuple<double, double>(15, 15));
        public static readonly Size GARGANTUAN = new Size("gargantuan", new Tuple<double, double>(20, 20));




        public string Sname
        {
            get
            {
                return sname;
            }

            set
            {
                sname = value;
            }
        }

        public Tuple<double, double> AreaOccupied
        {
            get
            {
                return areaOccupied;
            }

            set
            {
                areaOccupied = value;
            }
        }
    }
}
