using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraGpuComputeTickStage")]
	public enum ENiagaraGpuComputeTickStage : byte
	{
		PreInitViews = 0,
		PostInitViews = 1,
		PostOpaqueRender = 2,
		Max = 3,
		First = 0,
		Last = 2,
	}
}