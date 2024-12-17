using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolActionPropertySet")]
	public partial class UEditMeshPolygonsToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}