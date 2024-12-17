using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon_Legacy")]
	public partial class UClothLODDataCommon_Legacy : UObject, IStaticClass
	{
		public FClothPhysicalMeshData ClothPhysicalMeshData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothPhysicalMeshData, __ReturnBuffer);

					return *(FClothPhysicalMeshData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothPhysicalMeshData, __InBuffer);
				}
			}
		}

		public FClothCollisionData CollisionData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionData, __ReturnBuffer);

					return *(FClothCollisionData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionData, __InBuffer);
				}
			}
		}

		public TArray<FPointWeightMap> ParameterMasks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterMasks, __ReturnBuffer);

					return *(TArray<FPointWeightMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParameterMasks, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon_Legacy");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ClothPhysicalMeshData = 0;

		private static uint __CollisionData = 0;

		private static uint __ParameterMasks = 0;
	}
}