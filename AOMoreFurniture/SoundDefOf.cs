using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    [DefOf]
    public static class SoundDefOf
    {
        static SoundDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(SoundDefOf));
        }

        public static SoundDef Arcade_SFXOne;

        public static SoundDef Arcade_SFXTwo;

        public static SoundDef Arcade_SFXThree;

        public static SoundDef Arcade_SFXFour;

        public static SoundDef Computer_SFXOne;

        public static SoundDef Computer_SFXTwo;
    }
}
