using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.DisconnectGeometrySelectionCommand")]
	public partial class UDisconnectGeometrySelectionCommand : UGeometrySelectionEditCommand, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.DisconnectGeometrySelectionCommand");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}