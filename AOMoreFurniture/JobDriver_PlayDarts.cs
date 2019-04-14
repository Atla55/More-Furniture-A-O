using System;
using Verse;
using RimWorld;
using UnityEngine;

namespace AOMoreFurniture
{
    class JobDriver_PlayDarts : JobDriver_WatchBuilding
    {
        protected override void WatchTickAction()
        {
            bool flag = Gen.IsHashIntervalTick(this.pawn, (400 - Convert.ToInt32((float)pawn.skills.GetSkill(SkillDefOf.Shooting).Level) * 10));
            if (flag)
            {
                JobDriver_PlayDarts.ThrowDart(this.pawn, base.TargetA.Cell);
            }
            base.WatchTickAction();
        }

        public static void ThrowDart(Pawn thrower, IntVec3 targetCell)
        {
            if (GenView.ShouldSpawnMotesAt(thrower.Position, thrower.Map) || !thrower.Map.moteCounter.SaturatedLowPriority)
            {
                float speedValue = 5f;

                Vector3 vectorCell = targetCell.ToVector3Shifted();
                vectorCell.z += 0.6f;
                ThingDef thrownThing = ThingDefOf.Mote_FlyingDart;

                MoteThrown moteThrown = (MoteThrown)ThingMaker.MakeThing(thrownThing, null);
                moteThrown.Scale = 0.5f;
                moteThrown.rotationRate = 0.05f;
                moteThrown.exactPosition = thrower.DrawPos;
                moteThrown.exactRotation = Vector3Utility.AngleFlat(vectorCell - moteThrown.exactPosition);
                moteThrown.SetVelocity(Vector3Utility.AngleFlat(vectorCell - moteThrown.exactPosition), speedValue);
                moteThrown.MoveAngle = Vector3Utility.AngleFlat(vectorCell - moteThrown.exactPosition);
                moteThrown.airTimeLeft = GenGeo.MagnitudeHorizontal(moteThrown.exactPosition - vectorCell) / (speedValue + 0.2f);
                GenSpawn.Spawn(moteThrown, thrower.Position, thrower.Map, 0);
            }
        }
        private const int throwDartInterval = 400;
    }
}


