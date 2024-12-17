using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeToolPasteMode")]
	public enum ELandscapeToolPasteMode : sbyte
	{
		Invalid = -1,
		Both = 0,
		Raise = 1,
		Lower = 2,
	}
}