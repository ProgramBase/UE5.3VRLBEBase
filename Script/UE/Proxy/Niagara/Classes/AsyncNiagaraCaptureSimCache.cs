using Script.CoreUObject;
using Script.Engine;
using Script.Niagara.AsyncNiagaraCaptureSimCache;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.AsyncNiagaraCaptureSimCache")]
	public partial class UAsyncNiagaraCaptureSimCache : UCancellableAsyncAction, IStaticClass
	{
		public UNiagaraSimCache CaptureSimCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSimCache, __ReturnBuffer);

					return *(UNiagaraSimCache*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureSimCache, __InBuffer);
				}
			}
		}

		public UNiagaraComponent CaptureComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponent, __ReturnBuffer);

					return *(UNiagaraComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponent, __InBuffer);
				}
			}
		}

		public FOnCaptureComplete CaptureComplete
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComplete, __ReturnBuffer);

					return *(FOnCaptureComplete*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComplete, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.AsyncNiagaraCaptureSimCache");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheUntilComplete(UNiagaraSimCache SimCache, FNiagaraSimCacheCreateParameters CreateParameters, UNiagaraComponent NiagaraComponent, ref UNiagaraSimCache OutSimCache, int CaptureRate, bool bAdvanceSimulation, float AdvanceDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = SimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CreateParameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NiagaraComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutSimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = CaptureRate;

				*(bool*)(__InBuffer + 36) = bAdvanceSimulation;

				*(float*)(__InBuffer + 37) = AdvanceDeltaTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureNiagaraSimCacheUntilComplete, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSimCache = *(UNiagaraSimCache*)(__OutBuffer);

				return *(UAsyncNiagaraCaptureSimCache*)__ReturnBuffer;
			}
		}

		public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCacheMultiFrame(UNiagaraSimCache SimCache, FNiagaraSimCacheCreateParameters CreateParameters, UNiagaraComponent NiagaraComponent, ref UNiagaraSimCache OutSimCache, int NumFrames, int CaptureRate, bool bAdvanceSimulation, float AdvanceDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[45];

				*(nint*)(__InBuffer) = SimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CreateParameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NiagaraComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutSimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 32) = NumFrames;

				*(int*)(__InBuffer + 36) = CaptureRate;

				*(bool*)(__InBuffer + 40) = bAdvanceSimulation;

				*(float*)(__InBuffer + 41) = AdvanceDeltaTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureNiagaraSimCacheMultiFrame, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSimCache = *(UNiagaraSimCache*)(__OutBuffer);

				return *(UAsyncNiagaraCaptureSimCache*)__ReturnBuffer;
			}
		}

		public static UAsyncNiagaraCaptureSimCache CaptureNiagaraSimCache(UNiagaraSimCache SimCache, FNiagaraSimCacheCreateParameters CreateParameters, UNiagaraComponent NiagaraComponent, FNiagaraSimCacheCaptureParameters CaptureParameters, ref UNiagaraSimCache OutSimCache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = SimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CreateParameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NiagaraComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = CaptureParameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutSimCache?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureNiagaraSimCache, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSimCache = *(UNiagaraSimCache*)(__OutBuffer);

				return *(UAsyncNiagaraCaptureSimCache*)__ReturnBuffer;
			}
		}

		private static uint __CaptureSimCache = 0;

		private static uint __CaptureComponent = 0;

		private static uint __CaptureComplete = 0;

		private static uint __CaptureNiagaraSimCacheUntilComplete = 0;

		private static uint __CaptureNiagaraSimCacheMultiFrame = 0;

		private static uint __CaptureNiagaraSimCache = 0;
	}
}