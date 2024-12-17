using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_EditorUtilityBlueprint")]
	public partial class UAssetDefinition_EditorUtilityBlueprint : UAssetDefinition_Blueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_EditorUtilityBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}