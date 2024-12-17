using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshPaintingToolset
{
	[PathName("/Script/MeshPaintingToolset.VertexAdapterClickToolBuilder")]
	public partial class UVertexAdapterClickToolBuilder : USingleClickToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshPaintingToolset.VertexAdapterClickToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}