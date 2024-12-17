using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BasePlaneBrushOpProps")]
	public partial class UBasePlaneBrushOpProps : UMeshSculptBrushOpProps, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BasePlaneBrushOpProps");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}