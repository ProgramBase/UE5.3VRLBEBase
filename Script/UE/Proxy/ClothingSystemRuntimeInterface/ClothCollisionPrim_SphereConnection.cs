using Script.CoreUObject;
using Script.Library;

namespace Script.ClothingSystemRuntimeInterface
{
	[PathName("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_SphereConnection")]
	public partial class FClothCollisionPrim_SphereConnection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothingSystemRuntimeInterface.ClothCollisionPrim_SphereConnection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FClothCollisionPrim_SphereConnection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FClothCollisionPrim_SphereConnection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FClothCollisionPrim_SphereConnection A, FClothCollisionPrim_SphereConnection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FClothCollisionPrim_SphereConnection A, FClothCollisionPrim_SphereConnection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FClothCollisionPrim_SphereConnection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SphereIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereIndices, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereIndices, __InBuffer);
				}
			}
		}

		private static uint __SphereIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}