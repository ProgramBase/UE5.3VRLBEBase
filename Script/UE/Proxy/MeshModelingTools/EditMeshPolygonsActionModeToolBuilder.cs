using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsActionModeToolBuilder")]
	public partial class UEditMeshPolygonsActionModeToolBuilder : UEditMeshPolygonsToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsActionModeToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}