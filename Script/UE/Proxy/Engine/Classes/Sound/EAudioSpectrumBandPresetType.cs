using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioSpectrumBandPresetType")]
	public enum EAudioSpectrumBandPresetType : byte
	{
		KickDrum = 0,
		SnareDrum = 1,
		Voice = 2,
		Cymbals = 3,
	}
}