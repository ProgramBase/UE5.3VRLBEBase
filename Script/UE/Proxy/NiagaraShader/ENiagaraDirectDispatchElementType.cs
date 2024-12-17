using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.ENiagaraDirectDispatchElementType")]
	public enum ENiagaraDirectDispatchElementType : byte
	{
		NumThreads = 0,
		NumThreadsNoClipping = 1,
		NumGroups = 2,
	}
}