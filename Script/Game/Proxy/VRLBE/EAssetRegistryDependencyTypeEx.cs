using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EAssetRegistryDependencyTypeEx")]
	public enum EAssetRegistryDependencyTypeEx : byte
	{
		None = 0,
		Soft = 1,
		Hard = 2,
		SearchableName = 4,
		SoftManage = 8,
		HardManage = 16,
		Packages = 3,
		Manage = 24,
		All = 31,
	}
}