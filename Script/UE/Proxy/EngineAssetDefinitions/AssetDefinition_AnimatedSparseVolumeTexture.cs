using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimatedSparseVolumeTexture")]
	public partial class UAssetDefinition_AnimatedSparseVolumeTexture : UAssetDefinition_SparseVolumeTexture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimatedSparseVolumeTexture");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}