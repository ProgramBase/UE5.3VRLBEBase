using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SeamSculptToolBuilder")]
	public partial class USeamSculptToolBuilder : UMeshSurfacePointMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SeamSculptToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}