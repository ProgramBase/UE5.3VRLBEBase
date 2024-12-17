using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEvaluatorMode")]
	public enum EEvaluatorMode : byte
	{
		EM_Standard = 0,
		EM_Freeze = 1,
		EM_DelayedFreeze = 2,
	}
}