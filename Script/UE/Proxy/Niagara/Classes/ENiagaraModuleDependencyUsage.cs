using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraModuleDependencyUsage")]
	public enum ENiagaraModuleDependencyUsage : long
	{
		None = 0,
		Spawn = 1,
		Update = 2,
		Event = 3,
		SimulationStage = 4,
	}
}