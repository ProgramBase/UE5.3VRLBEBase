using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraScalabilityUpdateFrequency")]
	public enum ENiagaraScalabilityUpdateFrequency : int
	{
		SpawnOnly = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		Continuous = 4,
	}
}