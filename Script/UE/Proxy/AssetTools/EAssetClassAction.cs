using Script.CoreUObject;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.EAssetClassAction")]
	public enum EAssetClassAction : long
	{
		CreateAsset = 0,
		ViewAsset = 1,
		ImportAsset = 2,
		ExportAsset = 3,
		AllAssetActions = 4,
	}
}