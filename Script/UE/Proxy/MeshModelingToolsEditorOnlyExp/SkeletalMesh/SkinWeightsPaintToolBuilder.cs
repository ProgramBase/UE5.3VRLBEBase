using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkinWeightsPaintToolBuilder")]
	public partial class USkinWeightsPaintToolBuilder : UMeshSurfacePointMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkinWeightsPaintToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}