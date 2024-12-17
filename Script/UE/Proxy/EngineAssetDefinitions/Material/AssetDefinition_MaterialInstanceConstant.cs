using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MaterialInstanceConstant")]
	public partial class UAssetDefinition_MaterialInstanceConstant : UAssetDefinition_MaterialInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MaterialInstanceConstant");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}