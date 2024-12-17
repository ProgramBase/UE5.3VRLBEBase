using Script.CoreUObject;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ERaQualityMode")]
	public enum ERaQualityMode : byte
	{
		STEREO_PANNING = 0,
		BINAURAL_LOW = 1,
		BINAURAL_MEDIUM = 2,
		BINAURAL_HIGH = 3,
	}
}