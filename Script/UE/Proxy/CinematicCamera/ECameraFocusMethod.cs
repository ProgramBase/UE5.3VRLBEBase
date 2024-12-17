using Script.CoreUObject;

namespace Script.CinematicCamera
{
	[PathName("/Script/CinematicCamera.ECameraFocusMethod")]
	public enum ECameraFocusMethod : byte
	{
		DoNotOverride = 0,
		Manual = 1,
		Tracking = 2,
		Disable = 3,
	}
}