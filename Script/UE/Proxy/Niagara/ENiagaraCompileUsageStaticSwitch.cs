using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraCompileUsageStaticSwitch")]
	public enum ENiagaraCompileUsageStaticSwitch : long
	{
		Spawn = 0,
		Update = 1,
		Event = 2,
		SimulationStage = 3,
		Default = 4,
	}
}