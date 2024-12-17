using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraUserRedirectionParameterStore")]
	public partial class FNiagaraUserRedirectionParameterStore : FNiagaraParameterStore, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraUserRedirectionParameterStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraUserRedirectionParameterStore()
		{
		}

		public static bool operator ==(FNiagaraUserRedirectionParameterStore A, FNiagaraUserRedirectionParameterStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraUserRedirectionParameterStore A, FNiagaraUserRedirectionParameterStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraUserRedirectionParameterStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FNiagaraVariable, FNiagaraVariable> UserParameterRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserParameterRedirects, __ReturnBuffer);

					return *(TMap<FNiagaraVariable, FNiagaraVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserParameterRedirects, __InBuffer);
				}
			}
		}

		private static uint __UserParameterRedirects = 0;

	}
}