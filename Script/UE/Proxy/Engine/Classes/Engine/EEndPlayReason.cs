using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EEndPlayReason")]
	public enum EEndPlayReason : byte
	{
		Destroyed = 0,
		LevelTransition = 1,
		EndPlayInEditor = 2,
		RemovedFromWorld = 3,
		Quit = 4,
	}
}