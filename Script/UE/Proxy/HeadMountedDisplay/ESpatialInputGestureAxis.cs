using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.ESpatialInputGestureAxis")]
	public enum ESpatialInputGestureAxis : byte
	{
		None = 0,
		Manipulation = 1,
		Navigation = 2,
		NavigationRails = 3,
	}
}