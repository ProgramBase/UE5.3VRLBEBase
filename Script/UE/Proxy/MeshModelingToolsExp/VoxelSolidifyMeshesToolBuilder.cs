using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VoxelSolidifyMeshesToolBuilder")]
	public partial class UVoxelSolidifyMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VoxelSolidifyMeshesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}