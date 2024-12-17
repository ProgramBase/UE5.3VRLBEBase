using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AnimMontage")]
	public partial class UAssetDefinition_AnimMontage : UAssetDefinition_AnimationAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AnimMontage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}