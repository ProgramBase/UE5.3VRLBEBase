using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Contract")]
	public partial class UModifyGeometrySelectionCommand_Contract : UModifyGeometrySelectionCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.ModifyGeometrySelectionCommand_Contract");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}