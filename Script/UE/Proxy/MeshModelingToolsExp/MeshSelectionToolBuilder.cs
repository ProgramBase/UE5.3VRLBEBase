using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSelectionToolBuilder")]
	public partial class UMeshSelectionToolBuilder : UMeshSurfacePointMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSelectionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}