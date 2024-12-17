using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionRootLock")]
	public enum ERootMotionRootLock : byte
	{
		RefPose = 0,
		AnimFirstFrame = 1,
		Zero = 2,
	}
}