using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EQuartzCommandType")]
	public enum EQuartzCommandType : long
	{
		PlaySound = 0,
		QueueSoundToPlay = 1,
		RetriggerSound = 2,
		TickRateChange = 3,
		TransportReset = 4,
		StartOtherClock = 5,
		Notify = 6,
		Custom = 7,
	}
}