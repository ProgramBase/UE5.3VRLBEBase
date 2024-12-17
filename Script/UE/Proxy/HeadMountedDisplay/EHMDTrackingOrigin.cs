using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EHMDTrackingOrigin")]
	public enum EHMDTrackingOrigin : long
	{
		Floor = 0,
		Eye = 1,
		Stage = 2,
	}
}