using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.BakeMultiMeshAttributeMapsToolBuilder")]
	public partial class UBakeMultiMeshAttributeMapsToolBuilder : UMultiSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.BakeMultiMeshAttributeMapsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}