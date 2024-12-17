using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELevelInstanceRuntimeBehavior")]
	public enum ELevelInstanceRuntimeBehavior : byte
	{
		None = 0,
		Embedded_Deprecated = 1,
		Partitioned = 2,
		LevelStreaming = 3,
	}
}