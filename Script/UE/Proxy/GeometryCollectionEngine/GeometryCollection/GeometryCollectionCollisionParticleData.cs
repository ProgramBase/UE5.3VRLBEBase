using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionCollisionParticleData")]
	public partial class FGeometryCollectionCollisionParticleData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionCollisionParticleData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionCollisionParticleData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionCollisionParticleData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionCollisionParticleData A, FGeometryCollectionCollisionParticleData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionCollisionParticleData A, FGeometryCollectionCollisionParticleData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionCollisionParticleData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float CollisionParticlesFraction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollisionParticlesFraction, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollisionParticlesFraction, __InBuffer);
				}
			}
		}

		public int MaximumCollisionParticles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaximumCollisionParticles, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaximumCollisionParticles, __InBuffer);
				}
			}
		}

		private static uint __CollisionParticlesFraction = 0;

		private static uint __MaximumCollisionParticles = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}