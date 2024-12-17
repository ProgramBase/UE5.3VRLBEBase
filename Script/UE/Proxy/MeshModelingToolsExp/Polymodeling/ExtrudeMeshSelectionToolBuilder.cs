using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ExtrudeMeshSelectionToolBuilder")]
	public partial class UExtrudeMeshSelectionToolBuilder : USingleTargetWithSelectionToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.ExtrudeMeshSelectionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}