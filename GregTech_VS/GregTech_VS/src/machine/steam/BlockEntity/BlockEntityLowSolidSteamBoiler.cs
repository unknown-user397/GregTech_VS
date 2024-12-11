using Vintagestory.API.Common;
using Vintagestory.GameContent;

namespace GregTech_VS.src.machine.steam
{
    public class BlockEntityLowSolidSteamBoiler : BlockEntityLiquidContainer
    {
        public int Capacitylitres { get; set; } = 50;

        GUI.GuiDialogSolidSteamBoiler invDialog;

        public BlockEntityLowSolidSteamBoiler()
        {
            inventory = new InventoryGeneric(2, null, null, (id, self) =>
            {
                if (id == 0) return new ItemSlotBarrelInput(self);
                else return new ItemSlotLiquidOnly(self, 50);
            });
        }
    }
}