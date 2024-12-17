using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolBuilder")]
	public partial class UEditMeshPolygonsToolBuilder : USingleTargetWithSelectionToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}