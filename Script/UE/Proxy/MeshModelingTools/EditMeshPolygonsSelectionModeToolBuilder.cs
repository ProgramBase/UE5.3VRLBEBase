using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsSelectionModeToolBuilder")]
	public partial class UEditMeshPolygonsSelectionModeToolBuilder : UEditMeshPolygonsToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsSelectionModeToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}