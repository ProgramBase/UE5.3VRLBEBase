using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAutoPossessAI")]
	public enum EAutoPossessAI : byte
	{
		Disabled = 0,
		PlacedInWorld = 1,
		Spawned = 2,
		PlacedInWorldOrSpawned = 3,
	}
}