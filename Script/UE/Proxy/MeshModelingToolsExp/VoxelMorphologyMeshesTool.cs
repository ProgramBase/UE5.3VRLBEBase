using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VoxelMorphologyMeshesTool")]
	public partial class UVoxelMorphologyMeshesTool : UBaseVoxelTool, IStaticClass
	{
		public UVoxelMorphologyMeshesToolProperties MorphologyProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MorphologyProperties, __ReturnBuffer);

					return *(UVoxelMorphologyMeshesToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MorphologyProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VoxelMorphologyMeshesTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MorphologyProperties = 0;
	}
}