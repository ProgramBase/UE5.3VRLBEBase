using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERootMotionAccumulateMode")]
	public enum ERootMotionAccumulateMode : byte
	{
		Override = 0,
		Additive = 1,
	}
}