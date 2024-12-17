using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.ESwapAudioOutputDeviceResultState")]
	public enum ESwapAudioOutputDeviceResultState : byte
	{
		Failure = 0,
		Success = 1,
		None = 2,
	}
}