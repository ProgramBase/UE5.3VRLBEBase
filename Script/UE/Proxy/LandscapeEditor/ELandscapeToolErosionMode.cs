using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeToolErosionMode")]
	public enum ELandscapeToolErosionMode : sbyte
	{
		Invalid = -1,
		Both = 0,
		Raise = 1,
		Lower = 2,
	}
}