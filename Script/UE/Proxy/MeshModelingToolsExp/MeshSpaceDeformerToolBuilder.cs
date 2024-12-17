using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MeshSpaceDeformerToolBuilder")]
	public partial class UMeshSpaceDeformerToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MeshSpaceDeformerToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}