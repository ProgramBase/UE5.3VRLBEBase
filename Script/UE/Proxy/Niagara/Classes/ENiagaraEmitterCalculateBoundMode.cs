using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraEmitterCalculateBoundMode")]
	public enum ENiagaraEmitterCalculateBoundMode : byte
	{
		Dynamic = 0,
		Fixed = 1,
		Programmable = 2,
	}
}