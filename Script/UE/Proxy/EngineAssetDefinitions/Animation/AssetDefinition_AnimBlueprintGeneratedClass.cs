using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimBlueprintGeneratedClass")]
	public partial class UAssetDefinition_AnimBlueprintGeneratedClass : UAssetDefinition_BlueprintGeneratedClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimBlueprintGeneratedClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}