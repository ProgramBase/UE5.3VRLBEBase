using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.EAndroidAudio")]
	public enum EAndroidAudio : byte
	{
		Default = 0,
		OGG = 1,
		ADPCM = 2,
	}
}