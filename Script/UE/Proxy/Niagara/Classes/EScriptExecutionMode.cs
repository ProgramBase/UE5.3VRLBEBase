using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.EScriptExecutionMode")]
	public enum EScriptExecutionMode : byte
	{
		EveryParticle = 0,
		SpawnedParticles = 1,
		SingleParticle = 2,
	}
}