using Script.CoreUObject;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.ERBFQuatDistanceType")]
	public enum ERBFQuatDistanceType : byte
	{
		Euclidean = 0,
		ArcLength = 1,
		SwingAngle = 2,
		TwistAngle = 3,
	}
}