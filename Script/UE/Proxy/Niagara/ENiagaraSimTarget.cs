using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraSimTarget")]
	public enum ENiagaraSimTarget : byte
	{
		CPUSim = 0,
		GPUComputeSim = 1,
	}
}