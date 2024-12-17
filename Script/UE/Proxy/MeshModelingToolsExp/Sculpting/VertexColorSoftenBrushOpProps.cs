using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VertexColorSoftenBrushOpProps")]
	public partial class UVertexColorSoftenBrushOpProps : UVertexColorBaseBrushOpProps, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VertexColorSoftenBrushOpProps");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}