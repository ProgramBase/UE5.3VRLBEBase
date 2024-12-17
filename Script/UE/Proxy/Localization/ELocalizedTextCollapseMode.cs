using Script.CoreUObject;

namespace Script.Localization
{
	[PathName("/Script/Localization.ELocalizedTextCollapseMode")]
	public enum ELocalizedTextCollapseMode : byte
	{
		IdenticalTextIdAndSource = 0,
		IdenticalPackageIdTextIdAndSource = 1,
		IdenticalNamespaceAndSource = 2,
	}
}