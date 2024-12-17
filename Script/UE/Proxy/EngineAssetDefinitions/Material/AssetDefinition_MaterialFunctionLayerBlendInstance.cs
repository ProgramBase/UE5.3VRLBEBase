using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerBlendInstance")]
	public partial class UAssetDefinition_MaterialFunctionLayerBlendInstance : UAssetDefinition_MaterialFunctionInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerBlendInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}