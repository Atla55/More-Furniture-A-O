using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    [DefOf]
    public static class ThingDefOf
    {
        static ThingDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(ThingDefOf));
        }

        
        public static ThingDef Radio_Industrial;

        public static ThingDef Radio_Spacer;

        public static ThingDef Mote_FlyingDart;
    }

}
