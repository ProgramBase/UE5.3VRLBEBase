using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeResizeMode")]
	public enum ELandscapeResizeMode : long
	{
		Resample = 0,
		Clip = 1,
		Expand = 2,
	}
}