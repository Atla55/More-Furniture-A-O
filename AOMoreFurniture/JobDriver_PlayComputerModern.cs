using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using Verse.AI;
using Verse.Sound;
using RimWorld;

namespace AOMoreFurniture
{
    public class JobDriver_PlayComputerModern : JobDriver_WatchBuilding
    {
        protected override void WatchTickAction()
        {
            Random rnd = new Random();

            if (this.pawn.IsHashIntervalTick(400 + (rnd.Next(0, 100))))
            {
                Hediff hediff = pawn.health.hediffSet.GetFirstHediffOfDef(HediffDefOf.Computer_LearningBoost);
                if (hediff == null)
                {
                    pawn.health.AddHediff(HediffDefOf.Computer_LearningBoost);
                }
                else
                {
                    hediff.Severity += 0.08f;
                }
                SoundDefOf.Computer_SFXOne.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
            }
            base.WatchTickAction();
        }

    }
}