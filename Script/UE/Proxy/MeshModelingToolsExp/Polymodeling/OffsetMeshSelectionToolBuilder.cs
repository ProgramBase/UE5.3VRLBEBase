using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.OffsetMeshSelectionToolBuilder")]
	public partial class UOffsetMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.OffsetMeshSelectionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}