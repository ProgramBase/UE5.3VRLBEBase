using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_ExpandToConnected")]
	public partial class UModifyGeometrySelectionCommand_ExpandToConnected : UModifyGeometrySelectionCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_ExpandToConnected");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}