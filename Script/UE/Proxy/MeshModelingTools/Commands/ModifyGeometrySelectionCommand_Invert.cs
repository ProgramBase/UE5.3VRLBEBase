using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Invert")]
	public partial class UModifyGeometrySelectionCommand_Invert : UModifyGeometrySelectionCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Invert");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}