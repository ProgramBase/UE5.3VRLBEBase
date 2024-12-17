using Script.CoreUObject;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.ECameraAnimationPlaySpace")]
	public enum ECameraAnimationPlaySpace : byte
	{
		CameraLocal = 0,
		World = 1,
		UserDefined = 2,
	}
}