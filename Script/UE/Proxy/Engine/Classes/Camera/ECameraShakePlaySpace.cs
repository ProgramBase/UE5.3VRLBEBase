using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECameraShakePlaySpace")]
	public enum ECameraShakePlaySpace : byte
	{
		CameraLocal = 0,
		World = 1,
		UserDefined = 2,
	}
}