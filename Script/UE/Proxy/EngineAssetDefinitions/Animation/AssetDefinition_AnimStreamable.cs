using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimStreamable")]
	public partial class UAssetDefinition_AnimStreamable : UAssetDefinition_AnimationAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimStreamable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}