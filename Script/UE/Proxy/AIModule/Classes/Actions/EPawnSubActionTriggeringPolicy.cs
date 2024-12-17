using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EPawnSubActionTriggeringPolicy")]
	public enum EPawnSubActionTriggeringPolicy : long
	{
		CopyBeforeTriggering = 0,
		ReuseInstances = 1,
	}
}