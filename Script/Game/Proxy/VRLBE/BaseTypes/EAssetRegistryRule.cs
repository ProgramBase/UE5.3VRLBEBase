using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EAssetRegistryRule")]
	public enum EAssetRegistryRule : byte
	{
		PATCH = 0,
		PER_CHUNK = 1,
		CUSTOM = 2,
	}
}