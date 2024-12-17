using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.RevolveBoundaryToolBuilder")]
	public partial class URevolveBoundaryToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.RevolveBoundaryToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}