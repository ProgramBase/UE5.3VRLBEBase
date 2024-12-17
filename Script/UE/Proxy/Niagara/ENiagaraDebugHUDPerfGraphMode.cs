using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDebugHUDPerfGraphMode")]
	public enum ENiagaraDebugHUDPerfGraphMode : int
	{
		GameThread = 0,
		RenderThread = 1,
		GPU = 2,
	}
}