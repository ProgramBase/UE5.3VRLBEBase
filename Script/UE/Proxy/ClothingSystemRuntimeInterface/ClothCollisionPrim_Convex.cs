using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Convex")]
	public partial class FClothCollisionPrim_Convex : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_Convex");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothCollisionPrim_Convex() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothCollisionPrim_Convex() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothCollisionPrim_Convex A, FClothCollisionPrim_Convex B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothCollisionPrim_Convex A, FClothCollisionPrim_Convex B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothCollisionPrim_Convex;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FClothCollisionPrim_ConvexFace> Faces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Faces, __ReturnBuffer);

					return *(TArray<FClothCollisionPrim_ConvexFace>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Faces, __InBuffer);
				}
			}
		}

		public TArray<FVector> SurfacePoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SurfacePoints, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SurfacePoints, __InBuffer);
				}
			}
		}

		public int BoneIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneIndex, __InBuffer);
				}
			}
		}

		private static uint __Faces = 0;

		private static uint __SurfacePoints = 0;

		private static uint __BoneIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}