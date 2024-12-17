using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraScriptGroup")]
	public enum ENiagaraScriptGroup : long
	{
		Particle = 0,
		Emitter = 1,
		System = 2,
		Max = 3,
	}
}