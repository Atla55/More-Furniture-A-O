using System;
using Verse;
using Verse.AI;
using RimWorld;


namespace AOMoreFurniture
{
    class JobDriver_PlayPiano : JobDriver_SitFacingBuilding
    {
        protected override void ModifyPlayToil(Toil toil)
        {
            base.ModifyPlayToil(toil);
            toil.WithEffect(() => EffecterDefOf.Joy_PlayPiano, () => base.TargetA.Thing.OccupiedRect().ClosestCellTo(this.pawn.Position));
        }
    }
}
