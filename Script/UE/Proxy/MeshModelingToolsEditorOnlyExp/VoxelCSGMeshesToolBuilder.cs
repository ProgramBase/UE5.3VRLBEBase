using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.VoxelCSGMeshesToolBuilder")]
	public partial class UVoxelCSGMeshesToolBuilder : UBaseCreateFromSelectedToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.VoxelCSGMeshesToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}