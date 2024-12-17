using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerInstance")]
	public partial class UAssetDefinition_MaterialFunctionLayerInstance : UAssetDefinition_MaterialFunctionInstance, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}