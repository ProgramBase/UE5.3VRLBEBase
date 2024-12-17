using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ERBFDistanceMethod")]
	public enum ERBFDistanceMethod : byte
	{
		Euclidean = 0,
		Quaternion = 1,
		SwingAngle = 2,
		TwistAngle = 3,
		DefaultMethod = 4,
	}
}