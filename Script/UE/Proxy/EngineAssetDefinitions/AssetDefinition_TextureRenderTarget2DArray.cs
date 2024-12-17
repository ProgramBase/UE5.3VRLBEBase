using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTarget2DArray")]
	public partial class UAssetDefinition_TextureRenderTarget2DArray : UAssetDefinition_TextureRenderTarget, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_TextureRenderTarget2DArray");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}