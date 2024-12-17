using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_BlendSpace1D")]
	public partial class UAssetDefinition_BlendSpace1D : UAssetDefinition_AnimationAsset, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_BlendSpace1D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}