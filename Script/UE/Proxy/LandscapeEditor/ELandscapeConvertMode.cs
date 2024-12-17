using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeConvertMode")]
	public enum ELandscapeConvertMode : sbyte
	{
		Invalid = -1,
		Expand = 0,
		Clip = 1,
		Resample = 2,
	}
}