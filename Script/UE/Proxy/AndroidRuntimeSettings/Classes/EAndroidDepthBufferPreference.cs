using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.EAndroidDepthBufferPreference")]
	public enum EAndroidDepthBufferPreference : byte
	{
		Default = 0,
		Bits16 = 16,
		Bits24 = 24,
		Bits32 = 32,
	}
}