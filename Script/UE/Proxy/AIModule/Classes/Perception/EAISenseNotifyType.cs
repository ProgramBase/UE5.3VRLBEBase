using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EAISenseNotifyType")]
	public enum EAISenseNotifyType : byte
	{
		OnEveryPerception = 0,
		OnPerceptionChange = 1,
	}
}