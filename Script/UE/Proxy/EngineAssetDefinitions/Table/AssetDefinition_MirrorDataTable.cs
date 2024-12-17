using Script.CoreUObject;
using Script.Library;

namespace Script.EngineAssetDefinitions
{
	[PathName("/Script/EngineAssetDefinitions.AssetDefinition_MirrorDataTable")]
	public partial class UAssetDefinition_MirrorDataTable : UAssetDefinition_DataTable, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineAssetDefinitions.AssetDefinition_MirrorDataTable");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}