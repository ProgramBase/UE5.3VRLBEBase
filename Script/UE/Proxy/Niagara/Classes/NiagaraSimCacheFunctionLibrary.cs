using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSimCacheFunctionLibrary")]
	public partial class UNiagaraSimCacheFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraSimCacheFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UNiagaraSimCache CreateNiagaraSimCache(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNiagaraSimCache, __InBuffer, __ReturnBuffer);

				return *(UNiagaraSimCache*)__ReturnBuffer;
			}
		}

		public static bool CaptureNiagaraSimCacheImmediate(UNiagaraSimCache SimCache, FNiagaraSimCacheCreateParameters CreateParameters, UNiagaraComponent NiagaraComponent, ref UNiagaraSimCache OutSimCache, bool bAdvanceSimulation, float AdvanceDeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = SimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CreateParameters?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NiagaraComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutSimCache?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bAdvanceSimulation;

				*(float*)(__InBuffer + 33) = AdvanceDeltaTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CaptureNiagaraSimCacheImmediate, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSimCache = *(UNiagaraSimCache*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __CreateNiagaraSimCache = 0;

		private static uint __CaptureNiagaraSimCacheImmediate = 0;
	}
}