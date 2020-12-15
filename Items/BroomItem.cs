using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;
using TravelerWitchBroom.Mounts;
using Terraria;

namespace TravelerWitchBroom.Items
{
    public class BroomItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a modded mount.");
        }

		public override void SetDefaults()
		{
			item.width = 34;
			item.height = 34;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.value = Item.sellPrice(0, 5);
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item25;
			item.noMelee = true;
			item.mountType = ModContent.MountType<BroomMount>();
			item.expert = true;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			//recipe.AddTile(ModContent.TileType<ExampleWorkbench>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
