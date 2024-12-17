using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.EHMDWornState")]
	public enum EHMDWornState : long
	{
		Unknown = 0,
		Worn = 1,
		NotWorn = 2,
	}
}