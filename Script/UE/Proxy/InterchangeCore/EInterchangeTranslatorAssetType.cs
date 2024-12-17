using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangeTranslatorAssetType")]
	public enum EInterchangeTranslatorAssetType : byte
	{
		None = 0,
		Textures = 1,
		Materials = 2,
		Meshes = 4,
		Animations = 8,
	}
}