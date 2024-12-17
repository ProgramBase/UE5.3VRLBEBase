using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETimecodeProviderSynchronizationState")]
	public enum ETimecodeProviderSynchronizationState : int
	{
		Closed = 0,
		Error = 1,
		Synchronized = 2,
		Synchronizing = 3,
	}
}