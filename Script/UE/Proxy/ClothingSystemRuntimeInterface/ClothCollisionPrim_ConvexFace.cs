using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_ConvexFace")]
	public partial class FClothCollisionPrim_ConvexFace : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_ConvexFace");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothCollisionPrim_ConvexFace() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothCollisionPrim_ConvexFace() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothCollisionPrim_ConvexFace A, FClothCollisionPrim_ConvexFace B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothCollisionPrim_ConvexFace A, FClothCollisionPrim_ConvexFace B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothCollisionPrim_ConvexFace;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPlane Plane
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Plane, __ReturnBuffer);

					return *(FPlane*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Plane, __InBuffer);
				}
			}
		}

		public TArray<int> Indices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Indices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
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

		private static uint __Plane = 0;

		private static uint __Indices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}