using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENiagaraDebugPlaybackMode")]
	public enum ENiagaraDebugPlaybackMode : byte
	{
		Play = 0,
		Loop = 1,
		Paused = 2,
		Step = 3,
	}
}