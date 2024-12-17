using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELerpInterpolationMode")]
	public enum ELerpInterpolationMode : byte
	{
		QuatInterp = 0,
		EulerInterp = 1,
		DualQuatInterp = 2,
	}
}