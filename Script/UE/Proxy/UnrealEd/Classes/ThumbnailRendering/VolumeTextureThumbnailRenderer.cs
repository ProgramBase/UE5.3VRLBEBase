using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.VolumeTextureThumbnailRenderer")]
	public partial class UVolumeTextureThumbnailRenderer : UDefaultSizedThumbnailRenderer, IStaticClass
	{
		public UMaterialInstanceConstant MaterialInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialInstance, __ReturnBuffer);

					return *(UMaterialInstanceConstant*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialInstance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.VolumeTextureThumbnailRenderer");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaterialInstance = 0;
	}
}