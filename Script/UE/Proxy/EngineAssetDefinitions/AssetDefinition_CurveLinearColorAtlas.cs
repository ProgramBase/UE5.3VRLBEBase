using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CurveLinearColorAtlas")]
	public partial class UAssetDefinition_CurveLinearColorAtlas : UAssetDefinition_Texture, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CurveLinearColorAtlas");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}