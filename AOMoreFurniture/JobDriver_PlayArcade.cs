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
    public class JobDriver_PlayArcadeSounds : JobDriver_WatchBuilding
    {
        protected override void WatchTickAction()
        {
            Random rnd = new Random();

            if (this.pawn.IsHashIntervalTick(400 + rnd.Next(0,100)))
            {
                switch (rnd.Next(0,3))
                {
                    case 1:
                        SoundDefOf.Arcade_SFXTwo.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                    case 2:
                        SoundDefOf.Arcade_SFXThree.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                    case 3:
                        SoundDefOf.Arcade_SFXFour.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                    default:
                        SoundDefOf.Arcade_SFXOne.PlayOneShot(new TargetInfo(this.pawn.Position, this.pawn.Map, false));
                        break;
                }
                
            }
            base.WatchTickAction();
        }

        private const int ArcadeSoundInterval = 200;
    }
}
