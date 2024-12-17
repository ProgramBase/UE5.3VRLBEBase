using Script.CoreUObject;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.VertexAdapterClickTool")]
	public partial class UVertexAdapterClickTool : UMeshClickTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.VertexAdapterClickTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}