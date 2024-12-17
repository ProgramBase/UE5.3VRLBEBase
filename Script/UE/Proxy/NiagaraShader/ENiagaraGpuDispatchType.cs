using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.ENiagaraGpuDispatchType")]
	public enum ENiagaraGpuDispatchType : byte
	{
		OneD = 0,
		TwoD = 1,
		ThreeD = 2,
		Custom = 3,
	}
}