using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ClothingSystemRuntimeNv
{
	[PathName("/Script/ClothingSystemRuntimeNv.ClothPhysicalMeshDataNv_Legacy")]
	public partial class UClothPhysicalMeshDataNv_Legacy : UClothPhysicalMeshDataBase_Legacy, IStaticClass
	{
		public TArray<float> MaxDistances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDistances, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDistances, __InBuffer);
				}
			}
		}

		public TArray<float> BackstopDistances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BackstopDistances, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BackstopDistances, __InBuffer);
				}
			}
		}

		public TArray<float> BackstopRadiuses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BackstopRadiuses, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BackstopRadiuses, __InBuffer);
				}
			}
		}

		public TArray<float> AnimDriveMultipliers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimDriveMultipliers, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimDriveMultipliers, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeNv.ClothPhysicalMeshDataNv_Legacy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MaxDistances = 0;

		private static uint __BackstopDistances = 0;

		private static uint __BackstopRadiuses = 0;

		private static uint __AnimDriveMultipliers = 0;
	}
}