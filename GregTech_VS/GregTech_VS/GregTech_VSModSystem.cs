using GregTech_VS.assets.gregtech_vs.machine.steam;
using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
namespace GregTech_VS
{
    public class GregTech_VSModSystem : ModSystem
    {

        // Called on server and client
        // Useful for registering block/entity classes on both sides
        public override void Start(ICoreAPI api)
        {
            api.RegisterBlockClass(Mod.Info.ModID + ".lowsolidsteamboiler", typeof(BlockLowSolidSteamBoiler));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
        }

        public override void StartClientSide(ICoreClientAPI api)
        {
        }

    }
}
