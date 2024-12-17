using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerBlend")]
	public partial class UAssetDefinition_MaterialFunctionLayerBlend : UAssetDefinition_MaterialFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionLayerBlend");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}