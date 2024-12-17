using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CompositeCurveTable")]
	public partial class UAssetDefinition_CompositeCurveTable : UAssetDefinition_CurveTable, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CompositeCurveTable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}