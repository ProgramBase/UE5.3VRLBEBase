using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ESequenceEvalReinit")]
	public enum ESequenceEvalReinit : byte
	{
		NoReset = 0,
		StartPosition = 1,
		ExplicitTime = 2,
	}
}