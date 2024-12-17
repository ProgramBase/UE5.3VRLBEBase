using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EMonolithicPathMode")]
	public enum EMonolithicPathMode : byte
	{
		MountPath = 0,
		PackagePath = 1,
	}
}