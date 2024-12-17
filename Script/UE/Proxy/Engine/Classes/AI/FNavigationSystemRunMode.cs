using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.FNavigationSystemRunMode")]
	public enum FNavigationSystemRunMode : byte
	{
		InvalidMode = 0,
		GameMode = 1,
		EditorMode = 2,
		SimulationMode = 3,
		PIEMode = 4,
		InferFromWorldMode = 5,
		EditorWorldPartitionBuildMode = 6,
	}
}