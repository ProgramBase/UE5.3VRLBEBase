using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SmoothMeshToolBuilder")]
	public partial class USmoothMeshToolBuilder : UBaseMeshProcessingToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SmoothMeshToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}