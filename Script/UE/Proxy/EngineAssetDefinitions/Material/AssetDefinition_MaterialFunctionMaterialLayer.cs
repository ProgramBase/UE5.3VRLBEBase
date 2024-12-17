using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionMaterialLayer")]
	public partial class UAssetDefinition_MaterialFunctionMaterialLayer : UAssetDefinition_MaterialFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionMaterialLayer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}