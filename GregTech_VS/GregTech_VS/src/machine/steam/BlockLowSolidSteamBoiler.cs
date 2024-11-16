using Vintagestory.API.Common;
using Vintagestory.API.MathTools;

namespace GregTech_VS.assets.gregtech_vs.machine.steam
{
    internal class BlockLowSolidSteamBoiler : Block
    {
        public override void OnBlockPlaced(IWorldAccessor world, BlockPos blockPos, ItemStack byItemStack = null)
        {
            api.Logger.Event("LowSolidSteamBoiler Block Placed!");
            base.OnBlockPlaced(world, blockPos, byItemStack);
        }
        public override void OnBlockBroken(IWorldAccessor world, BlockPos pos, IPlayer byPlayer, float dropQuantityMultiplier = 1)
        {
            api.Logger.Event("LowSolidSteamBoiler Block Broken!");
            base.OnBlockBroken(world, pos, byPlayer, dropQuantityMultiplier);
        }
    }
}
