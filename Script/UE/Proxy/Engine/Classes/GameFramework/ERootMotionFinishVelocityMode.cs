using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionFinishVelocityMode")]
	public enum ERootMotionFinishVelocityMode : byte
	{
		MaintainLastRootMotionVelocity = 0,
		SetVelocity = 1,
		ClampVelocity = 2,
	}
}