using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTargetVolume")]
	public partial class UAssetDefinition_TextureRenderTargetVolume : UAssetDefinition_TextureRenderTarget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTargetVolume");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}