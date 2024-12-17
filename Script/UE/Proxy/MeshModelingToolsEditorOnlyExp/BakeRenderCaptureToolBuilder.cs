using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.BakeRenderCaptureToolBuilder")]
	public partial class UBakeRenderCaptureToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.BakeRenderCaptureToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}