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
    // Token: RID: 61 74 6c 61 73 20 77 61 73 20 68 65 72 65 File Offset:0x00201581
    public class JobDriver_PlayComputerIndustrial : JobDriver_WatchBuilding
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
                    hediff.Severity += 0.04f;
                }
                
                switch (rnd.Next(0, 2))
                {
                    case 1:
                        SoundDefOf.Computer_SFXTwo.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                    default:
                        SoundDefOf.Computer_SFXOne.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                }

            }
            base.WatchTickAction();
        }
        
    }
}