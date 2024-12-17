using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ENotifyTriggerMode")]
	public enum ENotifyTriggerMode : byte
	{
		AllAnimations = 0,
		HighestWeightedAnimation = 1,
		None = 2,
	}
}