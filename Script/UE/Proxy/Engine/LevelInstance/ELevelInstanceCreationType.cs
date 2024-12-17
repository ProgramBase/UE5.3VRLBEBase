using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELevelInstanceCreationType")]
	public enum ELevelInstanceCreationType : byte
	{
		LevelInstance = 0,
		PackedLevelActor = 1,
	}
}