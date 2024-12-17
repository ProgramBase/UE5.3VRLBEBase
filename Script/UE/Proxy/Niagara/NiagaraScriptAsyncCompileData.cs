using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptAsyncCompileData")]
	public partial class FNiagaraScriptAsyncCompileData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScriptAsyncCompileData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScriptAsyncCompileData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraScriptAsyncCompileData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraScriptAsyncCompileData A, FNiagaraScriptAsyncCompileData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScriptAsyncCompileData A, FNiagaraScriptAsyncCompileData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScriptAsyncCompileData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraVariable> RapidIterationParameters
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RapidIterationParameters, __ReturnBuffer);

					return *(TArray<FNiagaraVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RapidIterationParameters, __InBuffer);
				}
			}
		}

		public TMap<FName, UNiagaraDataInterface> NamedDataInterfaces
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NamedDataInterfaces, __ReturnBuffer);

					return *(TMap<FName, UNiagaraDataInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NamedDataInterfaces, __InBuffer);
				}
			}
		}

		private static uint __RapidIterationParameters = 0;

		private static uint __NamedDataInterfaces = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}