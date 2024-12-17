using Script.CoreUObject;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.EAnimGraphAttributesDisplayMode")]
	public enum EAnimGraphAttributesDisplayMode : int
	{
		HideOnPins = 0,
		ShowOnPins = 1,
		Automatic = 2,
	}
}