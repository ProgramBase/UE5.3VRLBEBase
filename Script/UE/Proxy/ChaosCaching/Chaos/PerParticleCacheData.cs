using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.PerParticleCacheData")]
	public partial class FPerParticleCacheData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.PerParticleCacheData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerParticleCacheData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerParticleCacheData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerParticleCacheData A, FPerParticleCacheData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerParticleCacheData A, FPerParticleCacheData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerParticleCacheData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FParticleTransformTrack TransformData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformData, __ReturnBuffer);

					return *(FParticleTransformTrack*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformData, __InBuffer);
				}
			}
		}

		public TMap<FName, FRichCurve> CurveData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CurveData, __ReturnBuffer);

					return *(TMap<FName, FRichCurve>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CurveData, __InBuffer);
				}
			}
		}

		private static uint __TransformData = 0;

		private static uint __CurveData = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}