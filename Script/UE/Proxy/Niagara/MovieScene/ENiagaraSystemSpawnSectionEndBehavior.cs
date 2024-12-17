using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSystemSpawnSectionEndBehavior")]
	public enum ENiagaraSystemSpawnSectionEndBehavior : int
	{
		SetSystemInactive = 0,
		Deactivate = 1,
		None = 2,
	}
}