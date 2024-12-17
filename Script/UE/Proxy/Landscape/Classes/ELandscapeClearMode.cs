using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeClearMode")]
	public enum ELandscapeClearMode : long
	{
		Clear_Weightmap = 1,
		Clear_Heightmap = 2,
		Clear_All = 3,
	}
}