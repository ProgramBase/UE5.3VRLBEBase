using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EAIRequestPriority")]
	public enum EAIRequestPriority : byte
	{
		SoftScript = 0,
		Logic = 1,
		HardScript = 2,
		Reaction = 3,
		Ultimate = 4,
	}
}