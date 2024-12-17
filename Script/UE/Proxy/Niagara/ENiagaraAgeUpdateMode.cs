using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraAgeUpdateMode")]
	public enum ENiagaraAgeUpdateMode : byte
	{
		TickDeltaTime = 0,
		DesiredAge = 1,
		DesiredAgeNoSeek = 2,
	}
}