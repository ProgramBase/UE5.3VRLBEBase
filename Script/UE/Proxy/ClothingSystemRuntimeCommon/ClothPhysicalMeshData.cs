using Script.CoreUObject;
using Script.Library;
using Script.ClothingSystemRuntimeInterface;

namespace Script.ClothingSystemRuntimeCommon
{
	[PathName("/Script/ClothingSystemRuntimeCommon.ClothPhysicalMeshData")]
	public partial class FClothPhysicalMeshData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeCommon.ClothPhysicalMeshData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothPhysicalMeshData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothPhysicalMeshData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothPhysicalMeshData A, FClothPhysicalMeshData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothPhysicalMeshData A, FClothPhysicalMeshData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothPhysicalMeshData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector3f> Vertices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vertices, __ReturnBuffer);

					return *(TArray<FVector3f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vertices, __InBuffer);
				}
			}
		}

		public TArray<FVector3f> Normals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Normals, __ReturnBuffer);

					return *(TArray<FVector3f>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Normals, __InBuffer);
				}
			}
		}

		public TArray<FColor> VertexColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexColors, __ReturnBuffer);

					return *(TArray<FColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexColors, __InBuffer);
				}
			}
		}

		public TArray<uint> Indices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Indices, __ReturnBuffer);

					return *(TArray<uint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Indices, __InBuffer);
				}
			}
		}

		public TMap<uint, FPointWeightMap> WeightMaps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeightMaps, __ReturnBuffer);

					return *(TMap<uint, FPointWeightMap>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeightMaps, __InBuffer);
				}
			}
		}

		public TArray<float> InverseMasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InverseMasses, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InverseMasses, __InBuffer);
				}
			}
		}

		public TArray<FClothVertBoneData> BoneData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneData, __ReturnBuffer);

					return *(TArray<FClothVertBoneData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneData, __InBuffer);
				}
			}
		}

		public TArray<uint> SelfCollisionIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SelfCollisionIndices, __ReturnBuffer);

					return *(TArray<uint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SelfCollisionIndices, __InBuffer);
				}
			}
		}

		public FClothTetherData EuclideanTethers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EuclideanTethers, __ReturnBuffer);

					return *(FClothTetherData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EuclideanTethers, __InBuffer);
				}
			}
		}

		public FClothTetherData GeodesicTethers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeodesicTethers, __ReturnBuffer);

					return *(FClothTetherData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeodesicTethers, __InBuffer);
				}
			}
		}

		public int MaxBoneWeights
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxBoneWeights, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxBoneWeights, __InBuffer);
				}
			}
		}

		public int NumFixedVerts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumFixedVerts, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumFixedVerts, __InBuffer);
				}
			}
		}

		private static uint __Vertices = 0;

		private static uint __Normals = 0;

		private static uint __VertexColors = 0;

		private static uint __Indices = 0;

		private static uint __WeightMaps = 0;

		private static uint __InverseMasses = 0;

		private static uint __BoneData = 0;

		private static uint __SelfCollisionIndices = 0;

		private static uint __EuclideanTethers = 0;

		private static uint __GeodesicTethers = 0;

		private static uint __MaxBoneWeights = 0;

		private static uint __NumFixedVerts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}