using System;
using System.Collections.Generic;
using System.Linq;
using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    public class CompBinClean : ThingComp
    {
        public CompProperties_BinClean Cleanprops
        {
            get
            {
                return this.props as CompProperties_BinClean;
            }
        }

        public override void CompTick()
        {
            TicksCounted++;

            Log.Message(Convert.ToString(TicksCounted));

            if (TicksCounted == Cleanprops.TimerInTicks)
            {
                TicksCounted = 0;
                Map BuildingMap = parent.Map;

                List<Thing> Filthlist = BuildingMap.listerFilthInHomeArea.FilthInHomeArea;
                for (int i = 0; i < Filthlist.Count; i++)
                {
                    if (Filthlist[i].Position.InHorDistOf(parent.Position, Cleanprops.Radius))
                    {
                        Filthlist[i].Destroy();
                        break;
                    }
                }
            }
            base.CompTick();
        }

        public int TicksCounted = 0;
    }
}
