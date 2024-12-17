using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.RecomputeUVsToolBuilder")]
	public partial class URecomputeUVsToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.RecomputeUVsToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}