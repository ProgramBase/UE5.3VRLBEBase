using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTarget")]
	public partial class UAssetDefinition_TextureRenderTarget : UAssetDefinition_Texture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTarget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}