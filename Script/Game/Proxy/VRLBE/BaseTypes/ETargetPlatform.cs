using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.ETargetPlatform")]
	public enum ETargetPlatform : byte
	{
		None = 0,
		AllPlatforms = 1,
		Android = 2,
		Android_ASTC = 3,
		Android_DXT = 4,
		Android_ETC2 = 5,
		AndroidClient = 6,
		Android_ASTCClient = 7,
		Android_DXTClient = 8,
		Android_ETC2Client = 9,
		Android_Multi = 10,
		Android_MultiClient = 11,
		Windows = 12,
		WindowsEditor = 13,
		WindowsServer = 14,
		WindowsClient = 15,
	}
}