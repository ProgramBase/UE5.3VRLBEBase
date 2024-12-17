using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTargetCube")]
	public partial class UAssetDefinition_TextureRenderTargetCube : UAssetDefinition_TextureRenderTarget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTargetCube");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}