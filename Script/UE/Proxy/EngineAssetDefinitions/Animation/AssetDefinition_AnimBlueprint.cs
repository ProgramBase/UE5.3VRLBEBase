using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimBlueprint")]
	public partial class UAssetDefinition_AnimBlueprint : UAssetDefinition_Blueprint, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}