using System;
using Verse;
using Verse.AI;
using RimWorld;

namespace AOMoreFurniture
{
    class JobDriver_PlayRoulette : JobDriver_SitFacingBuilding
    {

        protected override void ModifyPlayToil(Toil toil)
        {
            base.ModifyPlayToil(toil);
            toil.WithEffect(() => EffecterDefOf.Joy_HoldChips, () => base.TargetA.Thing.OccupiedRect().ClosestCellTo(this.pawn.Position));
        }
    }
}
