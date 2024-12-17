using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VertexColorSmoothBrushOpProps")]
	public partial class UVertexColorSmoothBrushOpProps : UVertexColorBaseBrushOpProps, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VertexColorSmoothBrushOpProps");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}