using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeLayerPaintingRestriction")]
	public enum ELandscapeLayerPaintingRestriction : byte
	{
		None = 0,
		UseMaxLayers = 1,
		ExistingOnly = 2,
		UseComponentAllowList = 3,
	}
}