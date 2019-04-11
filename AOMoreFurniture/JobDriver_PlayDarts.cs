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
            bool flag = Gen.IsHashIntervalTick(this.pawn, 400);
            if (flag)
            {
                JobDriver_PlayDarts.ThrowDart(this.pawn, base.TargetA.Cell);
            }
            base.WatchTickAction();
        }

        public static void ThrowDart(Pawn thrower, IntVec3 targetCell)
        {
            bool flag = !GenView.ShouldSpawnMotesAt(thrower.Position, thrower.Map) || thrower.Map.moteCounter.SaturatedLowPriority;
            if (!flag)
            {
                float num = 10f;
                Vector3 vector = targetCell.ToVector3Shifted();
                ThingDef thingDef;
                    thingDef = ThingDefOf.Mote_FlyingDart;
                MoteThrown moteThrown = (MoteThrown)ThingMaker.MakeThing(thingDef, null);
                moteThrown.Scale = 0.75f;
                moteThrown.rotationRate = 0.01f;
                moteThrown.exactPosition = thrower.DrawPos;
                moteThrown.exactRotation = Vector3Utility.AngleFlat(vector - moteThrown.exactPosition);
                moteThrown.SetVelocity(Vector3Utility.AngleFlat(vector - moteThrown.exactPosition), num);
                moteThrown.MoveAngle = Vector3Utility.AngleFlat(vector - moteThrown.exactPosition);
                moteThrown.airTimeLeft = GenGeo.MagnitudeHorizontal(moteThrown.exactPosition - vector) / num;
                GenSpawn.Spawn(moteThrown, thrower.Position, thrower.Map, 0);
            }
        }

        private const int throwDartInterval = 400;
    }
}


