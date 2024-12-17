using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeToolHydroErosionMode")]
	public enum ELandscapeToolHydroErosionMode : sbyte
	{
		Invalid = -1,
		Both = 0,
		Positive = 1,
	}
}