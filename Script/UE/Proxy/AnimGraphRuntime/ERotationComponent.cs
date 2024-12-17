using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ERotationComponent")]
	public enum ERotationComponent : byte
	{
		EulerX = 0,
		EulerY = 1,
		EulerZ = 2,
		QuaternionAngle = 3,
		SwingAngle = 4,
		TwistAngle = 5,
	}
}