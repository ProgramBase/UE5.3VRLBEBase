using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CanvasRenderTarget2D")]
	public partial class UAssetDefinition_CanvasRenderTarget2D : UAssetDefinition_TextureRenderTarget2D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CanvasRenderTarget2D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}