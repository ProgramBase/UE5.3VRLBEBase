using Script.CoreUObject;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.EAssetMigrationConflict")]
	public enum EAssetMigrationConflict : byte
	{
		Skip = 0,
		Overwrite = 1,
		Cancel = 2,
	}
}