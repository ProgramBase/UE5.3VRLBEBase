using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionSizeSpecificData")]
	public partial class FGeometryCollectionSizeSpecificData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionSizeSpecificData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionSizeSpecificData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionSizeSpecificData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionSizeSpecificData A, FGeometryCollectionSizeSpecificData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionSizeSpecificData A, FGeometryCollectionSizeSpecificData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionSizeSpecificData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float MaxSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxSize, __InBuffer);
				}
			}
		}

		public TArray<FGeometryCollectionCollisionTypeData> CollisionShapes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionShapes, __ReturnBuffer);

					return *(TArray<FGeometryCollectionCollisionTypeData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionShapes, __InBuffer);
				}
			}
		}

		public int DamageThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DamageThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DamageThreshold, __InBuffer);
				}
			}
		}

		private static uint __MaxSize = 0;

		private static uint __CollisionShapes = 0;

		private static uint __DamageThreshold = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}