using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CurveVector")]
	public partial class UAssetDefinition_CurveVector : UAssetDefinition_Curve, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CurveVector");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}