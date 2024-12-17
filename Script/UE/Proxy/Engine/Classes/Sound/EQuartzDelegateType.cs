using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuartzDelegateType")]
	public enum EQuartzDelegateType : long
	{
		MetronomeTick = 0,
		CommandEvent = 1,
		Count = 2,
	}
}