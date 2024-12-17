using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDefaultAudioCompressionType")]
	public enum EDefaultAudioCompressionType : byte
	{
		BinkAudio = 0,
		ADPCM = 1,
		PCM = 2,
		PlatformSpecific = 3,
	}
}