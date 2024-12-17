using Script.CoreUObject;

namespace Script.NiagaraShader
{
	[PathName("/Script/NiagaraShader.ENiagaraSimStageExecuteBehavior")]
	public enum ENiagaraSimStageExecuteBehavior : byte
	{
		Always = 0,
		OnSimulationReset = 1,
		NotOnSimulationReset = 2,
	}
}