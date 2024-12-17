using Script.CoreUObject;
using Script.MeshModelingToolsExp;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsToolBuilder")]
	public partial class UEditMeshMaterialsToolBuilder : UMeshSelectionToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.EditMeshMaterialsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}