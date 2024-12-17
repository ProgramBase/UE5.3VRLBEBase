using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.DeleteGeometrySelectionCommand")]
	public partial class UDeleteGeometrySelectionCommand : UGeometrySelectionEditCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.DeleteGeometrySelectionCommand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}