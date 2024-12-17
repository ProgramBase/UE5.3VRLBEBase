using Script.CoreUObject;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.ELandscapeToolFlattenMode")]
	public enum ELandscapeToolFlattenMode : sbyte
	{
		Invalid = -1,
		Both = 0,
		Raise = 1,
		Lower = 2,
		Interval = 3,
		Terrace = 4,
	}
}