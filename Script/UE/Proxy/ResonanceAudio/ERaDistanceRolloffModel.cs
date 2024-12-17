using Script.CoreUObject;

namespace Script.ResonanceAudio
{
	[PathName("/Script/ResonanceAudio.ERaDistanceRolloffModel")]
	public enum ERaDistanceRolloffModel : byte
	{
		LOGARITHMIC = 0,
		LINEAR = 1,
		NONE = 2,
	}
}