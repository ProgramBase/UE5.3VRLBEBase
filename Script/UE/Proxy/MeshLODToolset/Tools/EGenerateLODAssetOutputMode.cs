using Script.CoreUObject;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.EGenerateLODAssetOutputMode")]
	public enum EGenerateLODAssetOutputMode : byte
	{
		CreateNewAsset = 0,
		UpdateExistingAsset = 1,
	}
}