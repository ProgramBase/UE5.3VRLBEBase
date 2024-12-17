using Script.CoreUObject;
using Script.Library;
using Script.Chaos;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionCollisionTypeData")]
	public partial class FGeometryCollectionCollisionTypeData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionCollisionTypeData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionCollisionTypeData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionCollisionTypeData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionCollisionTypeData A, FGeometryCollectionCollisionTypeData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionCollisionTypeData A, FGeometryCollectionCollisionTypeData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionCollisionTypeData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECollisionTypeEnum CollisionType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionType, __ReturnBuffer);

					return *(ECollisionTypeEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionType, __InBuffer);
				}
			}
		}

		public EImplicitTypeEnum ImplicitType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImplicitType, __ReturnBuffer);

					return *(EImplicitTypeEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImplicitType, __InBuffer);
				}
			}
		}

		public FGeometryCollectionLevelSetData LevelSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LevelSet, __ReturnBuffer);

					return *(FGeometryCollectionLevelSetData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LevelSet, __InBuffer);
				}
			}
		}

		public FGeometryCollectionCollisionParticleData CollisionParticles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionParticles, __ReturnBuffer);

					return *(FGeometryCollectionCollisionParticleData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionParticles, __InBuffer);
				}
			}
		}

		public float CollisionObjectReductionPercentage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionObjectReductionPercentage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionObjectReductionPercentage, __InBuffer);
				}
			}
		}

		public float CollisionMarginFraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionMarginFraction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionMarginFraction, __InBuffer);
				}
			}
		}

		private static uint __CollisionType = 0;

		private static uint __ImplicitType = 0;

		private static uint __LevelSet = 0;

		private static uint __CollisionParticles = 0;

		private static uint __CollisionObjectReductionPercentage = 0;

		private static uint __CollisionMarginFraction = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}