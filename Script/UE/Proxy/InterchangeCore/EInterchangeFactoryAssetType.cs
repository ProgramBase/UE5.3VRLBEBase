using Script.CoreUObject;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.EInterchangeFactoryAssetType")]
	public enum EInterchangeFactoryAssetType : long
	{
		None = 0,
		Textures = 1,
		Materials = 2,
		Meshes = 3,
		Animations = 4,
		Physics = 5,
	}
}