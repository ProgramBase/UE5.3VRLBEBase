using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimComposite")]
	public partial class UAssetDefinition_AnimComposite : UAssetDefinition_AnimationAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimComposite");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}