using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionSourceStatusFlags")]
	public enum ERootMotionSourceStatusFlags : long
	{
		Prepared = 1,
		Finished = 2,
		MarkedForRemoval = 4,
	}
}