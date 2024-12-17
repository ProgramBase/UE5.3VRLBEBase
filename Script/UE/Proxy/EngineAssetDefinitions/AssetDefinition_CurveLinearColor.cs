using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CurveLinearColor")]
	public partial class UAssetDefinition_CurveLinearColor : UAssetDefinition_Curve, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CurveLinearColor");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}