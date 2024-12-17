using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionInstance")]
	public partial class UAssetDefinition_MaterialFunctionInstance : UAssetDefinition_MaterialFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialFunctionInstance");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}