using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BakeMeshAttributeVertexToolBuilder")]
	public partial class UBakeMeshAttributeVertexToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BakeMeshAttributeVertexToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}