using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_InstancedFoliageSettings")]
	public partial class UAssetDefinition_InstancedFoliageSettings : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_InstancedFoliageSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}