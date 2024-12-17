using Script.CoreUObject;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.ENiagaraAddDefaultsTrackMode")]
	public enum ENiagaraAddDefaultsTrackMode : byte
	{
		NoSubtracks = 0,
		ComponentTrackOnly = 1,
		LifecycleTrack = 2,
	}
}