using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TravelerWitchBroom.Buffs;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace TravelerWitchBroom.Mounts
{
    public class BroomMount : ModMountData
    {
		internal class BroomSpecificData
        {
			public float rotation;
			public float trinketRotation;

			public float BoostChargeProgress = 0f;
			public float BoostRechargeRate = 0.1f;
		}

        public override void SetDefaults()
        {
			mountData.spawnDust = 43;
			mountData.spawnDustNoGravity = true;
			mountData.buff = ModContent.BuffType<BroomBuff>();
			mountData.heightBoost = 0;
			mountData.flightTimeMax = 320;
			mountData.fatigueMax = 320;
			mountData.fallDamage = 0f;
			//mountData.runSpeed = 9f;
			mountData.runSpeed = 12f;
			//mountData.dashSpeed = 9f;
			mountData.dashSpeed = 12f;
			mountData.acceleration = 0.16f;
			mountData.jumpHeight = 10;
			mountData.jumpSpeed = 4f;
			
			mountData.usesHover = true;
			//mountData.constantJump = true;
			mountData.blockExtraJumps = true;

			mountData.totalFrames = 6;
			int[] array = new int[mountData.totalFrames];
			for (int i = 0; i < array.Length; i++)
				array[i] = 6;

			mountData.playerYOffsets = array;
			mountData.xOffset = -2;
			mountData.bodyFrame = 0;
			mountData.yOffset = 8;
			mountData.playerHeadOffset = 0;
			mountData.standingFrameCount = 1;
			mountData.standingFrameDelay = 0;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 1;
			mountData.runningFrameDelay = 0;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 1;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 6;
			mountData.inAirFrameDelay = 8;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 0;
			mountData.idleFrameDelay = 0;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = 0;
			mountData.swimFrameDelay = 0;
			mountData.swimFrameStart = 0;
			
			if (Main.netMode == NetmodeID.Server)
			{
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width;
			mountData.textureHeight = mountData.backTexture.Height;
		}	

		public override void UpdateEffects(Player player)
		{
			var data = (BroomSpecificData) player.mount._mountSpecificData;
			

			if (data.BoostChargeProgress < 100)
				data.BoostChargeProgress += data.BoostRechargeRate;
			if (data.BoostChargeProgress > 100)
				data.BoostChargeProgress = 100;
		}

		public override void SetMount(Player player, ref bool skipDust)
		{
			player.mount._mountSpecificData = new BroomSpecificData();
		}

		public override bool Draw(List<DrawData> playerDrawData, int drawType, Player drawPlayer,
			ref Texture2D texture, ref Texture2D glowTexture, ref Vector2 drawPosition,
			ref Rectangle frame, ref Color drawColor, ref Color glowColor, ref float rotation,
			ref SpriteEffects spriteEffects, ref Vector2 drawOrigin, ref float drawScale, float shadow)
		{
			return true;
		}
	}
}
