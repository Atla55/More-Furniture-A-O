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
    public class JobDriver_PlayPunchingBag : JobDriver_WatchBuilding
    {
        protected override void WatchTickAction()
        {
            Random rnd = new Random();

            if (this.pawn.IsHashIntervalTick(400 + (rnd.Next(0, 100)) - Convert.ToInt32((float)pawn.skills.GetSkill(SkillDefOf.Melee).Level) * 10))
            {
                switch (rnd.Next(0, 2))
                {
                    case 1:
                        RimWorld.SoundDefOf.Pawn_Melee_Punch_Miss.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                    default:
                        RimWorld.SoundDefOf.Pawn_Melee_Punch_HitPawn.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                }

            }
            base.WatchTickAction();
        }

        private const int PunchSoundInterval = 400;
    }
}