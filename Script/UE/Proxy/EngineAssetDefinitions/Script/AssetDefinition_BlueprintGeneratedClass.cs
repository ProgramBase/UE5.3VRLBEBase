using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_BlueprintGeneratedClass")]
	public partial class UAssetDefinition_BlueprintGeneratedClass : UAssetDefinition_ClassTypeBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_BlueprintGeneratedClass");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}