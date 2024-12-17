using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshVertexPaintToolActionPropertySet")]
	public partial class UMeshVertexPaintToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshVertexPaintToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}