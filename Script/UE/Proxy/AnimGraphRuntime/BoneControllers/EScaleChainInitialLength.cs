using Script.CoreUObject;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.EScaleChainInitialLength")]
	public enum EScaleChainInitialLength : byte
	{
		FixedDefaultLengthValue = 0,
		Distance = 1,
		ChainLength = 2,
	}
}