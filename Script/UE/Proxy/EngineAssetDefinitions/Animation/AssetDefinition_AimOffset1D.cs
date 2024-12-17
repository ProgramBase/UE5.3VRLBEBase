using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_AimOffset1D")]
	public partial class UAssetDefinition_AimOffset1D : UAssetDefinition_BlendSpace1D, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_AimOffset1D");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}