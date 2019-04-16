using System;
using Verse;
using RimWorld;

namespace AOMoreFurniture 
{
    public class CompProperties_BinClean : CompProperties
    {
        public CompProperties_BinClean()
        {
            this.compClass = typeof(CompBinClean);
        }

        public int TimerInTicks;

        public float Radius;
    }
}
