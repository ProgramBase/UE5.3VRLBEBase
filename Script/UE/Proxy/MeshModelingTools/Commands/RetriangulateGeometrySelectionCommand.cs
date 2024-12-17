using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.RetriangulateGeometrySelectionCommand")]
	public partial class URetriangulateGeometrySelectionCommand : UGeometrySelectionEditCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.RetriangulateGeometrySelectionCommand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}