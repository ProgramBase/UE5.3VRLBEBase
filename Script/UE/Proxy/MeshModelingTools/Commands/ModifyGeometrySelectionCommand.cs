using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand")]
	public partial class UModifyGeometrySelectionCommand : UGeometrySelectionEditCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}