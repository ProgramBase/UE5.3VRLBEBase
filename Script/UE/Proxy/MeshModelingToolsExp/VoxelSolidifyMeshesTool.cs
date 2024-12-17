using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.VoxelSolidifyMeshesTool")]
	public partial class UVoxelSolidifyMeshesTool : UBaseVoxelTool, IStaticClass
	{
		public UVoxelSolidifyMeshesToolProperties SolidifyProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SolidifyProperties, __ReturnBuffer);

					return *(UVoxelSolidifyMeshesToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SolidifyProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.VoxelSolidifyMeshesTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SolidifyProperties = 0;
	}
}