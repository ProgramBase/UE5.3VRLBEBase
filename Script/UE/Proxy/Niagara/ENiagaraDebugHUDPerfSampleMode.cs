using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDebugHUDPerfSampleMode")]
	public enum ENiagaraDebugHUDPerfSampleMode : int
	{
		FrameTotal = 0,
		PerInstanceAverage = 1,
	}
}