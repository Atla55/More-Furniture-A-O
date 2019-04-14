using System;
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    [DefOf]
    public static class EffecterDefOf
    {
        static EffecterDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(EffecterDefOf));
        }

        public static EffecterDef Joy_HoldChips;

        public static EffecterDef Joy_PlayPiano;
    }
}
