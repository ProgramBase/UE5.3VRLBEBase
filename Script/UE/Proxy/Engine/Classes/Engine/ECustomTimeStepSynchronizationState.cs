using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECustomTimeStepSynchronizationState")]
	public enum ECustomTimeStepSynchronizationState : long
	{
		Closed = 0,
		Error = 1,
		Synchronized = 2,
		Synchronizing = 3,
	}
}