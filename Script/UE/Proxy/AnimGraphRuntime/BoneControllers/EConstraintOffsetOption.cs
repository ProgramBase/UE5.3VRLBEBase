using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EConstraintOffsetOption")]
	public enum EConstraintOffsetOption : byte
	{
		None = 0,
		Offset_RefPose = 1,
	}
}