using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_ProceduralFoliageSpawner")]
	public partial class UAssetDefinition_ProceduralFoliageSpawner : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_ProceduralFoliageSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}