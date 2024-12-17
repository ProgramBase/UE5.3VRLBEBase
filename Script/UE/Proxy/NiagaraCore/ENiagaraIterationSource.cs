using Script.CoreUObject;

namespace Script.NiagaraCore
{
	[PathName("/Script/NiagaraCore.ENiagaraIterationSource")]
	public enum ENiagaraIterationSource : byte
	{
		Particles = 0,
		DataInterface = 1,
		DirectSet = 2,
	}
}