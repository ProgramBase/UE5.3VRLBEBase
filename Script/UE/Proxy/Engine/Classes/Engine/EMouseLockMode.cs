using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMouseLockMode")]
	public enum EMouseLockMode : byte
	{
		DoNotLock = 0,
		LockOnCapture = 1,
		LockAlways = 2,
		LockInFullscreen = 3,
	}
}