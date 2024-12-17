using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAudioBusChannels")]
	public enum EAudioBusChannels : byte
	{
		Mono = 0,
		Stereo = 1,
		Quad = 3,
		FivePointOne = 5,
		SevenPointOne = 7,
	}
}