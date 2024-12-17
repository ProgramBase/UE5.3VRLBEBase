using Script.CoreUObject;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.EResonanceRenderMode")]
	public enum EResonanceRenderMode : byte
	{
		StereoPanning = 0,
		BinauralLowQuality = 1,
		BinauralMediumQuality = 2,
		BinauralHighQuality = 3,
		RoomEffectsOnly = 4,
	}
}