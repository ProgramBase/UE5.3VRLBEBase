using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSystemInstanceState")]
	public enum ENiagaraSystemInstanceState : long
	{
		None = 0,
		PendingSpawn = 1,
		PendingSpawnPaused = 2,
		Spawning = 3,
		Running = 4,
		Paused = 5,
		Num = 6,
	}
}