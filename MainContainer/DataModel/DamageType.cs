using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainContainer.Exception
{
    public enum DamageType
    {
        bludgeoning, //physical force
        piercing,
        slashing,
        acid, //contact
        fire,
        cold,
        poison, //ingested, can cause poisoned condition
        necrotic,
        radiant,
        lightning,
        psychic,
        thunder,
        force //magical force
    }
}
