using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EAITaskPriority")]
	public enum EAITaskPriority : long
	{
		Lowest = 0,
		Low = 64,
		AutonomousAI = 127,
		High = 192,
		Ultimate = 254,
	}
}