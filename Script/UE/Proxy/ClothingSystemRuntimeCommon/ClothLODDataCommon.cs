using Script.CoreUObject;
using Script.Library;
using Script.ClothingSystemRuntimeInterface;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon")]
	public partial class FClothLODDataCommon : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothLODDataCommon() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothLODDataCommon() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothLODDataCommon A, FClothLODDataCommon B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothLODDataCommon A, FClothLODDataCommon B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothLODDataCommon;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FClothPhysicalMeshData PhysicalMeshData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMeshData, __ReturnBuffer);

					return *(FClothPhysicalMeshData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PhysicalMeshData, __InBuffer);
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

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionData, __ReturnBuffer);

					return *(FClothCollisionData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionData, __InBuffer);
				}
			}
		}

		public bool bUseMultipleInfluences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseMultipleInfluences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseMultipleInfluences, __InBuffer);
				}
			}
		}

		public float SkinningKernelRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SkinningKernelRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SkinningKernelRadius, __InBuffer);
				}
			}
		}

		public bool bSmoothTransition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSmoothTransition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSmoothTransition, __InBuffer);
				}
			}
		}

		public TArray<FPointWeightMap> PointWeightMaps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PointWeightMaps, __ReturnBuffer);

					return *(TArray<FPointWeightMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PointWeightMaps, __InBuffer);
				}
			}
		}

		private static uint __PhysicalMeshData = 0;

		private static uint __CollisionData = 0;

		private static uint __bUseMultipleInfluences = 0;

		private static uint __SkinningKernelRadius = 0;

		private static uint __bSmoothTransition = 0;

		private static uint __PointWeightMaps = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}