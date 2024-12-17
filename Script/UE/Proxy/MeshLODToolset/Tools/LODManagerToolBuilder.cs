using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshLODToolset
{
	[PathName("/Script/MeshLODToolset.LODManagerToolBuilder")]
	public partial class ULODManagerToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshLODToolset.LODManagerToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}