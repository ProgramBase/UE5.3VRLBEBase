using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EPoseDriverType")]
	public enum EPoseDriverType : long
	{
		SwingAndTwist = 0,
		SwingOnly = 1,
		Translation = 2,
	}
}