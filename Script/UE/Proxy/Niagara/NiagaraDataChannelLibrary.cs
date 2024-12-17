using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelLibrary")]
	public partial class UNiagaraDataChannelLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataChannelLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UNiagaraDataChannelWriter WriteToNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame, bool bVisibleToCPU, bool bVisibleToGPU)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[31];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Channel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SearchParams?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = Count;

				*(bool*)(__InBuffer + 28) = bVisibleToGame;

				*(bool*)(__InBuffer + 29) = bVisibleToCPU;

				*(bool*)(__InBuffer + 30) = bVisibleToGPU;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __WriteToNiagaraDataChannel, __InBuffer, __ReturnBuffer);

				return *(UNiagaraDataChannelWriter*)__ReturnBuffer;
			}
		}

		public static UNiagaraDataChannelReader ReadFromNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel, FNiagaraDataChannelSearchParameters SearchParams, bool bReadPreviousFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Channel?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SearchParams?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bReadPreviousFrame;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ReadFromNiagaraDataChannel, __InBuffer, __ReturnBuffer);

				return *(UNiagaraDataChannelReader*)__ReturnBuffer;
			}
		}

		public static UNiagaraDataChannelHandler GetNiagaraDataChannel(UObject WorldContextObject, UNiagaraDataChannelAsset Channel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Channel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraDataChannel, __InBuffer, __ReturnBuffer);

				return *(UNiagaraDataChannelHandler*)__ReturnBuffer;
			}
		}

		private static uint __WriteToNiagaraDataChannel = 0;

		private static uint __ReadFromNiagaraDataChannel = 0;

		private static uint __GetNiagaraDataChannel = 0;
	}
}