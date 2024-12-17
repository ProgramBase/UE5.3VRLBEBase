using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.MergeMeshesToolBuilder")]
	public partial class UMergeMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.MergeMeshesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}