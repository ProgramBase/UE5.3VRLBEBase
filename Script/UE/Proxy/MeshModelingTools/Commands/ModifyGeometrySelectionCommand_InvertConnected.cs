using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_InvertConnected")]
	public partial class UModifyGeometrySelectionCommand_InvertConnected : UModifyGeometrySelectionCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_InvertConnected");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}