using Script.CoreUObject;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.EMetaSoundOutputAudioFormat")]
	public enum EMetaSoundOutputAudioFormat : byte
	{
		Mono = 0,
		Stereo = 1,
		Quad = 2,
		FiveDotOne = 3,
		SevenDotOne = 4,
		COUNT = 5,
	}
}