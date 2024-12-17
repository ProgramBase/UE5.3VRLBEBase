using Script.CoreUObject;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.EAudioDeviceChangedRole")]
	public enum EAudioDeviceChangedRole : byte
	{
		Invalid = 0,
		Console = 1,
		Multimedia = 2,
		Communications = 3,
		Count = 4,
	}
}