using Script.CoreUObject;

namespace Script.BlendSpaceMotionAnalysis
{
	[PathName("/Script/BlendSpaceMotionAnalysis.EAnalysisRootMotionAxis")]
	public enum EAnalysisRootMotionAxis : byte
	{
		Speed = 0,
		Direction = 1,
		ForwardSpeed = 2,
		RightwardSpeed = 3,
		UpwardSpeed = 4,
		ForwardSlope = 5,
		RightwardSlope = 6,
	}
}