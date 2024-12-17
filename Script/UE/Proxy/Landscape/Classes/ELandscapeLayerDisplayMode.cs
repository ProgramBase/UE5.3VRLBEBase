using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeLayerDisplayMode")]
	public enum ELandscapeLayerDisplayMode : byte
	{
		Default = 0,
		Alphabetical = 1,
		UserSpecific = 2,
	}
}