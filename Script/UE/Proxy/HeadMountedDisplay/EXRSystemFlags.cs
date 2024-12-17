using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EXRSystemFlags")]
	public enum EXRSystemFlags : long
	{
		NoFlags = 0,
		IsAR = 1,
		IsTablet = 2,
		IsHeadMounted = 4,
		SupportsHandTracking = 8,
	}
}