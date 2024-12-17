using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimSequence")]
	public partial class UAssetDefinition_AnimSequence : UAssetDefinition_AnimationAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimSequence");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}