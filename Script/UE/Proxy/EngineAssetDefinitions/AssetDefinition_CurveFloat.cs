using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CurveFloat")]
	public partial class UAssetDefinition_CurveFloat : UAssetDefinition_Curve, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CurveFloat");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}