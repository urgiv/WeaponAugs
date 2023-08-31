using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WeaponAugs.Common;

namespace WeaponAugs.Content.Items.AugJewels.Uncommon
{
	public class RevitalizeJewelUnc : AugmentJewel
	{
		public override AugType Augment => AugType.Revitalize;
		public override AugTier Tier => AugTier.Uncommon;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelUnc"; 
		private string AugTitle => "Revitalize (Uncommon)";
		private string AugTooltipValue => $"{AugPowerArchive.RevitalizeUnc}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelUnc;
		}
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.value = 0;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.Orange;
		}
	}

	public class RevitalizeJewelRar : AugmentJewel
	{
		public override AugType Augment => AugType.Revitalize;
		public override AugTier Tier => AugTier.Rare;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelRar";
		private string AugTitle => "Revitalize (Rare)";
		private string AugTooltipValue => $"{AugPowerArchive.RevitalizeRar}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelRar;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<RevitalizeJewelUnc>());
			Item.rare = ItemRarityID.Lime;
		}
	}

	public class RevitalizeJewelEpi : AugmentJewel
	{
		public override AugType Augment => AugType.Revitalize;
		public override AugTier Tier => AugTier.Epic;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelEpi";
		private string AugTitle => "Revitalize (Epic)";
		private string AugTooltipValue => $"{AugPowerArchive.RevitalizeEpi}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelEpi;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<RevitalizeJewelUnc>());
			Item.rare = ItemRarityID.Cyan;
		}
	}

	public class RevitalizeJewelUlt : AugmentJewel
	{
		public override AugType Augment => AugType.Revitalize;
		public override AugTier Tier => AugTier.Ultimate;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelUlt";
		private string AugTitle => "Revitalize (Ultimate)";
		private string AugTooltipValue => $"{AugPowerArchive.RevitalizeUlt}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelUlt;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<RevitalizeJewelUnc>());
			Item.rare = ItemRarityID.Purple;
		}
	}
}