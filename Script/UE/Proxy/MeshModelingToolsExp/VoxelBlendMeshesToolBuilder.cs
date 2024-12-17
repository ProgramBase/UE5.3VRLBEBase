using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VoxelBlendMeshesToolBuilder")]
	public partial class UVoxelBlendMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VoxelBlendMeshesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}