using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangePipelineContext")]
	public enum EInterchangePipelineContext : long
	{
		None = 0,
		AssetImport = 1,
		AssetReimport = 2,
		SceneImport = 3,
		SceneReimport = 4,
		AssetCustomLODImport = 5,
		AssetCustomLODReimport = 6,
		AssetAlternateSkinningImport = 7,
		AssetAlternateSkinningReimport = 8,
	}
}