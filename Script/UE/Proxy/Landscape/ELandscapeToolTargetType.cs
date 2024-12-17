using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeToolTargetType")]
	public enum ELandscapeToolTargetType : byte
	{
		Heightmap = 0,
		Weightmap = 1,
		Visibility = 2,
		Invalid = 3,
	}
}