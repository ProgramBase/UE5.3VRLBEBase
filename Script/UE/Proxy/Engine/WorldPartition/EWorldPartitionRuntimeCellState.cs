using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EWorldPartitionRuntimeCellState")]
	public enum EWorldPartitionRuntimeCellState : byte
	{
		Unloaded = 0,
		Loaded = 1,
		Activated = 2,
	}
}