using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.BaseVoxelTool")]
	public partial class UBaseVoxelTool : UBaseCreateFromSelectedTool, IStaticClass
	{
		public UVoxelProperties VoxProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VoxProperties, __ReturnBuffer);

					return *(UVoxelProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VoxProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.BaseVoxelTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VoxProperties = 0;
	}
}