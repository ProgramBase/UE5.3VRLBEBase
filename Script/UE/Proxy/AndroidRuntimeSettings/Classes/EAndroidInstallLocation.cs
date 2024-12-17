using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.EAndroidInstallLocation")]
	public enum EAndroidInstallLocation : byte
	{
		InternalOnly = 0,
		PreferExternal = 1,
		Auto = 2,
	}
}