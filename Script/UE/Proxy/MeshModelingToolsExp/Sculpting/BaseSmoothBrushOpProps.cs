using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BaseSmoothBrushOpProps")]
	public partial class UBaseSmoothBrushOpProps : UMeshSculptBrushOpProps, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BaseSmoothBrushOpProps");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}