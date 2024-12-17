using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolBuilder")]
	public partial class UGenerateStaticMeshLODAssetToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.GenerateStaticMeshLODAssetToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}