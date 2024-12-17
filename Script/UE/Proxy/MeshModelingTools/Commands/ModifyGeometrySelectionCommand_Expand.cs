using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Expand")]
	public partial class UModifyGeometrySelectionCommand_Expand : UModifyGeometrySelectionCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Expand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}