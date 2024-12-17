using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_CompositeDataTable")]
	public partial class UAssetDefinition_CompositeDataTable : UAssetDefinition_DataTable, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_CompositeDataTable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}