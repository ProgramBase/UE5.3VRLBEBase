using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.MeshSurfacePointMeshEditingToolBuilder")]
	public partial class UMeshSurfacePointMeshEditingToolBuilder : UMeshSurfacePointToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.MeshSurfacePointMeshEditingToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}