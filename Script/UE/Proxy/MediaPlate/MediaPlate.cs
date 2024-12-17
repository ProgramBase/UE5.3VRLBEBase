using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaPlate
{
	[PathName("/Script/MediaPlate.MediaPlate")]
	public partial class AMediaPlate : AActor, IStaticClass
	{
		public UMediaPlateComponent MediaPlateComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlateComponent, __ReturnBuffer);

					return *(UMediaPlateComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlateComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlate.MediaPlate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MediaPlateComponent = 0;

		private static uint __StaticMeshComponent = 0;
	}
}