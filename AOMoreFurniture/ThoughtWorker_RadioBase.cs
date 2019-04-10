using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace AOMoreFurniture
{
    class ThoughtWorker_RadioBase : ThoughtWorker
    {
        protected override ThoughtState CurrentStateInternal(Pawn p)
        {
            bool radio_result = false;

            if (!p.Spawned)
            {
                return false;
            }
            List<Thing> listtwo = p.Map.listerThings.ThingsOfDef(ThingDefOf.Radio_Spacer);
            for (int i = 0; i < listtwo.Count; i++)
            {
                CompPowerTrader compPowerTrader = listtwo[i].TryGetComp<CompPowerTrader>();
                if (compPowerTrader == null || compPowerTrader.PowerOn)
                {
                    if (p.Position.InHorDistOf(listtwo[i].Position, 8f))
                    {
                        radio_result = true;
                        return ThoughtState.ActiveAtStage(1);
                    }
                }
            }
            List<Thing> list = p.Map.listerThings.ThingsOfDef(ThingDefOf.Radio_Industrial);
            for (int i = 0; i < list.Count; i++)
            {
                CompPowerTrader compPowerTrader = list[i].TryGetComp<CompPowerTrader>();
                if (compPowerTrader == null || compPowerTrader.PowerOn && radio_result == false)
                {
                    if (p.Position.InHorDistOf(list[i].Position, 5f))
                    {
                        return ThoughtState.ActiveAtStage(0);
                    }
                }
            }
            return false;
        }

    }
}
