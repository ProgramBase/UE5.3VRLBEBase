using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EEditorUserScreenPercentageModeOverride")]
	public enum EEditorUserScreenPercentageModeOverride : int
	{
		ProjectDefault = 0,
		Manual = 1,
		BasedOnDisplayResolution = 2,
		BasedOnDPIScale = 3,
	}
}