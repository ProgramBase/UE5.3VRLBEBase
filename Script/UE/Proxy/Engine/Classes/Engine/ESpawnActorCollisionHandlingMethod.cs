using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESpawnActorCollisionHandlingMethod")]
	public enum ESpawnActorCollisionHandlingMethod : byte
	{
		Undefined = 0,
		AlwaysSpawn = 1,
		AdjustIfPossibleButAlwaysSpawn = 2,
		AdjustIfPossibleButDontSpawnIfColliding = 3,
		DontSpawnIfColliding = 4,
	}
}