using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EPoseDriverOutput")]
	public enum EPoseDriverOutput : byte
	{
		DrivePoses = 0,
		DriveCurves = 1,
	}
}