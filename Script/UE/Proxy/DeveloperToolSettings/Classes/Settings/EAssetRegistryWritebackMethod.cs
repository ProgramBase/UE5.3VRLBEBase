using Script.CoreUObject;

namespace Script.DeveloperToolSettings
{
	[PathName("/Script/DeveloperToolSettings.EAssetRegistryWritebackMethod")]
	public enum EAssetRegistryWritebackMethod : byte
	{
		Disabled = 0,
		OriginalFile = 1,
		AdjacentFile = 2,
	}
}