using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EXRDeviceConnectionResult")]
	public enum EXRDeviceConnectionResult : long
	{
		NoTrackingSystem = 0,
		FeatureNotSupported = 1,
		NoValidViewport = 2,
		MiscFailure = 3,
		Success = 4,
	}
}