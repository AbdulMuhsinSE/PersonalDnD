using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainContainer.DataModel
{
    class Features
    {
        string description;
        string type;
        int featureRadiusFeet;
        /********************************
         * Description                  *
         ********************************
         * 0 feet indicates effects that*
         * require direct contact       *
         ********************************/
        string bonus;

        public Features(string description, string type, int featureRadiusFeet, string bonus)
        {
            this.description = description;
            this.type = type;
            this.featureRadiusFeet = featureRadiusFeet;
            this.bonus = bonus;
        }
    }
}
