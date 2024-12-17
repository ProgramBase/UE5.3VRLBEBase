using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesToolBuilder")]
	public partial class URemoveOccludedTrianglesToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RemoveOccludedTrianglesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}