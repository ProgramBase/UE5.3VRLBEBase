using Script.CoreUObject;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.EAssetRenameResult")]
	public enum EAssetRenameResult : byte
	{
		Failure = 0,
		Success = 1,
		Pending = 2,
	}
}