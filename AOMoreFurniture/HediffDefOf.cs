using System;
using Verse;
using RimWorld;

namespace AOMoreFurniture
{
    [DefOf]
    public static class HediffDefOf
    {
        static HediffDefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(HediffDefOf));
        }

        public static HediffDef Computer_LearningBoost;
    }
}
