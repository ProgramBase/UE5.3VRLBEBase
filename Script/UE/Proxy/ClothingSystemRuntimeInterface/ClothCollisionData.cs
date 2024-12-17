using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothCollisionData")]
	public partial class FClothCollisionData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeInterface.ClothCollisionData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothCollisionData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothCollisionData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothCollisionData A, FClothCollisionData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothCollisionData A, FClothCollisionData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothCollisionData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FClothCollisionPrim_Sphere> Spheres
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spheres, __ReturnBuffer);

					return *(TArray<FClothCollisionPrim_Sphere>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spheres, __InBuffer);
				}
			}
		}

		public TArray<FClothCollisionPrim_SphereConnection> SphereConnections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereConnections, __ReturnBuffer);

					return *(TArray<FClothCollisionPrim_SphereConnection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereConnections, __InBuffer);
				}
			}
		}

		public TArray<FClothCollisionPrim_Convex> Convexes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Convexes, __ReturnBuffer);

					return *(TArray<FClothCollisionPrim_Convex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Convexes, __InBuffer);
				}
			}
		}

		public TArray<FClothCollisionPrim_Box> Boxes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Boxes, __ReturnBuffer);

					return *(TArray<FClothCollisionPrim_Box>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Boxes, __InBuffer);
				}
			}
		}

		private static uint __Spheres = 0;

		private static uint __SphereConnections = 0;

		private static uint __Convexes = 0;

		private static uint __Boxes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}