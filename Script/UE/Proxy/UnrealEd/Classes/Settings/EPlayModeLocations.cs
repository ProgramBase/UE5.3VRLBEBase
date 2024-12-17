using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EPlayModeLocations")]
	public enum EPlayModeLocations : byte
	{
		PlayLocation_CurrentCameraLocation = 0,
		PlayLocation_DefaultPlayerStart = 1,
	}
}