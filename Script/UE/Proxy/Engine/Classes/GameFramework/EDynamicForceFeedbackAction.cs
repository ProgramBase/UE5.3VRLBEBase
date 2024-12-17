using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDynamicForceFeedbackAction")]
	public enum EDynamicForceFeedbackAction : byte
	{
		Start = 0,
		Update = 1,
		Stop = 2,
	}
}