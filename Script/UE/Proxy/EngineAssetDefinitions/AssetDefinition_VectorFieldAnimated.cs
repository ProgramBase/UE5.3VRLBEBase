using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_VectorFieldAnimated")]
	public partial class UAssetDefinition_VectorFieldAnimated : UAssetDefinition_VectorField, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_VectorFieldAnimated");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}