using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.DynamicMeshSculptToolBuilder")]
	public partial class UDynamicMeshSculptToolBuilder : UMeshSurfacePointMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.DynamicMeshSculptToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}