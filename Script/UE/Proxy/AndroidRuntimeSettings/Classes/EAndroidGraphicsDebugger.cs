using Script.CoreUObject;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.EAndroidGraphicsDebugger")]
	public enum EAndroidGraphicsDebugger : byte
	{
		None = 0,
		Mali = 1,
		Adreno = 2,
	}
}