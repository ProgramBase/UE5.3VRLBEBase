using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.LatticeDeformerToolBuilder")]
	public partial class ULatticeDeformerToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.LatticeDeformerToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}