using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnly
{
	[PathName("/Script/MeshModelingToolsEditorOnly.ParameterizeMeshToolBuilder")]
	public partial class UParameterizeMeshToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnly.ParameterizeMeshToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}