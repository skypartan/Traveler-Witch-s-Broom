using Terraria;
using Terraria.ModLoader;

namespace TravelerWitchBroom.Buffs
{
    public class BroomBuff : ModBuff
    {
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Traveler's Broom");
			Description.SetDefault("Travel free, and see the world!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Mounts.BroomMount>(), player);
            player.mount.ResetFlightTime(320);
			player.buffTime[buffIndex] = 1;
		}
	}
}
