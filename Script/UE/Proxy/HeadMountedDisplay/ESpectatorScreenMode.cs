using Script.CoreUObject;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.ESpectatorScreenMode")]
	public enum ESpectatorScreenMode : long
	{
		Disabled = 0,
		SingleEyeLetterboxed = 1,
		Undistorted = 2,
		Distorted = 3,
		SingleEye = 4,
		SingleEyeCroppedToFill = 5,
		Texture = 6,
		TexturePlusEye = 7,
	}
}