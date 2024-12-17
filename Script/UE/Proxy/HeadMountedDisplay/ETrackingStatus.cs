using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.ETrackingStatus")]
	public enum ETrackingStatus : byte
	{
		NotTracked = 0,
		InertialOnly = 1,
		Tracked = 2,
	}
}