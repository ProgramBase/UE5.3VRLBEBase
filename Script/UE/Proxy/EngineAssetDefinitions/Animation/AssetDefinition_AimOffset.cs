using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AimOffset")]
	public partial class UAssetDefinition_AimOffset : UAssetDefinition_BlendSpace, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AimOffset");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}