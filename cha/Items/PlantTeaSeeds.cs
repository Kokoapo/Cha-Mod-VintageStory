using Vintagestory.API.Common;

internal class PlantTeaSeeds : Item
{
    public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, bool firstEvent, ref EnumHandHandling handling)
    {
        base.OnHeldInteractStart(slot, byEntity, blockSel, entitySel, firstEvent, ref handling);

        if (blockSel != null)
        {
            if (blockSel.Block.ToString().Contains("farmland"))
            {
            }
        }
    }
}