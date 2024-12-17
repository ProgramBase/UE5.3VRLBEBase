using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheEmitterFrame")]
	public partial class FNiagaraSimCacheEmitterFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSimCacheEmitterFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSimCacheEmitterFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSimCacheEmitterFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSimCacheEmitterFrame A, FNiagaraSimCacheEmitterFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSimCacheEmitterFrame A, FNiagaraSimCacheEmitterFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSimCacheEmitterFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBox LocalBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LocalBounds, __InBuffer);
				}
			}
		}

		public int TotalSpawnedParticles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TotalSpawnedParticles, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TotalSpawnedParticles, __InBuffer);
				}
			}
		}

		public FNiagaraSimCacheDataBuffers ParticleDataBuffers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParticleDataBuffers, __ReturnBuffer);

					return *(FNiagaraSimCacheDataBuffers*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParticleDataBuffers, __InBuffer);
				}
			}
		}

		private static uint __LocalBounds = 0;

		private static uint __TotalSpawnedParticles = 0;

		private static uint __ParticleDataBuffers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}