using Script.CoreUObject;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ERaSpatializationMethod")]
	public enum ERaSpatializationMethod : byte
	{
		STEREO_PANNING = 0,
		HRTF = 1,
	}
}