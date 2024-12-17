using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.ExtractCollisionGeometryToolBuilder")]
	public partial class UExtractCollisionGeometryToolBuilder : USingleSelectionMeshEditingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.ExtractCollisionGeometryToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}