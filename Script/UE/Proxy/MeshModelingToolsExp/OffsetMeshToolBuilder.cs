using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.OffsetMeshToolBuilder")]
	public partial class UOffsetMeshToolBuilder : UBaseMeshProcessingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.OffsetMeshToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}