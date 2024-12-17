using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EXRTrackedDeviceType")]
	public enum EXRTrackedDeviceType : long
	{
		HeadMountedDisplay = 0,
		Controller = 1,
		TrackingReference = 2,
		Tracker = 3,
		Other = 4,
		Invalid = 254,
		Any = 255,
	}
}