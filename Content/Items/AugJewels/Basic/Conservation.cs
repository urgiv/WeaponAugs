using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using WeaponAugs.Common;

namespace WeaponAugs.Content.Items.AugJewels.Basic
{
	public class ConservationJewelBas : AugmentJewel
	{
		public override AugType Augment => AugType.Conservation;
		public override AugTier Tier => AugTier.Basic;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelBas"; 
		private string AugTitle => "Conservation (Basic)";
		private string AugTooltipValue => $"{AugPowerArchive.ConservationBas}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelBas;
			ItemID.Sets.IsLavaImmuneRegardlessOfRarity[Type] = true;
		}
		public override void SetDefaults()
		{
			Item.width = 16;
			Item.height = 16;
			Item.value = 0;
			Item.maxStack = 9999;
			Item.rare = ItemRarityID.White;
		}
	}

	public class ConservationJewelUnc : AugmentJewel
	{
		public override AugType Augment => AugType.Conservation;
		public override AugTier Tier => AugTier.Uncommon;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelUnc"; 
		private string AugTitle => "Conservation (Uncommon)";
		private string AugTooltipValue => $"{AugPowerArchive.ConservationUnc}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelUnc;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<ConservationJewelBas>());
			Item.rare = ItemRarityID.Orange;
		}
	}

	public class ConservationJewelRar : AugmentJewel
	{
		public override AugType Augment => AugType.Conservation;
		public override AugTier Tier => AugTier.Rare;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelRar";
		private string AugTitle => "Conservation (Rare)";
		private string AugTooltipValue => $"{AugPowerArchive.ConservationRar}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelRar;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<ConservationJewelBas>());
			Item.rare = ItemRarityID.Lime;
		}
	}

	public class ConservationJewelEpi : AugmentJewel
	{
		public override AugType Augment => AugType.Conservation;
		public override AugTier Tier => AugTier.Epic;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelEpi";
		private string AugTitle => "Conservation (Epic)";
		private string AugTooltipValue => $"{AugPowerArchive.ConservationEpi}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelEpi;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<ConservationJewelBas>());
			Item.rare = ItemRarityID.Cyan;
		}
	}

	public class ConservationJewelUlt : AugmentJewel
	{
		public override AugType Augment => AugType.Conservation;
		public override AugTier Tier => AugTier.Ultimate;

		
		public override string Texture => "WeaponAugs/Content/Items/AugJewels/AugJewelUlt";
		private string AugTitle => "Conservation (Ultimate)";
		private string AugTooltipValue => $"{AugPowerArchive.ConservationUlt}";
		public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(AugTitle, AugTooltipValue);

		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = JourneyUnlocksArchive.JewelUlt;
		}
		public override void SetDefaults()
		{
			Item.CloneDefaults(ModContent.ItemType<ConservationJewelBas>());
			Item.rare = ItemRarityID.Purple;
		}
	}
}