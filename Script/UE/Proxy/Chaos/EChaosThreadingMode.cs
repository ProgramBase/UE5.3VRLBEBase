using Script.CoreUObject;

namespace Script.Chaos
{
	[PathName("/Script/Chaos.EChaosThreadingMode")]
	public enum EChaosThreadingMode : byte
	{
		DedicatedThread = 0,
		TaskGraph = 1,
		SingleThread = 2,
		Num = 3,
		Invalid = 4,
	}
}