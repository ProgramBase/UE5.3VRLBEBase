using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.AssetDefinition_StaticMeshLODGenerationSettings")]
	public partial class UAssetDefinition_StaticMeshLODGenerationSettings : UAssetDefinitionDefault, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.AssetDefinition_StaticMeshLODGenerationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}