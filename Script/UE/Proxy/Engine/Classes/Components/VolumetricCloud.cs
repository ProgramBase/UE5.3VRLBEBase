using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VolumetricCloud")]
	public partial class AVolumetricCloud : AInfo, IStaticClass
	{
		public UVolumetricCloudComponent VolumetricCloudComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricCloudComponent, __ReturnBuffer);

					return *(UVolumetricCloudComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumetricCloudComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.VolumetricCloud");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VolumetricCloudComponent = 0;
	}
}