using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialInstanceDynamic")]
	public partial class UAssetDefinition_MaterialInstanceDynamic : UAssetDefinition_MaterialInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialInstanceDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}