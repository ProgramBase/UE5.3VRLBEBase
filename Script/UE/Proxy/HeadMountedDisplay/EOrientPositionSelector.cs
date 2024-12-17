using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EOrientPositionSelector")]
	public enum EOrientPositionSelector : long
	{
		Orientation = 0,
		Position = 1,
		OrientationAndPosition = 2,
	}
}