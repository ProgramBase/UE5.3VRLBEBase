using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_StaticSparseVolumeTexture")]
	public partial class UAssetDefinition_StaticSparseVolumeTexture : UAssetDefinition_SparseVolumeTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_StaticSparseVolumeTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}