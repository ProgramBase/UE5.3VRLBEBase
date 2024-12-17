using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DeformMeshPolygonsToolBuilder")]
	public partial class UDeformMeshPolygonsToolBuilder : UMeshSurfacePointMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DeformMeshPolygonsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}