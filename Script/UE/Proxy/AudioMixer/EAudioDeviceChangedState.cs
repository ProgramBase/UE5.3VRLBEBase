using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.EAudioDeviceChangedState")]
	public enum EAudioDeviceChangedState : byte
	{
		Invalid = 0,
		Active = 1,
		Disabled = 2,
		NotPresent = 3,
		Unplugged = 4,
		Count = 5,
	}
}