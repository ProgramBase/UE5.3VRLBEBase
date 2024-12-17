using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_LandscapeGrassType")]
	public partial class UAssetDefinition_LandscapeGrassType : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_LandscapeGrassType");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}