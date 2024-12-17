using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_VectorFieldStatic")]
	public partial class UAssetDefinition_VectorFieldStatic : UAssetDefinition_VectorField, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_VectorFieldStatic");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}